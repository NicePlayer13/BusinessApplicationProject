using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlOrders : UserControl
    {
        public static UsrCtrlOrders instance = new();

        public UsrCtrlOrders()
        {
            InitializeComponent();

        }

        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            var filter = CreateFilterFunction();

            List<Order> orders = new List<Order>();
            orders = orderController.Find(filter);

            if(orders.Count > 0)
            {
                LblGridViewOrdersNoResults.Visible = false;

                DataGridViewOrdersResults.ClearSelection();
                DataGridViewOrdersResults.DataSource = null;
                DataGridViewOrdersResults.Columns.Clear();
                DataGridViewOrdersResults.AutoGenerateColumns = false;

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

                DataGridViewOrdersResults.Columns.Add(orderNumberColumn);
                DataGridViewOrdersResults.Columns.Add(orderDateColumn);

                DataGridViewOrdersResults.DataSource = orders;
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

            try
            {
                List<Order> orders = [];
                var filter = CreateFilterFunction();
                orders = orderController.Find(filter);

                if (orders.Count > 0)
                {
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
                        DataPropertyName = "CustomerNumber"
                    };

                    DataGridViewTextBoxColumn customerFirstNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerFirstNameColumn",
                        HeaderText = "Customer First Name",
                        DataPropertyName = "CustomerFirstName"
                    };

                    DataGridViewTextBoxColumn customerLastNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerLastNameColumn",
                        HeaderText = "Customer Last Name",
                        DataPropertyName = "CustomerLastName"
                    };

                    DataGridViewTextBoxColumn positionNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "positionNumberColumn",
                        HeaderText = "Position Number",
                        DataPropertyName = "PositionNumber"
                    };

                    DataGridViewOrdersResults.Columns.Add(orderNumberColumn);
                    DataGridViewOrdersResults.Columns.Add(customerNumberColumn);
                    DataGridViewOrdersResults.Columns.Add(customerFirstNameColumn);
                    DataGridViewOrdersResults.Columns.Add(customerLastNameColumn);
                    DataGridViewOrdersResults.Columns.Add(positionNumberColumn);
                    DataGridViewOrdersResults.Columns.Add(dateColumn);

                    DataGridViewOrdersResults.DataSource = orders;
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
                MessageBox.Show("An error occured.");
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
            //Throw warning
            if (WarningUpdatedObject())
            {
                //Load Ordernumber, Customernumber, Firstname, Lastname, Date and Invoice
                //update selected Object with inputfields
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
            //change Form to Invoice with selected Order
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
            if(DataGridViewOrderPositions.SelectedCells.Count != 1)
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
