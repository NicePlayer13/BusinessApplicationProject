using System.Linq.Expressions;
using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Helpers;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Validation;
using Microsoft.EntityFrameworkCore;
namespace BusinessApplicationProject.View
{

    public partial class UsrCtrlCustomers : UserControl
    {

        public static UsrCtrlCustomers instance;

        private readonly Controller<Customer> _customerController;
        private readonly Controller<Order> _orderController;

        private readonly ErrorProvider _errors = new ErrorProvider();


        public UsrCtrlCustomers(
            Controller<Customer> customerController,
            Controller<Order> orderController)
        {
            InitializeComponent();

            _customerController = customerController;
            _orderController = orderController;
            instance = this;
            _errors.ContainerControl = this;
            _errors.BlinkStyle = ErrorBlinkStyle.NeverBlink;
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

        //#region SearchUpdate
        //private Controller<Customer> customerController = new Controller<Customer>
        //{
        //    GetContext = () => new AppDbContext(),
        //    GetRepository = context => new Repository<Customer>(context)
        //};

        //private Controller<Order> orderController = new Controller<Order>
        //{
        //    GetContext = () => new AppDbContext(),
        //    GetRepository = context => new TemporalRepository<Order>(context)
        //};

        public void UpdateSearchResults()
        {
            DataGridViewCustomersResults.AutoGenerateColumns = false;
            LblDataGridCustomersNoResults.Visible = false;
            DataGridViewCustomersResults.DataSource = null;
            DataGridViewCustomersResults.Columns.Clear();

            try
            {
                var filter = CreateFilterFunction();
                List<Customer> customers = _customerController
                    .Find(filter)
                    .ToList();


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
                (string.IsNullOrEmpty(TxtSearchCustomerCountry.Text) || (customer.CustomerAddress != null && customer.CustomerAddress.Country.Contains(TxtSearchCustomerCountry.Text))) &&
                (string.IsNullOrEmpty(TxtSearchCustomerCity.Text) || (customer.CustomerAddress != null && customer.CustomerAddress.City.Contains(TxtSearchCustomerCity.Text))) &&
                (string.IsNullOrEmpty(TxtSearchCustomerAdress.Text) || (customer.CustomerAddress != null && customer.CustomerAddress.StreetAddress.Contains(TxtSearchCustomerAdress.Text))) &&
                (string.IsNullOrEmpty(TxtSearchCustomerEmail.Text) || (!string.IsNullOrEmpty(customer.Email) && customer.Email.Contains(TxtSearchCustomerEmail.Text)));
        }



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

            using var context = new AppDbContext();
            TxtInputCustomerNumber.Text = NextCustomerNumber(context);
            TxtInputCustomerNumber.ReadOnly = true;

            DataGridViewCustomerOrders.DataSource = null;
            DataGridViewCustomerOrders.Columns.Clear();
            DataGridViewCustomersResults.DataSource = null;
            DataGridViewCustomersResults.Columns.Clear();
        }


        private static string NextCustomerNumber(AppDbContext context)
        {
            var numbers = context.Customers
                .Select(c => c.CustomerNumber)
                .Where(n => n.StartsWith("CU") && n.Length >= 6)
                .ToList();

            int max = 0;
            foreach (var n in numbers)
                if (int.TryParse(n.Substring(2), out var num) && num > max)
                    max = num;

            return $"CU{(max + 1):D4}";
        }


        private async void CmdSaveChangesCustomer_Click(object sender, EventArgs e)
        {
            // 1) VALIDATE (trim first)
            string custNr = TxtInputCustomerNumber.Text?.Trim() ?? "";
            string email = TxtInputCustomerEmail.Text?.Trim() ?? "";
            string website = TxtInputCustomerWebsite.Text?.Trim() ?? "";
            string pwd = TxtInputCustomerPassword.Text ?? "";

            bool ok = true;
            void SetErr(Control c, bool valid, string msg) { _errors.SetError(c, valid ? "" : msg); if (!valid) ok = false; }

            SetErr(TxtInputCustomerNumber, CustomerValidation.CustomerNr(custNr), "Format: CU12345");
            SetErr(TxtInputCustomerEmail, CustomerValidation.Email(email), "Invalid email");
            if (!string.IsNullOrWhiteSpace(website))
                SetErr(TxtInputCustomerWebsite, CustomerValidation.Website(website), "Invalid website");
            if (!string.IsNullOrWhiteSpace(pwd))

                SetErr(TxtInputCustomerPassword, CustomerValidation.Password(pwd), "Min 8 chars incl. Aa0-9");

            if (!ok) return;

            // 2) Confirm once
            if (!WarningUpdatedObject())
            {
                UpdateSearchResults();
                return;
            }

            try
            {
                using var context = new AppDbContext();
                if (string.IsNullOrWhiteSpace(custNr))
                {
                    custNr = NextCustomerNumber(context);
                    TxtInputCustomerNumber.Text = custNr;
                }
                var existingCustomer = context.Customers
                    .Include(c => c.CustomerAddress)
                    .FirstOrDefault(x => x.CustomerNumber == custNr);

                if (existingCustomer != null)
                {
                    // Address (create-or-update)
                    if (existingCustomer.CustomerAddress == null)
                    {
                        existingCustomer.CustomerAddress = new Address
                        {
                            StreetAddress = TxtInputCustomerAdress.Text,
                            ZipCode = TxtInputCustomerPostalCode.Text,
                            City = TxtInputCustomerCity.Text,
                            Country = TxtInputCustomerCountry.Text
                        };
                        context.Entry(existingCustomer.CustomerAddress).State = EntityState.Added;
                    }
                    else
                    {
                        existingCustomer.CustomerAddress.StreetAddress = TxtInputCustomerAdress.Text;
                        existingCustomer.CustomerAddress.ZipCode = TxtInputCustomerPostalCode.Text;
                        existingCustomer.CustomerAddress.City = TxtInputCustomerCity.Text;
                        existingCustomer.CustomerAddress.Country = TxtInputCustomerCountry.Text;
                        context.Entry(existingCustomer.CustomerAddress).State = EntityState.Modified;
                    }

                    // Customer fields
                    existingCustomer.FirstName = TxtInputCustomerFirstName.Text;
                    existingCustomer.LastName = TxtInputCustomerLastName.Text;
                    existingCustomer.Email = email;
                    existingCustomer.Website = string.IsNullOrWhiteSpace(website) ? null : website;
                    context.Entry(existingCustomer).State = EntityState.Modified;

                    await context.SaveChangesAsync();
                    MessageBox.Show("Customer updated successfully!");
                    UpdateSearchResults();
                }
                else
                {
                    // Generate new CU number
                    int maxCustNumber = context.Customers
                    .AsEnumerable() 
                    .Select(n => int.TryParse(n.CustomerNumber?.Substring(2), out var number) ? number : 0)
                    .Max();

                        
                    string newNumber = $"CU{(++maxCustNumber):D4}";

                    // Create Address first
                    var newAddress = new Address
                    {
                        StreetAddress = TxtInputCustomerAdress.Text,
                        ZipCode = TxtInputCustomerPostalCode.Text,
                        City = TxtInputCustomerCity.Text,
                        Country = TxtInputCustomerCountry.Text
                    };
                    await context.Addresses.AddAsync(newAddress);
                    await context.SaveChangesAsync(); // ensure Id

                    // Create Customer
                    var newCustomer = new Customer
                    {
                        CustomerNumber = newNumber,
                        CustomerAddressId = newAddress.Id,
                        CustomerAddress = newAddress,
                        FirstName = TxtInputCustomerFirstName.Text,
                        LastName = TxtInputCustomerLastName.Text,
                        Email = email,
                        Website = string.IsNullOrWhiteSpace(website) ? null : website
                    };

                    await context.Customers.AddAsync(newCustomer);
                    await context.SaveChangesAsync();

                    MessageBox.Show("New customer added successfully!");
                    UpdateSearchResults();
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("DB connection failed. Please check connection.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void CmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!WarningDeletedObject()) return;

            var custNr = (TxtInputCustomerNumber?.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(custNr))
            {
                MessageBox.Show("No customer number specified.");
                return;
            }

            try
            {
                var cust = _customerController.FindSingle(x => x.CustomerNumber == custNr);
                if (cust != null)
                {
                    _customerController.Remove(cust);
                    MessageBox.Show("Customer deleted.");
                    UpdateSearchResults();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("DB error occurred. Please check connection.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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
            if (customer == null) return;

            TxtInputCustomerNumber.Text = customer.CustomerNumber;
            TxtInputCustomerFirstName.Text = customer.FirstName;
            TxtInputCustomerLastName.Text = customer.LastName;
            TxtInputCustomerEmail.Text = customer.Email ?? "";
            TxtInputCustomerWebsite.Text = customer.Website ?? "";

            var addr = customer.CustomerAddress;
            TxtInputCustomerAdress.Text = addr?.StreetAddress ?? "";
            TxtInputCustomerPostalCode.Text = addr?.ZipCode ?? "";
            TxtInputCustomerCity.Text = addr?.City ?? "";
            TxtInputCustomerCountry.Text = addr?.Country ?? "";
        }


        private void UpdateOrderDataGridView(Customer? customer)
        {
            if (customer != null)
            {
                try
                {
                    List<Order> orders = _orderController
                    .Find(x => x.CustomerDetails.Id == customer.Id)
                       .ToList();


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

        private void CmdShowAllCustomers_Click(object sender, EventArgs e)
        {
            TxtSearchCustomerAdress.Text = "";
            TxtSearchCustomerCity.Text = "";
            TxtSearchCustomerCountry.Text = "";
            TxtSearchCustomerEmail.Text = "";
            TxtSearchCustomerFirstName.Text = "";
            TxtSearchCustomerLastName.Text = "";
            TxtSearchCustomerNumber.Text = "";
            TxtSearchCustomerWebsite.Text = "";

            UpdateSearchResults();
        }

        private void TxtInputCustomerNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdClearCustomer_Click(object sender, EventArgs e)
        {
            this.CmdClearCustomer.Click += new System.EventHandler(this.CmdClearCustomer_Click);

            EmptyFieldsCustomers();

            using var context = new AppDbContext();
            TxtInputCustomerNumber.Text = NextCustomerNumber(context);
            TxtInputCustomerNumber.ReadOnly = true;

            DataGridViewCustomerOrders.DataSource = null;
            DataGridViewCustomerOrders.Columns.Clear();
            DataGridViewCustomersResults.DataSource = null;
            DataGridViewCustomersResults.Columns.Clear();
        }

        private void CmdExportCustomers_Click_Click(object sender, EventArgs e)
        {
            var customers = _customerController.GetAll().ToList();

            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Export Customers"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SerializationHelper.SerializeToXml(customers, dialog.FileName);
                MessageBox.Show("Export successful!");
            }
        }
    }
}
