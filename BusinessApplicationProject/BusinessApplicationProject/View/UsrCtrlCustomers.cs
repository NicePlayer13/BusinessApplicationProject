using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlCustomers : UserControl
    {
        public static UsrCtrlCustomers instance = new();

        public UsrCtrlCustomers()
        {
            InitializeComponent();
        }

        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            CmdSearchCustomers.Enabled = false;
            UpdateSearchResults();
            CmdSearchCustomers.Enabled = true;
        }

        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            //Empty fields
            TxtSearchCustomerAdress.Text = string.Empty;
            TxtSearchCustomerCity.Text = string.Empty;
            TxtSearchCustomerCountry.Text = string.Empty;
            TxtSearchCustomerEmail.Text = string.Empty;
            TxtSearchCustomerFirstName.Text = string.Empty;
            TxtSearchCustomerLastName.Text = string.Empty;
            TxtSearchCustomerNumber.Text = string.Empty;
            TxtSearchCustomerWebsite.Text = string.Empty;
        }
        #endregion

        #region SearchUpdate
        private Controller<Customer> customerController = new Controller<Customer>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = context => new Repository<Customer>(context)
        };

        private Controller<Order> orderController = new Controller<Order>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = context => new TemporalRepository<Order>(context)
        };

        public void UpdateSearchResults()
        {
            DataGridViewCustomersResults.AutoGenerateColumns = false;
            LblDataGridCustomersNoResults.Visible = false;
            DataGridViewCustomersResults.DataSource = null;
            DataGridViewCustomersResults.Columns.Clear();

            try
            {
                List<Customer> customers = [];
                var filter = CreateFilterFunction();
                customers = customerController.Find(filter);

                if (customers.Count > 0)
                {
                    DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerNumberColumn",
                        HeaderText = "Customer Number",
                        DataPropertyName = "CustomerNumber"
                    };

                    DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "firstNameColumn",
                        HeaderText = "First Name",
                        DataPropertyName = "FirstName"
                    };

                    DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "lastNameColumn",
                        HeaderText = "Last Name",
                        DataPropertyName = "LastName"
                    };

                    DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "emailColumn",
                        HeaderText = "Email Address",
                        DataPropertyName = "Email"
                    };

                    DataGridViewTextBoxColumn websiteColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "websiteColumn",
                        HeaderText = "Website",
                        DataPropertyName = "Website"
                    };

                    DataGridViewCustomersResults.Columns.Add(customerNumberColumn);
                    DataGridViewCustomersResults.Columns.Add(firstNameColumn);
                    DataGridViewCustomersResults.Columns.Add(lastNameColumn);
                    DataGridViewCustomersResults.Columns.Add(emailColumn);
                    DataGridViewCustomersResults.Columns.Add(websiteColumn);

                    DataGridViewCustomersResults.DataSource = customers;
                }
                else
                {
                    LblDataGridCustomersNoResults.Visible = true;
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

        private Expression<Func<Customer, bool>> CreateFilterFunction()
        {
            return customer =>
                (string.IsNullOrEmpty(TxtSearchCustomerNumber.Text) || customer.CustomerNumber.Contains(TxtSearchCustomerNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerFirstName.Text) || customer.FirstName.Contains(TxtSearchCustomerFirstName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerLastName.Text) || customer.LastName.Contains(TxtSearchCustomerLastName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerCountry.Text) || customer.CustomerAddress.Country.Contains(TxtSearchCustomerCountry.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerCity.Text) || customer.CustomerAddress.City.Contains(TxtSearchCustomerCity.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerAdress.Text) || customer.CustomerAddress.StreetAddress.Contains(TxtSearchCustomerAdress.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerEmail.Text) || (customer.Email != null && customer.Email.Contains(TxtSearchCustomerEmail.Text)));
        }
        #endregion

        #region Customers
        private void EmptyFieldsCustomers()
        {
            TxtInputCustomerAdress.Text = string.Empty;
            TxtInputCustomerCity.Text = string.Empty;
            TxtInputCustomerCountry.Text = string.Empty;
            TxtInputCustomerEmail.Text = string.Empty;
            TxtInputCustomerFirstName.Text = string.Empty;
            TxtInputCustomerLastName.Text = string.Empty;
            TxtInputCustomerNumber.Text = string.Empty;
            TxtInputCustomerPassword.Text = string.Empty;
            TxtInputCustomerPostalCode.Text = string.Empty;
            TxtInputCustomerWebsite.Text = string.Empty;
        }

        private void CmdCreateNewCustomer_Click(object sender, EventArgs e)
        {
            EmptyFieldsCustomers();

            DataGridViewCustomerOrders.DataSource = null;
            DataGridViewCustomerOrders.Columns.Clear();

            DataGridViewCustomersResults.DataSource = null;
            DataGridViewCustomersResults.Columns.Clear();
        }

        private async void CmdSaveChangesCustomer_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningUpdatedObject())
            {
                try
                {
                    var existingCustomer = customerController.FindSingle(x => x.CustomerNumber == TxtInputCustomerNumber.Text);

                    if (existingCustomer != null)
                    {
                        existingCustomer.CustomerAddress.StreetAddress = TxtInputCustomerAdress.Text;
                        existingCustomer.CustomerAddress.ZipCode = TxtInputCustomerPostalCode.Text;
                        existingCustomer.CustomerAddress.City = TxtInputCustomerCity.Text;
                        existingCustomer.CustomerAddress.Country = TxtInputCustomerCountry.Text;

                        existingCustomer.FirstName = TxtInputCustomerFirstName.Text;
                        existingCustomer.LastName = TxtInputCustomerLastName.Text;

                        existingCustomer.Email = TxtInputCustomerEmail.Text;
                       

                        try
                        {
                            customerController.Update(existingCustomer);
                            MessageBox.Show("Updated customer.");
                            UpdateSearchResults();
                        }
                        catch (TimeoutException)
                        {
                            MessageBox.Show("DB connection failed. Please check connection.");
                        }
                        catch
                        {
                            MessageBox.Show("An error occurred.");
                        }
                    }
                    else
                    {
                        var allCustomers = customerController.GetAll();

                        int maxCustNumber = (allCustomers.Count > 0) ?
                            allCustomers.Select(n => int.Parse(n.CustomerNumber.Split('-')[1]))
                            .Max() : 0;

                        string custNumber = (++maxCustNumber).ToString().PadLeft(5, '0');
                        custNumber = "C-" + custNumber;

                        var newAddress = new Address
                        {
                            StreetAddress = TxtInputCustomerAdress.Text,
                            ZipCode = TxtInputCustomerPostalCode.Text,
                            City = TxtInputCustomerCity.Text,
                            Country = TxtInputCustomerCountry.Text
                        };

                        // Ensure the address is added to the database and gets an ID
                        await customerController.GetContext().Set<Address>().AddAsync(newAddress);
                        await customerController.GetContext().SaveChangesAsync(); // Save so newAddress gets an ID

                        var newCustomer = new Customer
                        {
                            CustomerNumber = custNumber,
                            CustomerAddressId = newAddress.Id,  // ✅ Set required CustomerAddressId
                            CustomerAddress = newAddress,
                            FirstName = TxtInputCustomerFirstName.Text,
                            LastName = TxtInputCustomerLastName.Text,
                            Email = TxtInputCustomerEmail.Text,
                        };

                        // Add the customer
                        await customerController.AddAsync(newCustomer);
                        MessageBox.Show("Added customer.");
                        UpdateSearchResults();


                        try
                        {
                            await customerController.AddAsync(newCustomer);
                            MessageBox.Show("Added customer.");
                            UpdateSearchResults();
                        }
                        catch (TimeoutException)
                        {
                            MessageBox.Show("DB connection failed. Please check connection.");
                        }
                        catch
                        {
                            MessageBox.Show("An error occurred.");
                        }
                    }
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("DB connection failed. Please check connection.");
                }
                catch
                {
                    MessageBox.Show("An error occurred.");
                }
            }
            else
            {
                UpdateSearchResults();
            }
        }

        private void CmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningDeletedObject())
            {
                try
                {
                    var cust = customerController.FindSingle(x => x.CustomerNumber == TxtInputCustomerNumber.Text);

                    if (cust != null)
                    {
                        customerController.Remove(cust);
                        MessageBox.Show("Customer deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Customer doesn't exits.");
                    }
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("DB error occurred. Please check connection.");
                }
                catch
                {
                    MessageBox.Show("An error occurred.");
                }
            }
        }
        #endregion

        #region Orders
        private void CmdOpenSelectedOrder_Click(object sender, EventArgs e)
        {
            var selection = Utils.GetSelectedItem<Order>(DataGridViewCustomerOrders);

            if (selection != null)
            {
                string orderNumber = selection.OrderNumber;
                Clipboard.SetText(orderNumber);
                MessageBox.Show($"{orderNumber} copied to clipboard.");
            }
            else
            {
                MessageBox.Show("No item selected.");
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

        private void DataGridViewCustomersResults_SelectionChanged(object sender, EventArgs e)
        {
            Customer? selection = Utils.GetSelectedItem<Customer>(DataGridViewCustomersResults);
            UpdateAdditionalInformations(selection);
        }

        private void UpdateAdditionalInformations(Customer? selection)
        {
            UpdateInputFields(selection);
            UpdateOrderDataGridView(selection);
        }

        private void UpdateInputFields(Customer? customer)
        {
            if (customer != null)
            {
                TxtInputCustomerNumber.Text = customer.CustomerNumber;
               

                TxtInputCustomerFirstName.Text = customer.FirstName;
                TxtInputCustomerLastName.Text = customer.LastName;
                TxtInputCustomerEmail.Text = customer.Email ?? "";
               

                TxtInputCustomerAdress.Text = customer.CustomerAddress.StreetAddress;
                TxtInputCustomerPostalCode.Text = customer.CustomerAddress.ZipCode;
                TxtInputCustomerCity.Text = customer.CustomerAddress.City;
                TxtInputCustomerCountry.Text = customer.CustomerAddress.Country;
            }
        }

        private void UpdateOrderDataGridView(Customer? customer)
        {
            if (customer != null)
            {
                try
                {
                    List<Order> orders = orderController.Find(x => x.CustomerDetails.Id == customer.Id);

                    DataGridViewCustomerOrders.ClearSelection();
                    DataGridViewCustomerOrders.DataSource = null;
                    DataGridViewCustomerOrders.AutoGenerateColumns = false;
                    DataGridViewCustomerOrders.Columns.Clear();

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

                    DataGridViewCustomerOrders.Columns.Add(orderNumberColumn);
                    DataGridViewCustomerOrders.Columns.Add(orderDateColumn);

                    DataGridViewCustomerOrders.DataSource = orders;
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("DB connection timed out. Please check connection.");
                }
                catch
                {
                    MessageBox.Show("Couldn't load related orders.");
                }
            }
        }
    }
}
