namespace BusinessApplicationProject.View
{
    partial class UsrCtrlCustomers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GrpResults = new GroupBox();
            LblDataGridCustomersNoResults = new Label();
            DataGridViewCustomersResults = new DataGridView();
            GrpInformation = new GroupBox();
            LblInfoCustomerPostalCode = new Label();
            LblInfoCustomerCity = new Label();
            GrpOrders = new GroupBox();
            DataGridViewCustomerOrders = new DataGridView();
            CmdCopyOrderNumber = new Button();
            LblInfoCustomerWebsite = new Label();
            LblInfoCustomerEmail = new Label();
            LblInfoCustomerAdress = new Label();
            TxtInputCustomerNumber = new TextBox();
            TxtInputCustomerAdress = new TextBox();
            TxtInputCustomerPostalCode = new TextBox();
            TxtInputCustomerCity = new TextBox();
            TxtInputCustomerCountry = new TextBox();
            TxtInputCustomerWebsite = new TextBox();
            TxtInputCustomerEmail = new TextBox();
            TxtInputCustomerLastName = new TextBox();
            TxtInputCustomerFirstName = new TextBox();
            TxtInputCustomerPassword = new TextBox();
            LblInfoCustomerCountry = new Label();
            LblInfoCustomerLastName = new Label();
            LblInfoCustomerFirstName = new Label();
            LblInfoCustomerPassword = new Label();
            LblInfoCustomerNumber = new Label();
            CmdDeleteCustomer = new Button();
            CmdSaveChangesCustomer = new Button();
            CmdClearCustomer = new Button();
            GrpSearch = new GroupBox();
            TxtSearchCustomerWebsite = new TextBox();
            label1 = new Label();
            TxtSearchCustomerLastName = new TextBox();
            TxtSearchCustomerFirstName = new TextBox();
            TxtSearchCustomerAdress = new TextBox();
            TxtSearchCustomerCity = new TextBox();
            TxtSearchCustomerEmail = new TextBox();
            TxtSearchCustomerCountry = new TextBox();
            TxtSearchCustomerNumber = new TextBox();
            CmdResetSearchFilters = new Button();
            CmdSearchCustomers = new Button();
            LblInfoSearchCustomerLastName = new Label();
            LblInfoSearchCustomerFirstName = new Label();
            LblInfoSearchCustomerAdress = new Label();
            LblInfoSearchCustomerCity = new Label();
            LblInfoSearchCustomerEmail = new Label();
            LblInfoSearchCustomerCountry = new Label();
            LblInfoSearchCustomerNumber = new Label();
            CmdExportCustomers_Click = new Button();
            GrpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomersResults).BeginInit();
            GrpInformation.SuspendLayout();
            GrpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerOrders).BeginInit();
            GrpSearch.SuspendLayout();
            SuspendLayout();
            // 
            // GrpResults
            // 
            GrpResults.Controls.Add(LblDataGridCustomersNoResults);
            GrpResults.Controls.Add(DataGridViewCustomersResults);
            GrpResults.ForeColor = SystemColors.ControlText;
            GrpResults.Location = new Point(3, 251);
            GrpResults.Name = "GrpResults";
            GrpResults.Size = new Size(528, 385);
            GrpResults.TabIndex = 2;
            GrpResults.TabStop = false;
            GrpResults.Text = "Customers";
            // 
            // LblDataGridCustomersNoResults
            // 
            LblDataGridCustomersNoResults.AutoSize = true;
            LblDataGridCustomersNoResults.Location = new Point(233, 181);
            LblDataGridCustomersNoResults.Name = "LblDataGridCustomersNoResults";
            LblDataGridCustomersNoResults.Size = new Size(63, 15);
            LblDataGridCustomersNoResults.TabIndex = 1;
            LblDataGridCustomersNoResults.Text = "No Results";
            // 
            // DataGridViewCustomersResults
            // 
            DataGridViewCustomersResults.AllowUserToDeleteRows = false;
            DataGridViewCustomersResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomersResults.Location = new Point(6, 22);
            DataGridViewCustomersResults.MultiSelect = false;
            DataGridViewCustomersResults.Name = "DataGridViewCustomersResults";
            DataGridViewCustomersResults.ReadOnly = true;
            DataGridViewCustomersResults.RowHeadersWidth = 62;
            DataGridViewCustomersResults.Size = new Size(516, 328);
            DataGridViewCustomersResults.TabIndex = 1;
            DataGridViewCustomersResults.SelectionChanged += DataGridViewCustomersResults_SelectionChanged;
            // 
            // GrpInformation
            // 
            GrpInformation.Controls.Add(LblInfoCustomerPostalCode);
            GrpInformation.Controls.Add(LblInfoCustomerCity);
            GrpInformation.Controls.Add(GrpOrders);
            GrpInformation.Controls.Add(LblInfoCustomerWebsite);
            GrpInformation.Controls.Add(LblInfoCustomerEmail);
            GrpInformation.Controls.Add(LblInfoCustomerAdress);
            GrpInformation.Controls.Add(TxtInputCustomerNumber);
            GrpInformation.Controls.Add(TxtInputCustomerAdress);
            GrpInformation.Controls.Add(TxtInputCustomerPostalCode);
            GrpInformation.Controls.Add(TxtInputCustomerCity);
            GrpInformation.Controls.Add(TxtInputCustomerCountry);
            GrpInformation.Controls.Add(TxtInputCustomerWebsite);
            GrpInformation.Controls.Add(TxtInputCustomerEmail);
            GrpInformation.Controls.Add(TxtInputCustomerLastName);
            GrpInformation.Controls.Add(TxtInputCustomerFirstName);
            GrpInformation.Controls.Add(TxtInputCustomerPassword);
            GrpInformation.Controls.Add(LblInfoCustomerCountry);
            GrpInformation.Controls.Add(LblInfoCustomerLastName);
            GrpInformation.Controls.Add(LblInfoCustomerFirstName);
            GrpInformation.Controls.Add(LblInfoCustomerPassword);
            GrpInformation.Controls.Add(LblInfoCustomerNumber);
            GrpInformation.Controls.Add(CmdDeleteCustomer);
            GrpInformation.Controls.Add(CmdSaveChangesCustomer);
            GrpInformation.Controls.Add(CmdClearCustomer);
            GrpInformation.Location = new Point(555, 0);
            GrpInformation.Name = "GrpInformation";
            GrpInformation.Size = new Size(528, 636);
            GrpInformation.TabIndex = 2;
            GrpInformation.TabStop = false;
            GrpInformation.Text = "Information selected item";
            // 
            // LblInfoCustomerPostalCode
            // 
            LblInfoCustomerPostalCode.AutoSize = true;
            LblInfoCustomerPostalCode.Location = new Point(21, 160);
            LblInfoCustomerPostalCode.Name = "LblInfoCustomerPostalCode";
            LblInfoCustomerPostalCode.Size = new Size(70, 15);
            LblInfoCustomerPostalCode.TabIndex = 1;
            LblInfoCustomerPostalCode.Text = "Postal Code";
            // 
            // LblInfoCustomerCity
            // 
            LblInfoCustomerCity.AutoSize = true;
            LblInfoCustomerCity.Location = new Point(206, 160);
            LblInfoCustomerCity.Name = "LblInfoCustomerCity";
            LblInfoCustomerCity.Size = new Size(28, 15);
            LblInfoCustomerCity.TabIndex = 1;
            LblInfoCustomerCity.Text = "City";
            // 
            // GrpOrders
            // 
            GrpOrders.Controls.Add(CmdExportCustomers_Click);
            GrpOrders.Controls.Add(DataGridViewCustomerOrders);
            GrpOrders.Controls.Add(CmdCopyOrderNumber);
            GrpOrders.ForeColor = SystemColors.ControlText;
            GrpOrders.Location = new Point(0, 251);
            GrpOrders.Name = "GrpOrders";
            GrpOrders.Size = new Size(528, 385);
            GrpOrders.TabIndex = 2;
            GrpOrders.TabStop = false;
            GrpOrders.Text = "Orders";
            // 
            // DataGridViewCustomerOrders
            // 
            DataGridViewCustomerOrders.AllowUserToAddRows = false;
            DataGridViewCustomerOrders.AllowUserToDeleteRows = false;
            DataGridViewCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomerOrders.Location = new Point(6, 22);
            DataGridViewCustomerOrders.MultiSelect = false;
            DataGridViewCustomerOrders.Name = "DataGridViewCustomerOrders";
            DataGridViewCustomerOrders.ReadOnly = true;
            DataGridViewCustomerOrders.RowHeadersWidth = 62;
            DataGridViewCustomerOrders.Size = new Size(516, 328);
            DataGridViewCustomerOrders.TabIndex = 1;
            // 
            // CmdCopyOrderNumber
            // 
            CmdCopyOrderNumber.Location = new Point(6, 356);
            CmdCopyOrderNumber.Name = "CmdCopyOrderNumber";
            CmdCopyOrderNumber.Size = new Size(132, 23);
            CmdCopyOrderNumber.TabIndex = 0;
            CmdCopyOrderNumber.Text = "Copy order number";
            CmdCopyOrderNumber.UseVisualStyleBackColor = true;
            CmdCopyOrderNumber.Click += CmdOpenSelectedOrder_Click;
            // 
            // LblInfoCustomerWebsite
            // 
            LblInfoCustomerWebsite.AutoSize = true;
            LblInfoCustomerWebsite.Location = new Point(256, 107);
            LblInfoCustomerWebsite.Name = "LblInfoCustomerWebsite";
            LblInfoCustomerWebsite.Size = new Size(49, 15);
            LblInfoCustomerWebsite.TabIndex = 1;
            LblInfoCustomerWebsite.Text = "Website";
            // 
            // LblInfoCustomerEmail
            // 
            LblInfoCustomerEmail.AutoSize = true;
            LblInfoCustomerEmail.Location = new Point(256, 87);
            LblInfoCustomerEmail.Name = "LblInfoCustomerEmail";
            LblInfoCustomerEmail.Size = new Size(36, 15);
            LblInfoCustomerEmail.TabIndex = 1;
            LblInfoCustomerEmail.Text = "Email";
            // 
            // LblInfoCustomerAdress
            // 
            LblInfoCustomerAdress.AutoSize = true;
            LblInfoCustomerAdress.Location = new Point(21, 180);
            LblInfoCustomerAdress.Name = "LblInfoCustomerAdress";
            LblInfoCustomerAdress.Size = new Size(75, 15);
            LblInfoCustomerAdress.TabIndex = 1;
            LblInfoCustomerAdress.Text = "Street Adress";
            // 
            // TxtInputCustomerNumber
            // 
            TxtInputCustomerNumber.BackColor = SystemColors.ScrollBar;
            TxtInputCustomerNumber.BorderStyle = BorderStyle.None;
            TxtInputCustomerNumber.Cursor = Cursors.IBeam;
            TxtInputCustomerNumber.Enabled = false;
            TxtInputCustomerNumber.Location = new Point(139, 30);
            TxtInputCustomerNumber.Name = "TxtInputCustomerNumber";
            TxtInputCustomerNumber.ReadOnly = true;
            TxtInputCustomerNumber.Size = new Size(133, 16);
            TxtInputCustomerNumber.TabIndex = 2;
            TxtInputCustomerNumber.TextChanged += TxtInputCustomerNumber_TextChanged;
            // 
            // TxtInputCustomerAdress
            // 
            TxtInputCustomerAdress.BackColor = SystemColors.Window;
            TxtInputCustomerAdress.BorderStyle = BorderStyle.None;
            TxtInputCustomerAdress.Cursor = Cursors.IBeam;
            TxtInputCustomerAdress.Location = new Point(109, 180);
            TxtInputCustomerAdress.Name = "TxtInputCustomerAdress";
            TxtInputCustomerAdress.Size = new Size(133, 16);
            TxtInputCustomerAdress.TabIndex = 2;
            // 
            // TxtInputCustomerPostalCode
            // 
            TxtInputCustomerPostalCode.BackColor = SystemColors.Window;
            TxtInputCustomerPostalCode.BorderStyle = BorderStyle.None;
            TxtInputCustomerPostalCode.Cursor = Cursors.IBeam;
            TxtInputCustomerPostalCode.Location = new Point(109, 159);
            TxtInputCustomerPostalCode.Name = "TxtInputCustomerPostalCode";
            TxtInputCustomerPostalCode.Size = new Size(78, 16);
            TxtInputCustomerPostalCode.TabIndex = 2;
            // 
            // TxtInputCustomerCity
            // 
            TxtInputCustomerCity.BackColor = SystemColors.Window;
            TxtInputCustomerCity.BorderStyle = BorderStyle.None;
            TxtInputCustomerCity.Cursor = Cursors.IBeam;
            TxtInputCustomerCity.Location = new Point(256, 160);
            TxtInputCustomerCity.Name = "TxtInputCustomerCity";
            TxtInputCustomerCity.Size = new Size(133, 16);
            TxtInputCustomerCity.TabIndex = 2;
            // 
            // TxtInputCustomerCountry
            // 
            TxtInputCustomerCountry.BackColor = SystemColors.Window;
            TxtInputCustomerCountry.BorderStyle = BorderStyle.None;
            TxtInputCustomerCountry.Cursor = Cursors.IBeam;
            TxtInputCustomerCountry.Location = new Point(109, 139);
            TxtInputCustomerCountry.Name = "TxtInputCustomerCountry";
            TxtInputCustomerCountry.Size = new Size(133, 16);
            TxtInputCustomerCountry.TabIndex = 2;
            // 
            // TxtInputCustomerWebsite
            // 
            TxtInputCustomerWebsite.BackColor = SystemColors.Window;
            TxtInputCustomerWebsite.BorderStyle = BorderStyle.None;
            TxtInputCustomerWebsite.Cursor = Cursors.IBeam;
            TxtInputCustomerWebsite.Location = new Point(330, 107);
            TxtInputCustomerWebsite.Name = "TxtInputCustomerWebsite";
            TxtInputCustomerWebsite.Size = new Size(177, 16);
            TxtInputCustomerWebsite.TabIndex = 2;
            // 
            // TxtInputCustomerEmail
            // 
            TxtInputCustomerEmail.BackColor = SystemColors.Window;
            TxtInputCustomerEmail.BorderStyle = BorderStyle.None;
            TxtInputCustomerEmail.Cursor = Cursors.IBeam;
            TxtInputCustomerEmail.Location = new Point(330, 87);
            TxtInputCustomerEmail.Name = "TxtInputCustomerEmail";
            TxtInputCustomerEmail.Size = new Size(177, 16);
            TxtInputCustomerEmail.TabIndex = 2;
            // 
            // TxtInputCustomerLastName
            // 
            TxtInputCustomerLastName.BackColor = SystemColors.Window;
            TxtInputCustomerLastName.BorderStyle = BorderStyle.None;
            TxtInputCustomerLastName.Cursor = Cursors.IBeam;
            TxtInputCustomerLastName.Location = new Point(109, 106);
            TxtInputCustomerLastName.Name = "TxtInputCustomerLastName";
            TxtInputCustomerLastName.Size = new Size(133, 16);
            TxtInputCustomerLastName.TabIndex = 2;
            // 
            // TxtInputCustomerFirstName
            // 
            TxtInputCustomerFirstName.BackColor = SystemColors.Window;
            TxtInputCustomerFirstName.BorderStyle = BorderStyle.None;
            TxtInputCustomerFirstName.Cursor = Cursors.IBeam;
            TxtInputCustomerFirstName.Location = new Point(109, 86);
            TxtInputCustomerFirstName.Name = "TxtInputCustomerFirstName";
            TxtInputCustomerFirstName.Size = new Size(133, 16);
            TxtInputCustomerFirstName.TabIndex = 2;
            // 
            // TxtInputCustomerPassword
            // 
            TxtInputCustomerPassword.BackColor = SystemColors.Window;
            TxtInputCustomerPassword.BorderStyle = BorderStyle.None;
            TxtInputCustomerPassword.Cursor = Cursors.IBeam;
            TxtInputCustomerPassword.Location = new Point(139, 49);
            TxtInputCustomerPassword.Name = "TxtInputCustomerPassword";
            TxtInputCustomerPassword.Size = new Size(133, 16);
            TxtInputCustomerPassword.TabIndex = 2;
            // 
            // LblInfoCustomerCountry
            // 
            LblInfoCustomerCountry.AutoSize = true;
            LblInfoCustomerCountry.Location = new Point(21, 140);
            LblInfoCustomerCountry.Name = "LblInfoCustomerCountry";
            LblInfoCustomerCountry.Size = new Size(50, 15);
            LblInfoCustomerCountry.TabIndex = 1;
            LblInfoCustomerCountry.Text = "Country";
            // 
            // LblInfoCustomerLastName
            // 
            LblInfoCustomerLastName.AutoSize = true;
            LblInfoCustomerLastName.Location = new Point(21, 107);
            LblInfoCustomerLastName.Name = "LblInfoCustomerLastName";
            LblInfoCustomerLastName.Size = new Size(63, 15);
            LblInfoCustomerLastName.TabIndex = 1;
            LblInfoCustomerLastName.Text = "Last Name";
            // 
            // LblInfoCustomerFirstName
            // 
            LblInfoCustomerFirstName.AutoSize = true;
            LblInfoCustomerFirstName.Location = new Point(21, 87);
            LblInfoCustomerFirstName.Name = "LblInfoCustomerFirstName";
            LblInfoCustomerFirstName.Size = new Size(64, 15);
            LblInfoCustomerFirstName.TabIndex = 1;
            LblInfoCustomerFirstName.Text = "First Name";
            // 
            // LblInfoCustomerPassword
            // 
            LblInfoCustomerPassword.AutoSize = true;
            LblInfoCustomerPassword.Location = new Point(21, 50);
            LblInfoCustomerPassword.Name = "LblInfoCustomerPassword";
            LblInfoCustomerPassword.Size = new Size(57, 15);
            LblInfoCustomerPassword.TabIndex = 1;
            LblInfoCustomerPassword.Text = "Password";
            // 
            // LblInfoCustomerNumber
            // 
            LblInfoCustomerNumber.AutoSize = true;
            LblInfoCustomerNumber.Location = new Point(21, 30);
            LblInfoCustomerNumber.Name = "LblInfoCustomerNumber";
            LblInfoCustomerNumber.Size = new Size(106, 15);
            LblInfoCustomerNumber.TabIndex = 1;
            LblInfoCustomerNumber.Text = "Customer Number";
            // 
            // CmdDeleteCustomer
            // 
            CmdDeleteCustomer.Location = new Point(412, 216);
            CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            CmdDeleteCustomer.Size = new Size(110, 23);
            CmdDeleteCustomer.TabIndex = 0;
            CmdDeleteCustomer.Text = "Delete Customer";
            CmdDeleteCustomer.UseVisualStyleBackColor = true;
            CmdDeleteCustomer.Click += CmdDeleteCustomer_Click;
            // 
            // CmdSaveChangesCustomer
            // 
            CmdSaveChangesCustomer.Location = new Point(307, 216);
            CmdSaveChangesCustomer.Name = "CmdSaveChangesCustomer";
            CmdSaveChangesCustomer.Size = new Size(99, 23);
            CmdSaveChangesCustomer.TabIndex = 0;
            CmdSaveChangesCustomer.Text = "Save";
            CmdSaveChangesCustomer.UseVisualStyleBackColor = true;
            CmdSaveChangesCustomer.Click += CmdSaveChangesCustomer_Click;
            // 
            // CmdClearCustomer
            // 
            CmdClearCustomer.Location = new Point(6, 216);
            CmdClearCustomer.Name = "CmdClearCustomer";
            CmdClearCustomer.Size = new Size(148, 23);
            CmdClearCustomer.TabIndex = 0;
            CmdClearCustomer.Text = "Clear / New";
            CmdClearCustomer.UseVisualStyleBackColor = true;
            CmdClearCustomer.Click += CmdClearCustomer_Click;
            // 
            // GrpSearch
            // 
            GrpSearch.Controls.Add(TxtSearchCustomerWebsite);
            GrpSearch.Controls.Add(label1);
            GrpSearch.Controls.Add(TxtSearchCustomerLastName);
            GrpSearch.Controls.Add(TxtSearchCustomerFirstName);
            GrpSearch.Controls.Add(TxtSearchCustomerAdress);
            GrpSearch.Controls.Add(TxtSearchCustomerCity);
            GrpSearch.Controls.Add(TxtSearchCustomerEmail);
            GrpSearch.Controls.Add(TxtSearchCustomerCountry);
            GrpSearch.Controls.Add(TxtSearchCustomerNumber);
            GrpSearch.Controls.Add(CmdResetSearchFilters);
            GrpSearch.Controls.Add(CmdSearchCustomers);
            GrpSearch.Controls.Add(LblInfoSearchCustomerLastName);
            GrpSearch.Controls.Add(LblInfoSearchCustomerFirstName);
            GrpSearch.Controls.Add(LblInfoSearchCustomerAdress);
            GrpSearch.Controls.Add(LblInfoSearchCustomerCity);
            GrpSearch.Controls.Add(LblInfoSearchCustomerEmail);
            GrpSearch.Controls.Add(LblInfoSearchCustomerCountry);
            GrpSearch.Controls.Add(LblInfoSearchCustomerNumber);
            GrpSearch.ForeColor = SystemColors.ControlText;
            GrpSearch.Location = new Point(3, 0);
            GrpSearch.Margin = new Padding(4, 5, 4, 5);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Padding = new Padding(4, 5, 4, 5);
            GrpSearch.Size = new Size(528, 245);
            GrpSearch.TabIndex = 2;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // TxtSearchCustomerWebsite
            // 
            TxtSearchCustomerWebsite.Location = new Point(192, 164);
            TxtSearchCustomerWebsite.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerWebsite.Name = "TxtSearchCustomerWebsite";
            TxtSearchCustomerWebsite.Size = new Size(145, 23);
            TxtSearchCustomerWebsite.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 146);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Website";
            // 
            // TxtSearchCustomerLastName
            // 
            TxtSearchCustomerLastName.Location = new Point(357, 50);
            TxtSearchCustomerLastName.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerLastName.Name = "TxtSearchCustomerLastName";
            TxtSearchCustomerLastName.Size = new Size(145, 23);
            TxtSearchCustomerLastName.TabIndex = 2;
            // 
            // TxtSearchCustomerFirstName
            // 
            TxtSearchCustomerFirstName.Location = new Point(192, 50);
            TxtSearchCustomerFirstName.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerFirstName.Name = "TxtSearchCustomerFirstName";
            TxtSearchCustomerFirstName.Size = new Size(145, 23);
            TxtSearchCustomerFirstName.TabIndex = 2;
            // 
            // TxtSearchCustomerAdress
            // 
            TxtSearchCustomerAdress.Location = new Point(357, 107);
            TxtSearchCustomerAdress.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerAdress.Name = "TxtSearchCustomerAdress";
            TxtSearchCustomerAdress.Size = new Size(145, 23);
            TxtSearchCustomerAdress.TabIndex = 2;
            // 
            // TxtSearchCustomerCity
            // 
            TxtSearchCustomerCity.Location = new Point(192, 107);
            TxtSearchCustomerCity.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerCity.Name = "TxtSearchCustomerCity";
            TxtSearchCustomerCity.Size = new Size(145, 23);
            TxtSearchCustomerCity.TabIndex = 2;
            // 
            // TxtSearchCustomerEmail
            // 
            TxtSearchCustomerEmail.Location = new Point(26, 164);
            TxtSearchCustomerEmail.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerEmail.Name = "TxtSearchCustomerEmail";
            TxtSearchCustomerEmail.Size = new Size(145, 23);
            TxtSearchCustomerEmail.TabIndex = 2;
            // 
            // TxtSearchCustomerCountry
            // 
            TxtSearchCustomerCountry.Location = new Point(26, 107);
            TxtSearchCustomerCountry.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerCountry.Name = "TxtSearchCustomerCountry";
            TxtSearchCustomerCountry.Size = new Size(145, 23);
            TxtSearchCustomerCountry.TabIndex = 2;
            // 
            // TxtSearchCustomerNumber
            // 
            TxtSearchCustomerNumber.Location = new Point(26, 50);
            TxtSearchCustomerNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerNumber.Name = "TxtSearchCustomerNumber";
            TxtSearchCustomerNumber.Size = new Size(145, 23);
            TxtSearchCustomerNumber.TabIndex = 2;
            // 
            // CmdResetSearchFilters
            // 
            CmdResetSearchFilters.Location = new Point(273, 216);
            CmdResetSearchFilters.Margin = new Padding(4, 5, 4, 5);
            CmdResetSearchFilters.Name = "CmdResetSearchFilters";
            CmdResetSearchFilters.Size = new Size(117, 23);
            CmdResetSearchFilters.TabIndex = 0;
            CmdResetSearchFilters.Text = "Reset search filters";
            CmdResetSearchFilters.UseVisualStyleBackColor = true;
            CmdResetSearchFilters.Click += CmdResetSearchFilters_Click;
            // 
            // CmdSearchCustomers
            // 
            CmdSearchCustomers.Location = new Point(396, 216);
            CmdSearchCustomers.Margin = new Padding(4, 5, 4, 5);
            CmdSearchCustomers.Name = "CmdSearchCustomers";
            CmdSearchCustomers.Size = new Size(126, 23);
            CmdSearchCustomers.TabIndex = 0;
            CmdSearchCustomers.Text = "Search Customers";
            CmdSearchCustomers.UseVisualStyleBackColor = true;
            CmdSearchCustomers.Click += CmdSearchCustomers_Click;
            // 
            // LblInfoSearchCustomerLastName
            // 
            LblInfoSearchCustomerLastName.AutoSize = true;
            LblInfoSearchCustomerLastName.Location = new Point(357, 30);
            LblInfoSearchCustomerLastName.Margin = new Padding(4, 0, 4, 0);
            LblInfoSearchCustomerLastName.Name = "LblInfoSearchCustomerLastName";
            LblInfoSearchCustomerLastName.Size = new Size(63, 15);
            LblInfoSearchCustomerLastName.TabIndex = 1;
            LblInfoSearchCustomerLastName.Text = "Last Name";
            // 
            // LblInfoSearchCustomerFirstName
            // 
            LblInfoSearchCustomerFirstName.AutoSize = true;
            LblInfoSearchCustomerFirstName.Location = new Point(192, 30);
            LblInfoSearchCustomerFirstName.Margin = new Padding(4, 0, 4, 0);
            LblInfoSearchCustomerFirstName.Name = "LblInfoSearchCustomerFirstName";
            LblInfoSearchCustomerFirstName.Size = new Size(64, 15);
            LblInfoSearchCustomerFirstName.TabIndex = 1;
            LblInfoSearchCustomerFirstName.Text = "First Name";
            // 
            // LblInfoSearchCustomerAdress
            // 
            LblInfoSearchCustomerAdress.AutoSize = true;
            LblInfoSearchCustomerAdress.Location = new Point(357, 89);
            LblInfoSearchCustomerAdress.Margin = new Padding(4, 0, 4, 0);
            LblInfoSearchCustomerAdress.Name = "LblInfoSearchCustomerAdress";
            LblInfoSearchCustomerAdress.Size = new Size(75, 15);
            LblInfoSearchCustomerAdress.TabIndex = 1;
            LblInfoSearchCustomerAdress.Text = "Street Adress";
            // 
            // LblInfoSearchCustomerCity
            // 
            LblInfoSearchCustomerCity.AutoSize = true;
            LblInfoSearchCustomerCity.Location = new Point(192, 89);
            LblInfoSearchCustomerCity.Margin = new Padding(4, 0, 4, 0);
            LblInfoSearchCustomerCity.Name = "LblInfoSearchCustomerCity";
            LblInfoSearchCustomerCity.Size = new Size(28, 15);
            LblInfoSearchCustomerCity.TabIndex = 1;
            LblInfoSearchCustomerCity.Text = "City";
            // 
            // LblInfoSearchCustomerEmail
            // 
            LblInfoSearchCustomerEmail.AutoSize = true;
            LblInfoSearchCustomerEmail.Location = new Point(26, 146);
            LblInfoSearchCustomerEmail.Margin = new Padding(4, 0, 4, 0);
            LblInfoSearchCustomerEmail.Name = "LblInfoSearchCustomerEmail";
            LblInfoSearchCustomerEmail.Size = new Size(36, 15);
            LblInfoSearchCustomerEmail.TabIndex = 1;
            LblInfoSearchCustomerEmail.Text = "Email";
            // 
            // LblInfoSearchCustomerCountry
            // 
            LblInfoSearchCustomerCountry.AutoSize = true;
            LblInfoSearchCustomerCountry.Location = new Point(26, 89);
            LblInfoSearchCustomerCountry.Margin = new Padding(4, 0, 4, 0);
            LblInfoSearchCustomerCountry.Name = "LblInfoSearchCustomerCountry";
            LblInfoSearchCustomerCountry.Size = new Size(50, 15);
            LblInfoSearchCustomerCountry.TabIndex = 1;
            LblInfoSearchCustomerCountry.Text = "Country";
            // 
            // LblInfoSearchCustomerNumber
            // 
            LblInfoSearchCustomerNumber.AutoSize = true;
            LblInfoSearchCustomerNumber.Location = new Point(26, 30);
            LblInfoSearchCustomerNumber.Margin = new Padding(4, 0, 4, 0);
            LblInfoSearchCustomerNumber.Name = "LblInfoSearchCustomerNumber";
            LblInfoSearchCustomerNumber.Size = new Size(106, 15);
            LblInfoSearchCustomerNumber.TabIndex = 1;
            LblInfoSearchCustomerNumber.Text = "Customer Number";
            // 
            // CmdExportCustomers_Click
            // 
            CmdExportCustomers_Click.Location = new Point(369, 356);
            CmdExportCustomers_Click.Name = "CmdExportCustomers_Click";
            CmdExportCustomers_Click.Size = new Size(124, 23);
            CmdExportCustomers_Click.TabIndex = 3;
            CmdExportCustomers_Click.Text = "Export Customers";
            CmdExportCustomers_Click.UseVisualStyleBackColor = true;
            CmdExportCustomers_Click.Click += CmdExportCustomers_Click_Click;
            // 
            // UsrCtrlCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GrpInformation);
            Controls.Add(GrpSearch);
            Controls.Add(GrpResults);
            Name = "UsrCtrlCustomers";
            Size = new Size(1085, 640);
            GrpResults.ResumeLayout(false);
            GrpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomersResults).EndInit();
            GrpInformation.ResumeLayout(false);
            GrpInformation.PerformLayout();
            GrpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerOrders).EndInit();
            GrpSearch.ResumeLayout(false);
            GrpSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GrpResults;
        private GroupBox GrpInformation;
        private GroupBox GrpSearch;
        private Button CmdClearCustomer;
        private Button CmdDeleteCustomer;
        private Button CmdSaveChangesCustomer;
        private DataGridView DataGridViewCustomersResults;
        private Button CmdResetSearchFilters;
        private Button CmdSearchCustomers;
        private Label LblInfoCustomerNumber;
        private Label LblInfoCustomerPassword;
        private Label LblInfoCustomerLastName;
        private Label LblInfoCustomerFirstName;
        private Label LblInfoCustomerPostalCode;
        private Label LblInfoCustomerAdress;
        private Label LblInfoCustomerCountry;
        private Label LblInfoCustomerCity;
        private Label LblInfoCustomerEmail;
        private Label LblInfoCustomerWebsite;
        private GroupBox GrpOrders;
        private DataGridView DataGridViewCustomerOrders;
        private Button CmdCopyOrderNumber;
        private Label LblInfoSearchCustomerNumber;
        private Label LblInfoSearchCustomerLastName;
        private Label LblInfoSearchCustomerFirstName;
        private Label LblInfoSearchCustomerAdress;
        private Label LblInfoSearchCustomerCity;
        private Label LblInfoSearchCustomerEmail;
        private Label LblInfoSearchCustomerCountry;
        private TextBox TxtSearchCustomerLastName;
        private TextBox TxtSearchCustomerFirstName;
        private TextBox TxtSearchCustomerAdress;
        private TextBox TxtSearchCustomerCity;
        private TextBox TxtSearchCustomerEmail;
        private TextBox TxtSearchCustomerCountry;
        private TextBox TxtSearchCustomerNumber;
        private TextBox TxtInputCustomerPassword;
        private TextBox TxtInputCustomerNumber;
        private TextBox TxtInputCustomerAdress;
        private TextBox TxtInputCustomerPostalCode;
        private TextBox TxtInputCustomerCity;
        private TextBox TxtInputCustomerCountry;
        private TextBox TxtInputCustomerWebsite;
        private TextBox TxtInputCustomerEmail;
        private TextBox TxtInputCustomerLastName;
        private TextBox TxtInputCustomerFirstName;
        private Label LblDataGridCustomersNoResults;
        private TextBox TxtSearchCustomerWebsite;
        private Label label1;
        private Button CmdExportCustomers_Click;
    }
}
