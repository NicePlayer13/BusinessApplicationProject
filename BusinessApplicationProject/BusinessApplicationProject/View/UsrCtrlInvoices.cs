using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlInvoices : UserControl
    {
        public static UsrCtrlInvoices instance = new();

        public UsrCtrlInvoices()
        {

            InitializeComponent();
            DatPckInvoiceDateFrom.MaxDate = DateTime.UtcNow.AddYears(1);
            DatPckInvoiceDateTo.MaxDate = DateTime.UtcNow.AddYears(1);
            DatPckInvoiceDateTo.Value = DatPckInvoiceDateTo.MaxDate;

            CmbEditPaymentMethod.Items.AddRange(new object[]
            {
                PaymentInformationConstants.PaymentMethods.CreditCard,
                PaymentInformationConstants.PaymentMethods.PayPal,
                PaymentInformationConstants.PaymentMethods.SamsungPay,
                PaymentInformationConstants.PaymentMethods.ApplePay
            });
            CmbEditPaymentStatus.Items.AddRange(new object[]
            {
                PaymentInformationConstants.PaymentStatuses.Pending,
                PaymentInformationConstants.PaymentStatuses.Paid,
                PaymentInformationConstants.PaymentStatuses.Cancelled
            });
            UpdateEditProperties(null);
        }

        private Controller<Invoice> invoiceController = new Controller<Invoice>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = context => new Repository<Invoice>(context)
        };

        private Controller<Order> orderController = new Controller<Order>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = context => new Repository<Order>(context)
        };

        private TemporalController<Article> articleController = new TemporalController<Article>
        {
            GetContext = () => new AppDbContext(),
            GetTemporalRepository = context => new TemporalRepository<Article>(context),
            GetRepository = context => new TemporalRepository<Article>(context)  // ✅ Explicitly set GetRepository
        };




        private void ClearSearchResults()
        {
            DataGridViewInvoices.AutoGenerateColumns = false;
            LblNoResults.Visible = false;
            DataGridViewInvoices.DataSource = null;
            DataGridViewInvoices.Columns.Clear();
        }

        public void UpdateSearchResults()
        {
            ClearSearchResults();

            try
            {
                var filter = CreateFilterFunction();
                List<Invoice> invoices = invoiceController
                    .Find(filter)
                    .Include(i => i.OrderInformations) // ✅ Include Order
                        .ThenInclude(o => o.Positions) // ✅ Ensure Positions are loaded
                            .ThenInclude(p => p.ArticleDetails) // ✅ Ensure ArticleDetails are loaded
                    .Include(i => i.BillingAddress) // ✅ Include Billing Address
                    .ToList(); // ✅ Convert to List


                if (invoices.Count > 0)
                {
                    DataGridViewTextBoxColumn invoiceNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "invoiceNumberColumn",
                        HeaderText = "Invoice Number",
                        DataPropertyName = "InvoiceNumber"
                    };

                    DataGridViewTextBoxColumn dueDateColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "dueDateColumn",
                        HeaderText = "Due Date",
                        DataPropertyName = "DueDate"
                    };

                    DataGridViewTextBoxColumn paymentStatusColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "paymentStatusColumn",
                        HeaderText = "Payment Status",
                        DataPropertyName = "PaymentStatus"
                    };

                    DataGridViewTextBoxColumn paymentMethodColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "paymentMethodColumn",
                        HeaderText = "Payment Method",
                        DataPropertyName = "PaymentMethod"
                    };

                    DataGridViewTextBoxColumn discountColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "discountColumn",
                        HeaderText = "Discount",
                        DataPropertyName = "Discount"
                    };

                    DataGridViewTextBoxColumn taxPercentageColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "taxPercentageColumn",
                        HeaderText = "Tax Percentage",
                        DataPropertyName = "TaxPercentage"
                    };

                    DataGridViewInvoices.Columns.Add(invoiceNumberColumn);
                    DataGridViewInvoices.Columns.Add(dueDateColumn);
                    DataGridViewInvoices.Columns.Add(paymentStatusColumn);
                    DataGridViewInvoices.Columns.Add(paymentMethodColumn);
                    DataGridViewInvoices.Columns.Add(discountColumn);
                    DataGridViewInvoices.Columns.Add(taxPercentageColumn);

                    DataGridViewInvoices.DataSource = invoices;
                }
                else
                {
                    LblNoResults.Visible = true;
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database connection failed. Connection timed out.");
            }
            catch
            {
                MessageBox.Show("An error occured.");
            }
        }

        private Expression<Func<Invoice, bool>> CreateFilterFunction()
        {
            return invoice =>
                (string.IsNullOrEmpty(TxtSearchInvoiceNumber.Text) || invoice.InvoiceNumber.Contains(TxtSearchInvoiceNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerNumber.Text) || invoice.OrderInformations.CustomerDetails.CustomerNumber.Contains(TxtSearchCustomerNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchOrderNumber.Text) || invoice.OrderInformations.OrderNumber.Contains(TxtSearchOrderNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchFirstName.Text) || invoice.OrderInformations.CustomerDetails.FirstName.Contains(TxtSearchFirstName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchLastName.Text) || invoice.OrderInformations.CustomerDetails.LastName.Contains(TxtSearchLastName.Text)) &&
                (string.IsNullOrEmpty(TxtStreetAddress.Text) || invoice.BillingAddress.StreetAddress.Contains(TxtStreetAddress.Text)) &&
                (string.IsNullOrEmpty(TxtSearchZipCode.Text) || invoice.BillingAddress.ZipCode.Contains(TxtSearchZipCode.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCountry.Text) || invoice.BillingAddress.Country.Contains(TxtSearchCountry.Text)) &&
                (DatPckInvoiceDateFrom.Value == DatPckInvoiceDateFrom.MinDate || invoice.OrderInformations.Date >= DatPckInvoiceDateFrom.Value) &&
                (DatPckInvoiceDateTo.Value == DatPckInvoiceDateTo.MaxDate || invoice.OrderInformations.Date <= DatPckInvoiceDateTo.Value);
        }

        private void CmdSearchInvoices_Click(object sender, EventArgs e)
        {
            CmdSearchInvoices.Enabled = false;
            UpdateSearchResults();
            CmdSearchInvoices.Enabled = true;
        }

        private void CmdResetFilters_Click(object sender, EventArgs e)
        {
            TxtSearchInvoiceNumber.Text = string.Empty;
            TxtSearchCustomerNumber.Text = string.Empty;
            TxtSearchOrderNumber.Text = string.Empty;
            TxtSearchFirstName.Text = string.Empty;
            TxtSearchLastName.Text = string.Empty;
            TxtStreetAddress.Text = string.Empty;
            TxtSearchZipCode.Text = string.Empty;
            TxtSearchCountry.Text = string.Empty;
            DatPckInvoiceDateFrom.Value = DatPckInvoiceDateFrom.MinDate;
            DatPckInvoiceDateTo.Value = DatPckInvoiceDateTo.MaxDate;

            UpdateSearchResults();
        }

        private void CmdCopyCustomerNumber_Click(object sender, EventArgs e)
        {
            var selection = Utils.GetSelectedItem<Invoice>(DataGridViewInvoices);

            if (selection != null)
            {
                string customerNumber = selection.OrderInformations.CustomerDetails.CustomerNumber;
                Clipboard.SetText(customerNumber);
                MessageBox.Show($"{customerNumber} copied to clipboard.");
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        private void CmdCopyOrderNumber_Click(object sender, EventArgs e)
        {
            var selection = Utils.GetSelectedItem<Invoice>(DataGridViewInvoices);

            if (selection != null)
            {
                string orderNumber = selection.OrderInformations.OrderNumber;
                Clipboard.SetText(orderNumber);
                MessageBox.Show($"{orderNumber} copied to clipboard.");
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        public void UpdateEditProperties(Invoice? invoice)
        {
            if (invoice != null)
            {
                TxtEditInvoiceNumber.Text = invoice.InvoiceNumber;
                TxtEditOrderNumber.Text = invoice.OrderInformations?.OrderNumber ?? "Unknown";
                TxtEditOrderNumber.Enabled = false;

                ChkEditUseCustomerAddress.Checked = false;
                ChkEditUseCustomerAddress.Enabled = false;

                // ✅ Ensure BillingAddress is not null before accessing its properties
                if (invoice.BillingAddress != null)
                {
                    TxtEditStreetAddress.Text = invoice.BillingAddress.StreetAddress;
                    TxtEditZipCode.Text = invoice.BillingAddress.ZipCode;
                    TxtEditCity.Text = invoice.BillingAddress.City;
                    TxtEditCountry.Text = invoice.BillingAddress.Country;
                }
                else
                {
                    // ✅ Provide default values to avoid NullReferenceException
                    TxtEditStreetAddress.Text = "No Address";
                    TxtEditZipCode.Text = "N/A";
                    TxtEditCity.Text = "N/A";
                    TxtEditCountry.Text = "N/A";
                }

                NumEditDiscount.Value = (decimal)invoice.Discount;
                NumEditTaxes.Value = (decimal)invoice.TaxPercentage;

                CmbEditPaymentMethod.SelectedItem = invoice.PaymentMethod ?? "Unknown";
                CmbEditPaymentStatus.SelectedItem = invoice.PaymentStatus ?? "Unknown";
            }
            else
            {
                // ✅ Clear fields if invoice is null
                TxtEditInvoiceNumber.Text = "";
                TxtEditOrderNumber.Text = "";
                TxtEditOrderNumber.Enabled = true;

                ChkEditUseCustomerAddress.Checked = false;
                ChkEditUseCustomerAddress.Enabled = true;

                TxtEditStreetAddress.Text = "";
                TxtEditZipCode.Text = "";
                TxtEditCity.Text = "";
                TxtEditCountry.Text = "";

                NumEditDiscount.Value = 0;
                NumEditTaxes.Value = 8.1m;

                CmbEditPaymentMethod.SelectedIndex = 0;
                CmbEditPaymentStatus.SelectedIndex = 0;
            }
        }

        public void UpdateAdditionalDataGrids(Invoice invoice)
        {

            if (invoice.OrderInformations != null)
            {
                UpdateCustomerInformations(invoice.OrderInformations.CustomerDetails);
                UpdateOrderInformations(invoice);
                UpdatePositionInformations(invoice);
                UpdateBillingAddressInformations(invoice);
            }
            else
            {
                MessageBox.Show("No order linked to this invoice.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void UpdateCustomerInformations(Customer customer)
        {
            DataGridViewCustomerInformations.Columns.Clear();
            DataGridViewCustomerInformations.DataSource = null;
            DataGridViewCustomerInformations.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "customerNumberColumn",
                HeaderText = "Customer Number",
                DataPropertyName = "CustomerNumber"
            };

            DataGridViewCustomerInformations.Columns.Add(customerNumberColumn);

            DataGridViewCustomerInformations.DataSource = new List<Customer> { customer };
        }

        private void UpdateOrderInformations(Invoice invoice)
        {
            DataGridViewOrderDetails.Columns.Clear();
            DataGridViewOrderDetails.DataSource = null;
            DataGridViewOrderDetails.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn orderNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "orderNumberColumn",
                HeaderText = "Order Number",
                DataPropertyName = "OrderNumber"
            };

            DataGridViewTextBoxColumn orderDateColumn = new DataGridViewTextBoxColumn
            {
                Name = "orderDateColumn",
                HeaderText = "Order Date",
                DataPropertyName = "Date"
            };

            DataGridViewTextBoxColumn grossPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "grossPriceColumn ",
                HeaderText = "Gross Price",
                DataPropertyName = "GrossPrice"
            };

            DataGridViewTextBoxColumn netPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "netPriceColumn",
                HeaderText = "Net Price",
                DataPropertyName = "NetPrice"
            };

            DataGridViewOrderDetails.Columns.Add(orderNumberColumn);
            DataGridViewOrderDetails.Columns.Add(orderDateColumn);
            DataGridViewOrderDetails.Columns.Add(grossPriceColumn);
            DataGridViewOrderDetails.Columns.Add(netPriceColumn);

            Order order = invoice.OrderInformations;

            double grossPrice = 0;
            if (order.Positions == null || !order.Positions.Any())
            {
                MessageBox.Show("No positions found for this order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            foreach (var pos in order.Positions)
            {
                if (pos == null)
                {
                    MessageBox.Show("A null position was encountered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;  // Skip to the next position
                }

                if (pos.ArticleDetails == null)
                {
                    MessageBox.Show($"Position ID {pos.Id} has no linked ArticleDetails.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                var art = articleController.FindAsOf(order.Date, x => x.Id == pos.ArticleDetails.Id).FirstOrDefault();

                if (art != null)
                {
                    grossPrice += pos.Quantity * art.Price;
                }
                else
                {
                    MessageBox.Show($"Article not found for Position ID: {pos.Id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            var netPrice = (grossPrice - invoice.Discount) * ((100 + invoice.TaxPercentage) / 100);

            var flatOrder = new
            {
                order.OrderNumber,
                order.Date,
                GrossPrice = grossPrice,
                NetPrice = netPrice
            };

            DataGridViewOrderDetails.DataSource = new List<object> { flatOrder };
        }

        private void UpdatePositionInformations(Invoice invoice)
        {
            if (invoice.OrderInformations == null)
            {
                MessageBox.Show("Order information is missing.");
                return;
            }

            DataGridViewOrderPositions.Columns.Clear();
            DataGridViewOrderPositions.DataSource = null;
            DataGridViewOrderPositions.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn positionNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "positionNumberColumn",
                HeaderText = "Position Number",
                DataPropertyName = "PositionNumber"
            };

            DataGridViewTextBoxColumn articleNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "articleNumberColumn",
                HeaderText = "Article Number",
                DataPropertyName = "ArticleNumber"
            };

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                Name = "quantityColumn",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            };

            DataGridViewTextBoxColumn articleNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "articleNameColumn",
                HeaderText = "Name",
                DataPropertyName = "ArticleName"
            };

            DataGridViewTextBoxColumn grossPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "grossPriceColumn",
                HeaderText = "Gross Price per Unit",
                DataPropertyName = "GrossPrice"
            };

            DataGridViewOrderPositions.Columns.Add(positionNumberColumn);
            DataGridViewOrderPositions.Columns.Add(articleNumberColumn);
            DataGridViewOrderPositions.Columns.Add(quantityColumn);
            DataGridViewOrderPositions.Columns.Add(articleNameColumn);
            DataGridViewOrderPositions.Columns.Add(grossPriceColumn);

            Order order = invoice.OrderInformations;

            var flatPositions = new List<object>();

            foreach (var pos in invoice.OrderInformations.Positions ?? new List<Position>())
            {
                if (pos == null)
                {
                    MessageBox.Show("A null position was encountered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;  // Skip to the next position
                }

                if (pos.ArticleDetails == null)
                {
                    MessageBox.Show($"Position ID {pos.Id} has no linked ArticleDetails.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                var art = articleController.FindAsOf(invoice.OrderInformations.Date, x => x.Id == pos.ArticleDetails.Id).FirstOrDefault();

                if (art != null)
                {
                    flatPositions.Add(new
                    {
                        pos.PositionNumber,
                        art.ArticleNumber,
                        pos.Quantity,
                        ArticleName = art.Name,
                        GrossPrice = art.Price
                    });
                }
                else
                {
                    MessageBox.Show($"Article not found for Position ID: {pos.Id}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            DataGridViewOrderPositions.DataSource = flatPositions;
        }

        private void UpdateBillingAddressInformations(Invoice invoice)
        {
            DataGridViewBillingAddress.Columns.Clear();
            DataGridViewBillingAddress.DataSource = null;
            DataGridViewBillingAddress.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn streetAddressColumn = new DataGridViewTextBoxColumn
            {
                Name = "streetAddressColumn",
                HeaderText = "Street Address",
                DataPropertyName = "StreetAddress"
            };

            DataGridViewTextBoxColumn zipCodeColumn = new DataGridViewTextBoxColumn
            {
                Name = "zipCodeColumn",
                HeaderText = "Zip Code",
                DataPropertyName = "ZipCode"
            };

            DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn
            {
                Name = "cityColumn",
                HeaderText = "City",
                DataPropertyName = "City"
            };

            DataGridViewTextBoxColumn countryColumn = new DataGridViewTextBoxColumn
            {
                Name = "countryColumn",
                HeaderText = "Country",
                DataPropertyName = "Country"
            };

            DataGridViewBillingAddress.Columns.Add(streetAddressColumn);
            DataGridViewBillingAddress.Columns.Add(zipCodeColumn);
            DataGridViewBillingAddress.Columns.Add(cityColumn);
            DataGridViewBillingAddress.Columns.Add(countryColumn);

            DataGridViewBillingAddress.DataSource = new List<Address> { invoice.BillingAddress };
        }

        private void CmdCopyArticleNumber_Click(object sender, EventArgs e)
        {
            object? selection = Utils.GetSelectedItem<object>(DataGridViewOrderPositions);

            if (selection != null)
            {
                var propertyName = "ArticleNumber";
                var propertyInfo = selection.GetType().GetProperty(propertyName);

                if (propertyInfo != null)
                {
                    string artNo = propertyInfo.GetValue(selection)?.ToString() ?? "";

                    Clipboard.SetText(artNo);
                    MessageBox.Show($"{artNo} copied to clipboard.");
                }
                else
                {
                    MessageBox.Show($"Property '{propertyName}' not found.");
                }
                //var artNo = ((Article)selection).ArticleNumber;
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        private void DataGridViewInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewInvoices.DataSource != null)
            {
                if (DataGridViewInvoices.SelectedCells.Count > 0)
                {
                    var i = DataGridViewInvoices.SelectedCells[0].RowIndex;
                    var invoice = ((List<Invoice>)DataGridViewInvoices.DataSource)[i];
                    UpdateEditProperties(invoice);
                    UpdateAdditionalDataGrids(invoice);
                }
                else
                {
                    UpdateEditProperties(null);
                    UpdateAdditionalDataGrids(null);
                }
            }
            else
            {
                UpdateEditProperties(null);
                UpdateAdditionalDataGrids(null);
            }
        }

        private void CmdEditClear_Click(object sender, EventArgs e)
        {
            ClearSearchResults();
            UpdateEditProperties(null);
        }

        private async void CmdEditSave_Click(object sender, EventArgs e)
        {
            CmdEditSave.Enabled = false;

            try
            {
                var inv = invoiceController.FindSingle(x => x.InvoiceNumber == TxtEditInvoiceNumber.Text);
                var invExists = inv != null;

                if (invExists)
                {
                    // Invoice already exists
                    inv.BillingAddress.StreetAddress = TxtEditStreetAddress.Text;
                    inv.BillingAddress.ZipCode = TxtEditZipCode.Text;
                    inv.BillingAddress.City = TxtEditCity.Text;
                    inv.BillingAddress.Country = TxtEditCountry.Text;
                    inv.Discount = (double)NumEditDiscount.Value;
                    inv.TaxPercentage = (double)NumEditTaxes.Value;
                    inv.PaymentMethod = CmbEditPaymentMethod?.SelectedItem?.ToString() ?? "";
                    inv.PaymentStatus = CmbEditPaymentStatus?.SelectedItem?.ToString() ?? "";

                    try
                    {
                        invoiceController.Update(inv);
                        MessageBox.Show("Invoice updated.");
                        SearchInvoice(inv);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Couldn't update ivoice.");
                    }
                }
                else
                {
                    var order = orderController.FindSingle(x => x.OrderNumber == TxtEditOrderNumber.Text);

                    if (order != null)
                    {
                        Address? billingAddress;

                        if (ChkEditUseCustomerAddress.Checked)
                        {
                            billingAddress = new Address
                            {
                                StreetAddress = TxtEditStreetAddress.Text,
                                ZipCode = TxtEditZipCode.Text,
                                City = TxtEditCity.Text,
                                Country = TxtEditCountry.Text
                            };
                        }
                        else
                        {
                            billingAddress = order.CustomerDetails.CustomerAddress;
                        }

                        var invoices = invoiceController.GetAll().ToList(); // ✅ Convert IQueryable<Invoice> to List<Invoice>

                        int maxInvNumber = (invoices.Any()) // ✅ Use .Any() instead of .Count > 0
                            ? invoices.Select(n => int.Parse(n.InvoiceNumber.Split('-')[1])).Max()
                            : 0;


                        string invNumber = (++maxInvNumber).ToString().PadLeft(5, '0');
                        invNumber = "I-" + invNumber;

                        inv = new Invoice
                        {
                            InvoiceNumber = invNumber,
                            OrderId = order.Id, 
                            OrderInformations = order,
                            BillingAddressId = billingAddress.Id, 
                            BillingAddress = billingAddress,
                            Discount = (double)NumEditDiscount.Value,
                            TaxPercentage = (double)NumEditTaxes.Value,
                            PaymentMethod = CmbEditPaymentMethod?.SelectedItem?.ToString() ?? "",
                            PaymentStatus = CmbEditPaymentStatus?.SelectedItem?.ToString() ?? ""
                        };



                        try
                        {
                            await invoiceController.AddAsync(inv);
                            MessageBox.Show("Invoice saved.");
                            SearchInvoice(inv);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Couldn't save invoice.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Order doesn't exist");
                    }
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("A DB error occurred. Please check DB connection.");
            }
            catch
            {
                MessageBox.Show("An error occurred.");
            }

            CmdEditSave.Enabled = true;
        }

        private void SearchInvoice(Invoice invoice)
        {
            TxtSearchInvoiceNumber.Text = invoice.InvoiceNumber;
            UpdateSearchResults();
        }

        private void CmdEditDelete_Click(object sender, EventArgs e)
        {
            CmdEditDelete.Enabled = false;

            try
            {
                if(TxtEditInvoiceNumber.Text != String.Empty)
                {
                    var inv = invoiceController.FindSingle(x => x.InvoiceNumber == TxtEditInvoiceNumber.Text);

                    if(inv != null)
                    {
                        invoiceController.Remove(inv);
                    }
                    else
                    {
                        MessageBox.Show("Couldn't find invoice.");
                    }
                }
                else
                {
                    MessageBox.Show("No invoice selected.");
                }
            }
            catch(TimeoutException) 
            {
                MessageBox.Show("A DB error occurred. Please check DB connection.");
            }
            catch
            {
                MessageBox.Show("An error occurred.");
            }

            CmdEditDelete.Enabled = true;
        }
    }
}
