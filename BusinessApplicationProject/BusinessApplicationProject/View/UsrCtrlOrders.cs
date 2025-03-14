using System.Data;
using System.Linq.Expressions;
using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Migrations;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using Microsoft.EntityFrameworkCore;



namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlOrders : UserControl
    {
        public static UsrCtrlOrders instance;

        private FormMain _mainForm;  // ✅ Store reference to FormMain

        // ✅ Pass FormMain reference in constructor
        public UsrCtrlOrders(FormMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;  // ✅ Assign FormMain instance
            instance = this;  // ✅ Assign instance
        }

        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            // ✅ Ensure filters are applied
            var filter = CreateFilterFunction();

            List<Order> orders = orderController
                .Find(filter)
                .Include(o => o.CustomerDetails) // ✅ Load Customer
                .Include(o => o.Positions) // ✅ Load Order Positions
                .ThenInclude(p => p.ArticleDetails) // ✅ Load Article Details
                .ToList();

            if (orders.Count > 0)
            {
                LblGridViewOrdersNoResults.Visible = false;

                DataGridViewOrdersResults.ClearSelection();
                DataGridViewOrdersResults.DataSource = null;
                DataGridViewOrdersResults.Columns.Clear();
                DataGridViewOrdersResults.AutoGenerateColumns = false;

                // ✅ Ensure OrderId column exists
                DataGridViewTextBoxColumn orderIdColumn = new DataGridViewTextBoxColumn
                {
                    Name = "OrderId",
                    HeaderText = "Order ID",
                    DataPropertyName = "Id",
                    Visible = false  // Hide from UI but available for selection
                };

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

                DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
                {
                    Name = "customerNumberColumn",
                    HeaderText = "Customer Number",
                    DataPropertyName = "CustomerDetails_CustomerNumber"
                };

                DataGridViewTextBoxColumn customerFirstNameColumn = new DataGridViewTextBoxColumn
                {
                    Name = "customerFirstNameColumn",
                    HeaderText = "Customer First Name",
                    DataPropertyName = "CustomerDetails_FirstName"
                };

                DataGridViewTextBoxColumn customerLastNameColumn = new DataGridViewTextBoxColumn
                {
                    Name = "customerLastNameColumn",
                    HeaderText = "Customer Last Name",
                    DataPropertyName = "CustomerDetails_LastName"
                };

                DataGridViewTextBoxColumn totalPositionsColumn = new DataGridViewTextBoxColumn
                {
                    Name = "totalPositionsColumn",
                    HeaderText = "Total Positions",
                    DataPropertyName = "TotalPositions"
                };

                DataGridViewTextBoxColumn positionNumberColumn = new DataGridViewTextBoxColumn
                {
                    Name = "positionNumberColumn",
                    HeaderText = "Position Number",
                    DataPropertyName = "PositionNumber"
                };

                DataGridViewOrdersResults.Columns.Add(orderIdColumn);
                DataGridViewOrdersResults.Columns.Add(orderNumberColumn);
                DataGridViewOrdersResults.Columns.Add(orderDateColumn);
                DataGridViewOrdersResults.Columns.Add(customerNumberColumn);
                DataGridViewOrdersResults.Columns.Add(customerFirstNameColumn);
                DataGridViewOrdersResults.Columns.Add(customerLastNameColumn);
                DataGridViewOrdersResults.Columns.Add(totalPositionsColumn);
                DataGridViewOrdersResults.Columns.Add(positionNumberColumn);

                // ✅ Now set DataSource with additional Order details
                DataGridViewOrdersResults.DataSource = orders.Select(o => new
                {
                    o.Id,  // ✅ Add Order ID (used for selection)
                    o.OrderNumber,
                    o.Date,
                    CustomerDetails_CustomerNumber = o.CustomerDetails?.CustomerNumber ?? "N/A",
                    CustomerDetails_FirstName = o.CustomerDetails?.FirstName ?? "N/A",
                    CustomerDetails_LastName = o.CustomerDetails?.LastName ?? "N/A",
                    TotalPositions = o.Positions.Count,
                    PositionNumber = o.Positions.FirstOrDefault()?.PositionNumber ?? 0  // ✅ Show first position number
                }).ToList();
            }
            else
            {
                LblGridViewOrdersNoResults.Visible = true;
            }
        }




        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            ResetAllFilters();
        }

        private void ResetAllFilters()
        {
            //Reset Filters
            TxtSearchCustomerNumber.Text = string.Empty;
            TxtSearchCustomerFirstName.Text = string.Empty;
            TxtSearchCustomerLastName.Text = string.Empty;
            TxtSearchOrderPriceFrom.Text = string.Empty;
            TxtSearchOrderPriceTo.Text = string.Empty;
            TxtSearchOrdersPositionNumber.Text = string.Empty;
            DatSearchOrdersFrom.Value = DatSearchOrdersFrom.MinDate;
            DatSearchOrdersUntil.Value = DatSearchOrdersUntil.MaxDate;
        }


        private Controller<Order> orderController = new Controller<Order>
        {

            GetContext = () => new AppDbContext(),
            GetRepository = context => new Repository<Order>(context)
        };

        public void UpdateSearchResults()
        {
            DataGridViewOrdersResults.AutoGenerateColumns = false;
            LblGridViewOrdersNoResults.Visible = false;
            DataGridViewOrdersResults.DataSource = null;
            DataGridViewOrdersResults.Columns.Clear();
            ResetAllFilters();

            var filter = CreateFilterFunction();

            try
            {
                List<Order> orders = orderController
                    .Find(filter)
                    .Include(o => o.CustomerDetails) // ✅ Load Customer
                    .Include(o => o.Positions) // ✅ Load Order Positions
                    .ThenInclude(p => p.ArticleDetails) // ✅ Load Article Details
                    .Include(o => o.Invoices) // ✅ Load related invoices
                    .ToList();

                if (orders.Count > 0)
                {
                    // ✅ Ensure OrderId column exists
                    DataGridViewTextBoxColumn orderIdColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "OrderId",
                        HeaderText = "Order ID",
                        DataPropertyName = "Id",
                        Visible = false  // Hide from UI but available for selection
                    };

                    DataGridViewTextBoxColumn orderNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "orderNumberColumn",
                        HeaderText = "Order Number",
                        DataPropertyName = "OrderNumber"
                    };

                    DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "DateColumn",
                        HeaderText = "Date",
                        DataPropertyName = "Date"
                    };

                    DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerNumberColumn",
                        HeaderText = "Customer Number",
                        DataPropertyName = "CustomerDetails.CustomerNumber"
                    };

                    DataGridViewTextBoxColumn customerFirstNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerFirstNameColumn",
                        HeaderText = "Customer First Name",
                        DataPropertyName = "CustomerDetails.FirstName"
                    };

                    DataGridViewTextBoxColumn customerLastNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerLastNameColumn",
                        HeaderText = "Customer Last Name",
                        DataPropertyName = "CustomerDetails.LastName"
                    };

                    // ✅ New: Add Invoice Number Column
                    DataGridViewTextBoxColumn invoiceNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "invoiceNumberColumn",
                        HeaderText = "Invoice Number",
                        DataPropertyName = "InvoiceNumber"
                    };

                    DataGridViewOrdersResults.Columns.Add(orderIdColumn);
                    DataGridViewOrdersResults.Columns.Add(orderNumberColumn);
                    DataGridViewOrdersResults.Columns.Add(dateColumn);
                    DataGridViewOrdersResults.Columns.Add(customerNumberColumn);
                    DataGridViewOrdersResults.Columns.Add(customerFirstNameColumn);
                    DataGridViewOrdersResults.Columns.Add(customerLastNameColumn);
                    DataGridViewOrdersResults.Columns.Add(invoiceNumberColumn); // ✅ Added Invoice Column

                    // ✅ Now set DataSource with OrderId included
                    DataGridViewOrdersResults.DataSource = orders.Select(o => new
                    {
                        OrderId = o.Id,  // ✅ Add Order ID
                        o.OrderNumber,
                        o.Date,
                        CustomerNumber = o.CustomerDetails.CustomerNumber,
                        CustomerFirstName = o.CustomerDetails.FirstName,
                        CustomerLastName = o.CustomerDetails.LastName,
                        InvoiceNumber = o.Invoices.Any() ? o.Invoices.First().InvoiceNumber : "No Invoice" // ✅ Get the first invoice or show "No Invoice"
                    }).ToList();
                }
                else
                {
                    LblGridViewOrdersNoResults.Visible = true;
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database connection failed. Connection timed out.");
            }
            catch
            {
                MessageBox.Show("An error occurred.");
            }
        }


        private Expression<Func<Order, bool>> CreateFilterFunction()
        {
            return order =>
                (string.IsNullOrEmpty(TxtSearchCustomerNumber.Text) || order.CustomerDetails.CustomerNumber.Contains(TxtSearchCustomerNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerFirstName.Text) || order.CustomerDetails.FirstName.Contains(TxtSearchCustomerFirstName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerLastName.Text) || order.CustomerDetails.LastName.Contains(TxtSearchCustomerLastName.Text));
        }


        #endregion


        #region Orders

        private void CmdShowAllOrders_Click(object sender, EventArgs e)
        {
            ResetAllFilters();
            //Load all Orders into Grid
            UpdateSearchResults();
        }

        private void CmdEditSelectedOrder_Click(object sender, EventArgs e)
        {
            if (DataGridViewOrdersResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to edit.");
                return;
            }

            // ✅ Check if OrderId column exists
            if (!DataGridViewOrdersResults.Columns.Contains("OrderId"))
            {
                MessageBox.Show("Order ID column not found. Please refresh the data.");
                return;
            }

            // ✅ Ensure the selected row has a valid OrderId
            object orderIdValue = DataGridViewOrdersResults.SelectedRows[0].Cells["OrderId"].Value;
            if (orderIdValue == null)
            {
                MessageBox.Show("Selected order ID is invalid.");
                return;
            }

            int selectedOrderId;
            if (!int.TryParse(orderIdValue.ToString(), out selectedOrderId))
            {
                MessageBox.Show("Failed to parse Order ID.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var selectedOrder = context.Orders
                    .Include(o => o.CustomerDetails)
                    .Include(o => o.Positions)
                    .ThenInclude(p => p.ArticleDetails)
                    .FirstOrDefault(o => o.Id == selectedOrderId);

                if (selectedOrder == null)
                {
                    MessageBox.Show("Order not found in database.");
                    return;
                }

                // ✅ Populate order fields (with null-checks)
                TxtInputOrderNumber.Text = selectedOrder.OrderNumber;
                TxtInputOrderDate.Text = selectedOrder.Date.ToString("yyyy-MM-dd");
                TxtInputCustomerNumber.Text = selectedOrder.CustomerDetails?.CustomerNumber ?? "No Customer";
                TxtInputOrderCustomerFirstName.Text = selectedOrder.CustomerDetails?.FirstName ?? "Unknown";
                TxtInputOrderCustomerLastName.Text = selectedOrder.CustomerDetails?.LastName ?? "Unknown";

                // ✅ Populate Invoice Number (if available)
                var invoice = context.Invoices.FirstOrDefault(i => i.OrderId == selectedOrder.Id);
                TxtInputInvoiceNumber.Text = invoice?.InvoiceNumber ?? "No Invoice";

                // ✅ Check if Positions exist before binding
                if (selectedOrder.Positions != null && selectedOrder.Positions.Any())
                {
                    // ✅ Prevent duplicate columns
                    DataGridViewOrderPositions.DataSource = null;
                    DataGridViewOrderPositions.Columns.Clear();

                    // ✅ Bind Positions to DataGridViewOrderPositions (Fixed)
                    DataGridViewOrderPositions.DataSource = selectedOrder.Positions
                        .Select(p => new
                        {
                            PositionNumber = p.PositionNumber,  // ✅ Correctly map PositionNumber
                            Article = p.ArticleDetails?.ArticleNumber ?? "Unknown",
                            ArticleName = p.ArticleDetails?.Name ?? "Unknown",
                            Quantity = p.Quantity
                        })
                        .ToList();

                }
                else
                {
                    DataGridViewOrderPositions.DataSource = null;
                    MessageBox.Show("No positions found for this order.");
                }
            }

            //GrpInformationOrder.Visible = true; // ✅ Show the Order Info section
        }

        private void CmdDeleteSelectedObject_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
        }

        private void CmdShowInvoice_Click(object sender, EventArgs e)
        {
            if (DataGridViewOrdersResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to view its invoice.");
                return;
            }

            // ✅ Ensure OrderId column exists
            if (!DataGridViewOrdersResults.Columns.Contains("OrderId"))
            {
                MessageBox.Show("Order ID column not found. Please refresh the data.");
                return;
            }

            // ✅ Get selected Order ID
            int selectedOrderId = Convert.ToInt32(DataGridViewOrdersResults.SelectedRows[0].Cells["OrderId"].Value);

            using (var context = new AppDbContext())
            {
                var invoice = context.Invoices
                    .Include(i => i.OrderInformations)
                        .ThenInclude(o => o.CustomerDetails) // ✅ Ensure Customer is loaded
                    .Include(i => i.OrderInformations)
                        .ThenInclude(o => o.Positions)  // ✅ Ensure Positions are loaded
                            .ThenInclude(p => p.ArticleDetails)  // ✅ Ensure Article Details are loaded
                    .Include(i => i.BillingAddress)
                    .FirstOrDefault(i => i.OrderId == selectedOrderId);

                if (invoice == null)
                {
                    MessageBox.Show("No invoice found for this order.", "Invoice Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (invoice.OrderInformations == null)
                {
                    MessageBox.Show($"Invoice {invoice.InvoiceNumber} has NO linked Order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (invoice.OrderInformations.CustomerDetails == null)
                {
                    MessageBox.Show($"Customer details for invoice {invoice.InvoiceNumber} are missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Open Invoice Tab and Display Invoice Information
                Task.Delay(300).ContinueWith(_ =>
                {
                    if (UsrCtrlInvoices.instance != null)
                    {
                        UsrCtrlInvoices.instance.Invoke((MethodInvoker)(() =>
                        {
                            UsrCtrlInvoices.instance.UpdateEditProperties(invoice);
                            UsrCtrlInvoices.instance.UpdateAdditionalDataGrids(invoice);
                        }));
                    }
                });

            }

            // ✅ Switch to Invoice Tab
            if (_mainForm != null)
            {
                _mainForm.ToggleView(FormMain.View.Invoices, sender);
                
            }
            else
            {
                MessageBox.Show("Main form reference is missing. Cannot switch to Invoice view.");
            }

        }






        private void CmdDeleteOrder_Click(object sender, EventArgs e)
        {
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
        }


        #endregion


        #region Positions
        private void CmdOpenSelectedPosition_Click(object sender, EventArgs e)
        {
            //check if only one Position is selected
            if (DataGridViewOrderPositions.SelectedCells.Count != 1)
            {
                return;
            }
            //Show information of position
            GrpInformationSelectedPosition.Visible = true;

        }

        private void CmdAddNewPosition_Click(object sender, EventArgs e)
        {
            GrpInformationSelectedPosition.Visible = true;

            //create new PositionID

            //Empty all values
            CmbInputArticle.Text = string.Empty;
            TxtInputOrderPositionArticleQuantity.Text = string.Empty;
        }

        private void CmdDeleteSelectedPositions_Click(object sender, EventArgs e)
        {
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
        }

        private void CmdSavePositionChanges_Click(object sender, EventArgs e)
        {
            //values to check if valid Inputs
            int number;
            bool isNumeric = int.TryParse(TxtInputOrderPositionArticleQuantity.Text, out number);

            //checks if article is selected
            if (CmbInputArticle.SelectedItem == null)
            {
                //if not send error
                MessageBox.Show("Select a valid Article");

            }
            else if (isNumeric && number >= 1 && number <= 1000)
            {
                //Throw warning
                if (WarningUpdatedObject())
                {
                    //Change the selected Position with the new values
                }
            }
            else
            {
                MessageBox.Show("Select a valid Quantity of Articles");
            }
        }

        private void CmdSaveAsNewPosition_Click(object sender, EventArgs e)
        {
            //values to check if valid Inputs
            int number;
            bool isNumeric = int.TryParse(TxtInputOrderPositionArticleQuantity.Text, out number);

            //checks if article is selected
            if (CmbInputArticle.SelectedItem == null)
            {
                //if not send error
                MessageBox.Show("Select a valid Article");

            }
            else if (isNumeric && number >= 1 && number <= 100)
            {
                //Save as new position in selected Order
            }
            else
            {
                MessageBox.Show("Select a valid Quantity of Articles");
            }
        }

        #endregion


        private bool WarningDeletedObject()
        {
            DialogResult result = MessageBox.Show("Would you wish to delete all selected Objects?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool WarningUpdatedObject()
        {
            DialogResult result = MessageBox.Show("Would you wish to update the selected Object?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
