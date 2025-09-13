using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using BusinessApplicationProject.Controller;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Namespace for the user control handling Orders.
/// </summary>
namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlOrders : UserControl
    {
        public static UsrCtrlOrders instance;

        private FormMain _mainForm;

        public UsrCtrlOrders(FormMain mainForm, Controller<Order> orderController)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _orderController = orderController;
            instance = this;
        }


        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            // Ensure filters are applied
            var filter = CreateFilterFunction();

            List<Order> orders = _orderController
    .Find(filter)
    .Include(o => o.CustomerDetails)
    .Include(o => o.Positions)
    .ThenInclude(p => p.ArticleDetails)
    .ToList();


            if (orders.Count > 0)
            {
                LblGridViewOrdersNoResults.Visible = false;

                DataGridViewOrdersResults.ClearSelection();
                DataGridViewOrdersResults.DataSource = null;
                DataGridViewOrdersResults.Columns.Clear();
                DataGridViewOrdersResults.AutoGenerateColumns = false;

                // Ensure OrderId column exists
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

                //  Now set DataSource with additional Order details
                DataGridViewOrdersResults.DataSource = orders.Select(o => new
                {
                    o.Id,  //  Add Order ID (used for selection)
                    o.OrderNumber,
                    o.Date,
                    CustomerDetails_CustomerNumber = o.CustomerDetails?.CustomerNumber ?? "N/A",
                    CustomerDetails_FirstName = o.CustomerDetails?.FirstName ?? "N/A",
                    CustomerDetails_LastName = o.CustomerDetails?.LastName ?? "N/A",
                    TotalPositions = o.Positions.Count,
                    PositionNumber = o.Positions.FirstOrDefault()?.PositionNumber ?? 0  //  Show first position number
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


        private readonly Controller<Order> _orderController;


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
                List<Order> orders = _orderController
    .Find(filter)
    .Include(o => o.CustomerDetails)
    .Include(o => o.Positions)
    .ThenInclude(p => p.ArticleDetails)
    .ToList();


                if (orders.Count > 0)
                {
                    //  Ensure OrderId column exists
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

                    //  New: Add Invoice Number Column
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
                    DataGridViewOrdersResults.Columns.Add(invoiceNumberColumn); //  Added Invoice Column

                    //  Now set DataSource with OrderId included
                    DataGridViewOrdersResults.DataSource = orders.Select(o => new
                    {
                        OrderId = o.Id,  //  Add Order ID
                        o.OrderNumber,
                        o.Date,
                        CustomerNumber = o.CustomerDetails.CustomerNumber,
                        CustomerFirstName = o.CustomerDetails.FirstName,
                        CustomerLastName = o.CustomerDetails.LastName,
                        InvoiceNumber = o.Invoices.Any() ? o.Invoices.First().InvoiceNumber : "No Invoice" //  Get the first invoice or show "No Invoice"
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
        // Member variable at the class level.
        private Order _currentOrder;
        private void CmdEditSelectedOrder_Click(object sender, EventArgs e)
        {
            if (DataGridViewOrdersResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to edit.");
                return;
            }

            //  Check if OrderId column exists
            if (!DataGridViewOrdersResults.Columns.Contains("OrderId"))
            {
                MessageBox.Show("Order ID column not found. Please refresh the data.");
                return;
            }

            //  Ensure the selected row has a valid OrderId
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
                _currentOrder = selectedOrder; // Store the order for later update
                                               // Bind the positions to the DataGridView directly using the order's Positions collection.
                                               // After loading the order and storing it in _currentOrder:
                                               // Bind the positions directly to the DataGridView using the actual Position objects.
                if (_currentOrder.Positions != null && _currentOrder.Positions.Any())
                {
                    DataGridViewOrderPositions.DataSource = new BindingList<Position>(_currentOrder.Positions.ToList());
                }
                else
                {
                    DataGridViewOrderPositions.DataSource = null;
                    MessageBox.Show("No positions found for this order.");
                }
                if (selectedOrder.Positions != null && selectedOrder.Positions.Any())
                {
                    // Prevent duplicate columns
                    DataGridViewOrderPositions.DataSource = null;
                    DataGridViewOrderPositions.Columns.Clear();

                    // Bind Positions to DataGridViewOrderPositions (Fixed)
                    DataGridViewOrderPositions.DataSource = selectedOrder.Positions
                        .Select(p => new
                        {
                            PositionNumber = p.PositionNumber,
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

                //  Populate order fields (with null-checks)
                TxtInputOrderNumber.Text = selectedOrder.OrderNumber;
                TxtInputOrderDate.Text = selectedOrder.Date.ToString("yyyy-MM-dd");
                TxtInputCustomerNumber.Text = selectedOrder.CustomerDetails?.CustomerNumber ?? "No Customer";
                TxtInputOrderCustomerFirstName.Text = selectedOrder.CustomerDetails?.FirstName ?? "Unknown";
                TxtInputOrderCustomerLastName.Text = selectedOrder.CustomerDetails?.LastName ?? "Unknown";

                // Populate Invoice Number (if available)
                var invoice = context.Invoices.FirstOrDefault(i => i.OrderId == selectedOrder.Id);
                TxtInputInvoiceNumber.Text = invoice?.InvoiceNumber ?? "No Invoice";

                // Check if Positions exist before binding
                if (selectedOrder.Positions != null && selectedOrder.Positions.Any())
                {
                    //  Prevent duplicate columns
                    DataGridViewOrderPositions.DataSource = null;
                    DataGridViewOrderPositions.Columns.Clear();

                    //  Bind Positions to DataGridViewOrderPositions (Fixed)
                    DataGridViewOrderPositions.DataSource = selectedOrder.Positions
                        .Select(p => new
                        {
                            PositionNumber = p.PositionNumber,  //  Correctly map PositionNumber
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
            // Ensure a row is selected
            if (DataGridViewOrdersResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to view its invoice.");
                return;
            }

            // Ensure the hidden OrderId column exists and retrieve the order ID
            if (!DataGridViewOrdersResults.Columns.Contains("OrderId"))
            {
                MessageBox.Show("Order ID column not found. Please refresh the data.");
                return;
            }

            object orderIdValue = DataGridViewOrdersResults.SelectedRows[0].Cells["OrderId"].Value;
            if (orderIdValue == null || !int.TryParse(orderIdValue.ToString(), out int selectedOrderId))
            {
                MessageBox.Show("Selected order ID is invalid.");
                return;
            }

            // Load the invoice for the selected order
            using (var context = new AppDbContext())
            {
                var invoice = context.Invoices
                    .Include(i => i.OrderInformations)
                        .ThenInclude(o => o.Positions)
                            .ThenInclude(p => p.ArticleDetails)
                    .Include(i => i.OrderInformations)
                        .ThenInclude(o => o.CustomerDetails)
                    .Include(i => i.BillingAddress)
                    .FirstOrDefault(i => i.OrderId == selectedOrderId);

                if (invoice == null)
                {
                    MessageBox.Show("No invoice found for the selected order.", "Invoice Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Update the invoice user control with the loaded invoice data
                UsrCtrlInvoices.instance.UpdateSearchResults(i => i.InvoiceNumber == invoice.InvoiceNumber);
                UsrCtrlInvoices.instance.UpdateAdditionalDataGrids(invoice);
            }

            // Switch to the Invoice view via the main form.
            if (_mainForm != null)
            {
                _mainForm.ToggleView(FormMain.View.Invoices, sender);
                CmdShowInvoice.Enabled = true;
            }
            else
            {
                MessageBox.Show("Main form reference is missing. Cannot switch to Invoice view.");
            }
        }


        private void LoadArticlesIntoDropdown()
        {
            using (var context = new AppDbContext())
            {
                // Retrieve the list of articles from the database.
                List<Article> articles = context.Articles.ToList();

                // Set the ComboBox's DataSource to the articles list.
                CmbInputArticle.DataSource = articles;
                // Display the ArticleNumber (or any other property like Name) in the dropdown.
                CmbInputArticle.DisplayMember = "ArticleNumber";
                // Optionally, use the Id as the ValueMember.
                CmbInputArticle.ValueMember = "Id";
            }
        }






        private void CmdDeleteOrder_Click(object sender, EventArgs e)
        {
            if (WarningDeletedObject())
            {

            }
        }






        #region Positions
        private void CmdOpenSelectedPosition_Click(object sender, EventArgs e)
        {
            // Ensure exactly one row is selected
            if (DataGridViewOrderPositions.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select exactly one position to edit.",
                    "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row from the grid
            DataGridViewRow selectedRow = DataGridViewOrderPositions.SelectedRows[0];

            // Retrieve cell values using the column names from your query
            string positionNumber = selectedRow.Cells["PositionNumber"].Value?.ToString() ?? "";
            string quantity = selectedRow.Cells["Quantity"].Value?.ToString() ?? "";
            string articleNumber = selectedRow.Cells["Article"].Value?.ToString() ?? "";

            // Fill the editing text boxes with the retrieved values
            TxtInputPositionNumber.Text = positionNumber;
            TxtInputOrderPositionArticleQuantity.Text = quantity;

            // Now, update the ComboBox for the Article.
            // Assume that CmbInputArticle is already populated with either Article objects or strings.
            bool articleFound = false;
            foreach (var item in CmbInputArticle.Items)
            {
                if (item is Article article && article.ArticleNumber.Equals(articleNumber, StringComparison.OrdinalIgnoreCase))
                {
                    CmbInputArticle.SelectedItem = item;
                    articleFound = true;
                    break;
                }
                else if (item is string str && str.Equals(articleNumber, StringComparison.OrdinalIgnoreCase))
                {
                    CmbInputArticle.SelectedItem = item;
                    articleFound = true;
                    break;
                }
            }

            if (!articleFound)
            {
                // If no matching item was found, simply set the text.
                CmbInputArticle.Text = articleNumber;
            }
            LoadArticlesIntoDropdown();
            // Finally, show the group/panel that allows editing the selected position.
            GrpInformationSelectedPosition.Visible = true;
        }


        private void RefreshPositionsGrid()
        {
            DataGridViewOrderPositions.DataSource = new BindingList<Position>(_currentOrder.Positions.ToList());
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
            if (_currentOrder == null)
            {
                MessageBox.Show("No order is currently loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse input values...
            if (!int.TryParse(TxtInputPositionNumber.Text, out int newPositionNumber))
            {
                MessageBox.Show("Invalid position number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(TxtInputOrderPositionArticleQuantity.Text, out int newQuantity))
            {
                MessageBox.Show("Invalid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CmbInputArticle.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid article.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Article selectedArticle = CmbInputArticle.SelectedItem as Article;
            if (selectedArticle == null)
            {
                // Optionally, try to load it from the text if necessary.
                using (var context = new AppDbContext())
                {
                    selectedArticle = context.Articles
                        .FirstOrDefault(a => a.ArticleNumber.ToLower() == CmbInputArticle.Text.ToLower());
                }
                if (selectedArticle == null)
                {
                    MessageBox.Show("No valid article selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Confirm update with the user.
            if (!WarningUpdatedObject())
                return;

            // Locate the position to update in the order.
            // You may choose to identify the position by its PositionNumber or another unique identifier.
            Position posToUpdate = _currentOrder.Positions.FirstOrDefault(p => p.PositionNumber == newPositionNumber);
            if (posToUpdate == null)
            {
                MessageBox.Show("Position not found in the current order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the position's properties.
            posToUpdate.Quantity = newQuantity;
            posToUpdate.ArticleId = selectedArticle.Id;
            posToUpdate.ArticleDetails = selectedArticle;

            // Save the changes.
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Attach(_currentOrder);
                    context.SaveChanges();
                }
                MessageBox.Show("Position updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearPositionEditingFields();
                RefreshPositionsGrid();  // Method to rebind the grid to the updated positions.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating position: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CmdDeletePosition_Click(object sender, EventArgs e)
        {
            // Ensure exactly one row is selected
            if (DataGridViewOrderPositions.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select exactly one position to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Retrieve the selected Position from the DataGridView's DataBoundItem
            Position selectedPosition = DataGridViewOrderPositions.SelectedRows[0].DataBoundItem as Position;
            if (selectedPosition == null)
            {
                MessageBox.Show("Selected position is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion with the user
            if (!WarningDeletedObject())
                return;

            // Check if _currentOrder is available
            if (_currentOrder == null)
            {
                MessageBox.Show("No order is currently loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Remove the position from the order's Positions collection
            _currentOrder.Positions.Remove(selectedPosition);

            // Save changes to the database
            try
            {
                using (var context = new AppDbContext())
                {
                    // Attach the current order so that EF Core tracks changes in its child entities
                    context.Attach(_currentOrder);
                    // SaveChanges() will pick up the removal of the position and delete it if cascade delete is configured
                    context.SaveChanges();
                }
                MessageBox.Show("Position deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPositionsGrid(); // Refresh the grid to reflect the change
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting position: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
#endregion