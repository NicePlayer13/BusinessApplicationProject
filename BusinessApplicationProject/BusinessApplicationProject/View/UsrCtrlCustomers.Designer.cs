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
            CmdExportCustomers_Click = new Button();
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
            CmdImportCustomers_Click = new Button();
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
            GrpResults.Location = new Point(3, 335);
            GrpResults.Margin = new Padding(3, 4, 3, 4);
            GrpResults.Name = "GrpResults";
            GrpResults.Padding = new Padding(3, 4, 3, 4);
            GrpResults.Size = new Size(603, 513);
            GrpResults.TabIndex = 2;
            GrpResults.TabStop = false;
            GrpResults.Text = "Customers";
            // 
            // LblDataGridCustomersNoResults
            // 
            LblDataGridCustomersNoResults.AutoSize = true;
            LblDataGridCustomersNoResults.Location = new Point(266, 241);
            LblDataGridCustomersNoResults.Name = "LblDataGridCustomersNoResults";
            LblDataGridCustomersNoResults.Size = new Size(79, 20);
            LblDataGridCustomersNoResults.TabIndex = 1;
            LblDataGridCustomersNoResults.Text = "No Results";
            // 
            // DataGridViewCustomersResults
            // 
            DataGridViewCustomersResults.AllowUserToDeleteRows = false;
            DataGridViewCustomersResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomersResults.Location = new Point(7, 29);
            DataGridViewCustomersResults.Margin = new Padding(3, 4, 3, 4);
            DataGridViewCustomersResults.MultiSelect = false;
            DataGridViewCustomersResults.Name = "DataGridViewCustomersResults";
            DataGridViewCustomersResults.ReadOnly = true;
            DataGridViewCustomersResults.RowHeadersWidth = 62;
            DataGridViewCustomersResults.Size = new Size(590, 437);
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
            GrpInformation.Location = new Point(634, 0);
            GrpInformation.Margin = new Padding(3, 4, 3, 4);
            GrpInformation.Name = "GrpInformation";
            GrpInformation.Padding = new Padding(3, 4, 3, 4);
            GrpInformation.Size = new Size(603, 848);
            GrpInformation.TabIndex = 2;
            GrpInformation.TabStop = false;
            GrpInformation.Text = "Information selected item";
            // 
            // LblInfoCustomerPostalCode
            // 
            LblInfoCustomerPostalCode.AutoSize = true;
            LblInfoCustomerPostalCode.Location = new Point(24, 213);
            LblInfoCustomerPostalCode.Name = "LblInfoCustomerPostalCode";
            LblInfoCustomerPostalCode.Size = new Size(87, 20);
            LblInfoCustomerPostalCode.TabIndex = 1;
            LblInfoCustomerPostalCode.Text = "Postal Code";
            // 
            // LblInfoCustomerCity
            // 
            LblInfoCustomerCity.AutoSize = true;
            LblInfoCustomerCity.Location = new Point(235, 213);
            LblInfoCustomerCity.Name = "LblInfoCustomerCity";
            LblInfoCustomerCity.Size = new Size(34, 20);
            LblInfoCustomerCity.TabIndex = 1;
            LblInfoCustomerCity.Text = "City";
            // 
            // GrpOrders
            // 
            GrpOrders.Controls.Add(CmdImportCustomers_Click);
            GrpOrders.Controls.Add(CmdExportCustomers_Click);
            GrpOrders.Controls.Add(DataGridViewCustomerOrders);
            GrpOrders.Controls.Add(CmdCopyOrderNumber);
            GrpOrders.ForeColor = SystemColors.ControlText;
            GrpOrders.Location = new Point(0, 335);
            GrpOrders.Margin = new Padding(3, 4, 3, 4);
            GrpOrders.Name = "GrpOrders";
            GrpOrders.Padding = new Padding(3, 4, 3, 4);
            GrpOrders.Size = new Size(603, 513);
            GrpOrders.TabIndex = 2;
            GrpOrders.TabStop = false;
            GrpOrders.Text = "Orders";
            // 
            // CmdExportCustomers_Click
            // 
            CmdExportCustomers_Click.Location = new Point(455, 474);
            CmdExportCustomers_Click.Margin = new Padding(3, 4, 3, 4);
            CmdExportCustomers_Click.Name = "CmdExportCustomers_Click";
            CmdExportCustomers_Click.Size = new Size(142, 31);
            CmdExportCustomers_Click.TabIndex = 3;
            CmdExportCustomers_Click.Text = "Export Customers";
            CmdExportCustomers_Click.UseVisualStyleBackColor = true;
            CmdExportCustomers_Click.Click += CmdExportCustomers_Click_Click;
            // 
            // DataGridViewCustomerOrders
            // 
            DataGridViewCustomerOrders.AllowUserToAddRows = false;
            DataGridViewCustomerOrders.AllowUserToDeleteRows = false;
            DataGridViewCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomerOrders.Location = new Point(7, 29);
            DataGridViewCustomerOrders.Margin = new Padding(3, 4, 3, 4);
            DataGridViewCustomerOrders.MultiSelect = false;
            DataGridViewCustomerOrders.Name = "DataGridViewCustomerOrders";
            DataGridViewCustomerOrders.ReadOnly = true;
            DataGridViewCustomerOrders.RowHeadersWidth = 62;
            DataGridViewCustomerOrders.Size = new Size(590, 437);
            DataGridViewCustomerOrders.TabIndex = 1;
            // 
            // CmdCopyOrderNumber
            // 
            CmdCopyOrderNumber.Location = new Point(7, 475);
            CmdCopyOrderNumber.Margin = new Padding(3, 4, 3, 4);
            CmdCopyOrderNumber.Name = "CmdCopyOrderNumber";
            CmdCopyOrderNumber.Size = new Size(151, 31);
            CmdCopyOrderNumber.TabIndex = 0;
            CmdCopyOrderNumber.Text = "Copy order number";
            CmdCopyOrderNumber.UseVisualStyleBackColor = true;
            CmdCopyOrderNumber.Click += CmdOpenSelectedOrder_Click;
            // 
            // LblInfoCustomerWebsite
            // 
            LblInfoCustomerWebsite.AutoSize = true;
            LblInfoCustomerWebsite.Location = new Point(293, 143);
            LblInfoCustomerWebsite.Name = "LblInfoCustomerWebsite";
            LblInfoCustomerWebsite.Size = new Size(62, 20);
            LblInfoCustomerWebsite.TabIndex = 1;
            LblInfoCustomerWebsite.Text = "Website";
            // 
            // LblInfoCustomerEmail
            // 
            LblInfoCustomerEmail.AutoSize = true;
            LblInfoCustomerEmail.Location = new Point(293, 116);
            LblInfoCustomerEmail.Name = "LblInfoCustomerEmail";
            LblInfoCustomerEmail.Size = new Size(46, 20);
            LblInfoCustomerEmail.TabIndex = 1;
            LblInfoCustomerEmail.Text = "Email";
            // 
            // LblInfoCustomerAdress
            // 
            LblInfoCustomerAdress.AutoSize = true;
            LblInfoCustomerAdress.Location = new Point(24, 240);
            LblInfoCustomerAdress.Name = "LblInfoCustomerAdress";
            LblInfoCustomerAdress.Size = new Size(96, 20);
            LblInfoCustomerAdress.TabIndex = 1;
            LblInfoCustomerAdress.Text = "Street Adress";
            // 
            // TxtInputCustomerNumber
            // 
            TxtInputCustomerNumber.BackColor = SystemColors.ScrollBar;
            TxtInputCustomerNumber.BorderStyle = BorderStyle.None;
            TxtInputCustomerNumber.Cursor = Cursors.IBeam;
            TxtInputCustomerNumber.Enabled = false;
            TxtInputCustomerNumber.Location = new Point(159, 40);
            TxtInputCustomerNumber.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerNumber.Name = "TxtInputCustomerNumber";
            TxtInputCustomerNumber.ReadOnly = true;
            TxtInputCustomerNumber.Size = new Size(152, 20);
            TxtInputCustomerNumber.TabIndex = 2;
            TxtInputCustomerNumber.TextChanged += TxtInputCustomerNumber_TextChanged;
            // 
            // TxtInputCustomerAdress
            // 
            TxtInputCustomerAdress.BackColor = SystemColors.Window;
            TxtInputCustomerAdress.BorderStyle = BorderStyle.None;
            TxtInputCustomerAdress.Cursor = Cursors.IBeam;
            TxtInputCustomerAdress.Location = new Point(125, 240);
            TxtInputCustomerAdress.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerAdress.Name = "TxtInputCustomerAdress";
            TxtInputCustomerAdress.Size = new Size(152, 20);
            TxtInputCustomerAdress.TabIndex = 2;
            // 
            // TxtInputCustomerPostalCode
            // 
            TxtInputCustomerPostalCode.BackColor = SystemColors.Window;
            TxtInputCustomerPostalCode.BorderStyle = BorderStyle.None;
            TxtInputCustomerPostalCode.Cursor = Cursors.IBeam;
            TxtInputCustomerPostalCode.Location = new Point(125, 212);
            TxtInputCustomerPostalCode.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerPostalCode.Name = "TxtInputCustomerPostalCode";
            TxtInputCustomerPostalCode.Size = new Size(89, 20);
            TxtInputCustomerPostalCode.TabIndex = 2;
            // 
            // TxtInputCustomerCity
            // 
            TxtInputCustomerCity.BackColor = SystemColors.Window;
            TxtInputCustomerCity.BorderStyle = BorderStyle.None;
            TxtInputCustomerCity.Cursor = Cursors.IBeam;
            TxtInputCustomerCity.Location = new Point(293, 213);
            TxtInputCustomerCity.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerCity.Name = "TxtInputCustomerCity";
            TxtInputCustomerCity.Size = new Size(152, 20);
            TxtInputCustomerCity.TabIndex = 2;
            // 
            // TxtInputCustomerCountry
            // 
            TxtInputCustomerCountry.BackColor = SystemColors.Window;
            TxtInputCustomerCountry.BorderStyle = BorderStyle.None;
            TxtInputCustomerCountry.Cursor = Cursors.IBeam;
            TxtInputCustomerCountry.Location = new Point(125, 185);
            TxtInputCustomerCountry.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerCountry.Name = "TxtInputCustomerCountry";
            TxtInputCustomerCountry.Size = new Size(152, 20);
            TxtInputCustomerCountry.TabIndex = 2;
            // 
            // TxtInputCustomerWebsite
            // 
            TxtInputCustomerWebsite.BackColor = SystemColors.Window;
            TxtInputCustomerWebsite.BorderStyle = BorderStyle.None;
            TxtInputCustomerWebsite.Cursor = Cursors.IBeam;
            TxtInputCustomerWebsite.Location = new Point(377, 143);
            TxtInputCustomerWebsite.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerWebsite.Name = "TxtInputCustomerWebsite";
            TxtInputCustomerWebsite.Size = new Size(202, 20);
            TxtInputCustomerWebsite.TabIndex = 2;
            // 
            // TxtInputCustomerEmail
            // 
            TxtInputCustomerEmail.BackColor = SystemColors.Window;
            TxtInputCustomerEmail.BorderStyle = BorderStyle.None;
            TxtInputCustomerEmail.Cursor = Cursors.IBeam;
            TxtInputCustomerEmail.Location = new Point(377, 116);
            TxtInputCustomerEmail.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerEmail.Name = "TxtInputCustomerEmail";
            TxtInputCustomerEmail.Size = new Size(202, 20);
            TxtInputCustomerEmail.TabIndex = 2;
            // 
            // TxtInputCustomerLastName
            // 
            TxtInputCustomerLastName.BackColor = SystemColors.Window;
            TxtInputCustomerLastName.BorderStyle = BorderStyle.None;
            TxtInputCustomerLastName.Cursor = Cursors.IBeam;
            TxtInputCustomerLastName.Location = new Point(125, 141);
            TxtInputCustomerLastName.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerLastName.Name = "TxtInputCustomerLastName";
            TxtInputCustomerLastName.Size = new Size(152, 20);
            TxtInputCustomerLastName.TabIndex = 2;
            // 
            // TxtInputCustomerFirstName
            // 
            TxtInputCustomerFirstName.BackColor = SystemColors.Window;
            TxtInputCustomerFirstName.BorderStyle = BorderStyle.None;
            TxtInputCustomerFirstName.Cursor = Cursors.IBeam;
            TxtInputCustomerFirstName.Location = new Point(125, 115);
            TxtInputCustomerFirstName.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerFirstName.Name = "TxtInputCustomerFirstName";
            TxtInputCustomerFirstName.Size = new Size(152, 20);
            TxtInputCustomerFirstName.TabIndex = 2;
            // 
            // TxtInputCustomerPassword
            // 
            TxtInputCustomerPassword.BackColor = SystemColors.Window;
            TxtInputCustomerPassword.BorderStyle = BorderStyle.None;
            TxtInputCustomerPassword.Cursor = Cursors.IBeam;
            TxtInputCustomerPassword.Location = new Point(159, 65);
            TxtInputCustomerPassword.Margin = new Padding(3, 4, 3, 4);
            TxtInputCustomerPassword.Name = "TxtInputCustomerPassword";
            TxtInputCustomerPassword.Size = new Size(152, 20);
            TxtInputCustomerPassword.TabIndex = 2;
            // 
            // LblInfoCustomerCountry
            // 
            LblInfoCustomerCountry.AutoSize = true;
            LblInfoCustomerCountry.Location = new Point(24, 187);
            LblInfoCustomerCountry.Name = "LblInfoCustomerCountry";
            LblInfoCustomerCountry.Size = new Size(60, 20);
            LblInfoCustomerCountry.TabIndex = 1;
            LblInfoCustomerCountry.Text = "Country";
            // 
            // LblInfoCustomerLastName
            // 
            LblInfoCustomerLastName.AutoSize = true;
            LblInfoCustomerLastName.Location = new Point(24, 143);
            LblInfoCustomerLastName.Name = "LblInfoCustomerLastName";
            LblInfoCustomerLastName.Size = new Size(79, 20);
            LblInfoCustomerLastName.TabIndex = 1;
            LblInfoCustomerLastName.Text = "Last Name";
            // 
            // LblInfoCustomerFirstName
            // 
            LblInfoCustomerFirstName.AutoSize = true;
            LblInfoCustomerFirstName.Location = new Point(24, 116);
            LblInfoCustomerFirstName.Name = "LblInfoCustomerFirstName";
            LblInfoCustomerFirstName.Size = new Size(80, 20);
            LblInfoCustomerFirstName.TabIndex = 1;
            LblInfoCustomerFirstName.Text = "First Name";
            // 
            // LblInfoCustomerPassword
            // 
            LblInfoCustomerPassword.AutoSize = true;
            LblInfoCustomerPassword.Location = new Point(24, 67);
            LblInfoCustomerPassword.Name = "LblInfoCustomerPassword";
            LblInfoCustomerPassword.Size = new Size(70, 20);
            LblInfoCustomerPassword.TabIndex = 1;
            LblInfoCustomerPassword.Text = "Password";
            // 
            // LblInfoCustomerNumber
            // 
            LblInfoCustomerNumber.AutoSize = true;
            LblInfoCustomerNumber.Location = new Point(24, 40);
            LblInfoCustomerNumber.Name = "LblInfoCustomerNumber";
            LblInfoCustomerNumber.Size = new Size(130, 20);
            LblInfoCustomerNumber.TabIndex = 1;
            LblInfoCustomerNumber.Text = "Customer Number";
            // 
            // CmdDeleteCustomer
            // 
            CmdDeleteCustomer.Location = new Point(471, 288);
            CmdDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            CmdDeleteCustomer.Size = new Size(126, 31);
            CmdDeleteCustomer.TabIndex = 0;
            CmdDeleteCustomer.Text = "Delete Customer";
            CmdDeleteCustomer.UseVisualStyleBackColor = true;
            CmdDeleteCustomer.Click += CmdDeleteCustomer_Click;
            // 
            // CmdSaveChangesCustomer
            // 
            CmdSaveChangesCustomer.Location = new Point(351, 288);
            CmdSaveChangesCustomer.Margin = new Padding(3, 4, 3, 4);
            CmdSaveChangesCustomer.Name = "CmdSaveChangesCustomer";
            CmdSaveChangesCustomer.Size = new Size(113, 31);
            CmdSaveChangesCustomer.TabIndex = 0;
            CmdSaveChangesCustomer.Text = "Save";
            CmdSaveChangesCustomer.UseVisualStyleBackColor = true;
            CmdSaveChangesCustomer.Click += CmdSaveChangesCustomer_Click;
            // 
            // CmdClearCustomer
            // 
            CmdClearCustomer.Location = new Point(7, 288);
            CmdClearCustomer.Margin = new Padding(3, 4, 3, 4);
            CmdClearCustomer.Name = "CmdClearCustomer";
            CmdClearCustomer.Size = new Size(169, 31);
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
            GrpSearch.Margin = new Padding(5, 7, 5, 7);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Padding = new Padding(5, 7, 5, 7);
            GrpSearch.Size = new Size(603, 327);
            GrpSearch.TabIndex = 2;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // TxtSearchCustomerWebsite
            // 
            TxtSearchCustomerWebsite.Location = new Point(219, 219);
            TxtSearchCustomerWebsite.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerWebsite.Name = "TxtSearchCustomerWebsite";
            TxtSearchCustomerWebsite.Size = new Size(165, 27);
            TxtSearchCustomerWebsite.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 195);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Website";
            // 
            // TxtSearchCustomerLastName
            // 
            TxtSearchCustomerLastName.Location = new Point(408, 67);
            TxtSearchCustomerLastName.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerLastName.Name = "TxtSearchCustomerLastName";
            TxtSearchCustomerLastName.Size = new Size(165, 27);
            TxtSearchCustomerLastName.TabIndex = 2;
            // 
            // TxtSearchCustomerFirstName
            // 
            TxtSearchCustomerFirstName.Location = new Point(219, 67);
            TxtSearchCustomerFirstName.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerFirstName.Name = "TxtSearchCustomerFirstName";
            TxtSearchCustomerFirstName.Size = new Size(165, 27);
            TxtSearchCustomerFirstName.TabIndex = 2;
            // 
            // TxtSearchCustomerAdress
            // 
            TxtSearchCustomerAdress.Location = new Point(408, 143);
            TxtSearchCustomerAdress.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerAdress.Name = "TxtSearchCustomerAdress";
            TxtSearchCustomerAdress.Size = new Size(165, 27);
            TxtSearchCustomerAdress.TabIndex = 2;
            // 
            // TxtSearchCustomerCity
            // 
            TxtSearchCustomerCity.Location = new Point(219, 143);
            TxtSearchCustomerCity.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerCity.Name = "TxtSearchCustomerCity";
            TxtSearchCustomerCity.Size = new Size(165, 27);
            TxtSearchCustomerCity.TabIndex = 2;
            // 
            // TxtSearchCustomerEmail
            // 
            TxtSearchCustomerEmail.Location = new Point(30, 219);
            TxtSearchCustomerEmail.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerEmail.Name = "TxtSearchCustomerEmail";
            TxtSearchCustomerEmail.Size = new Size(165, 27);
            TxtSearchCustomerEmail.TabIndex = 2;
            // 
            // TxtSearchCustomerCountry
            // 
            TxtSearchCustomerCountry.Location = new Point(30, 143);
            TxtSearchCustomerCountry.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerCountry.Name = "TxtSearchCustomerCountry";
            TxtSearchCustomerCountry.Size = new Size(165, 27);
            TxtSearchCustomerCountry.TabIndex = 2;
            // 
            // TxtSearchCustomerNumber
            // 
            TxtSearchCustomerNumber.Location = new Point(30, 67);
            TxtSearchCustomerNumber.Margin = new Padding(5, 7, 5, 7);
            TxtSearchCustomerNumber.Name = "TxtSearchCustomerNumber";
            TxtSearchCustomerNumber.Size = new Size(165, 27);
            TxtSearchCustomerNumber.TabIndex = 2;
            // 
            // CmdResetSearchFilters
            // 
            CmdResetSearchFilters.Location = new Point(312, 288);
            CmdResetSearchFilters.Margin = new Padding(5, 7, 5, 7);
            CmdResetSearchFilters.Name = "CmdResetSearchFilters";
            CmdResetSearchFilters.Size = new Size(134, 31);
            CmdResetSearchFilters.TabIndex = 0;
            CmdResetSearchFilters.Text = "Reset search filters";
            CmdResetSearchFilters.UseVisualStyleBackColor = true;
            CmdResetSearchFilters.Click += CmdResetSearchFilters_Click;
            // 
            // CmdSearchCustomers
            // 
            CmdSearchCustomers.Location = new Point(453, 288);
            CmdSearchCustomers.Margin = new Padding(5, 7, 5, 7);
            CmdSearchCustomers.Name = "CmdSearchCustomers";
            CmdSearchCustomers.Size = new Size(144, 31);
            CmdSearchCustomers.TabIndex = 0;
            CmdSearchCustomers.Text = "Search Customers";
            CmdSearchCustomers.UseVisualStyleBackColor = true;
            CmdSearchCustomers.Click += CmdSearchCustomers_Click;
            // 
            // LblInfoSearchCustomerLastName
            // 
            LblInfoSearchCustomerLastName.AutoSize = true;
            LblInfoSearchCustomerLastName.Location = new Point(408, 40);
            LblInfoSearchCustomerLastName.Margin = new Padding(5, 0, 5, 0);
            LblInfoSearchCustomerLastName.Name = "LblInfoSearchCustomerLastName";
            LblInfoSearchCustomerLastName.Size = new Size(79, 20);
            LblInfoSearchCustomerLastName.TabIndex = 1;
            LblInfoSearchCustomerLastName.Text = "Last Name";
            // 
            // LblInfoSearchCustomerFirstName
            // 
            LblInfoSearchCustomerFirstName.AutoSize = true;
            LblInfoSearchCustomerFirstName.Location = new Point(219, 40);
            LblInfoSearchCustomerFirstName.Margin = new Padding(5, 0, 5, 0);
            LblInfoSearchCustomerFirstName.Name = "LblInfoSearchCustomerFirstName";
            LblInfoSearchCustomerFirstName.Size = new Size(80, 20);
            LblInfoSearchCustomerFirstName.TabIndex = 1;
            LblInfoSearchCustomerFirstName.Text = "First Name";
            // 
            // LblInfoSearchCustomerAdress
            // 
            LblInfoSearchCustomerAdress.AutoSize = true;
            LblInfoSearchCustomerAdress.Location = new Point(408, 119);
            LblInfoSearchCustomerAdress.Margin = new Padding(5, 0, 5, 0);
            LblInfoSearchCustomerAdress.Name = "LblInfoSearchCustomerAdress";
            LblInfoSearchCustomerAdress.Size = new Size(96, 20);
            LblInfoSearchCustomerAdress.TabIndex = 1;
            LblInfoSearchCustomerAdress.Text = "Street Adress";
            // 
            // LblInfoSearchCustomerCity
            // 
            LblInfoSearchCustomerCity.AutoSize = true;
            LblInfoSearchCustomerCity.Location = new Point(219, 119);
            LblInfoSearchCustomerCity.Margin = new Padding(5, 0, 5, 0);
            LblInfoSearchCustomerCity.Name = "LblInfoSearchCustomerCity";
            LblInfoSearchCustomerCity.Size = new Size(34, 20);
            LblInfoSearchCustomerCity.TabIndex = 1;
            LblInfoSearchCustomerCity.Text = "City";
            // 
            // LblInfoSearchCustomerEmail
            // 
            LblInfoSearchCustomerEmail.AutoSize = true;
            LblInfoSearchCustomerEmail.Location = new Point(30, 195);
            LblInfoSearchCustomerEmail.Margin = new Padding(5, 0, 5, 0);
            LblInfoSearchCustomerEmail.Name = "LblInfoSearchCustomerEmail";
            LblInfoSearchCustomerEmail.Size = new Size(46, 20);
            LblInfoSearchCustomerEmail.TabIndex = 1;
            LblInfoSearchCustomerEmail.Text = "Email";
            // 
            // LblInfoSearchCustomerCountry
            // 
            LblInfoSearchCustomerCountry.AutoSize = true;
            LblInfoSearchCustomerCountry.Location = new Point(30, 119);
            LblInfoSearchCustomerCountry.Margin = new Padding(5, 0, 5, 0);
            LblInfoSearchCustomerCountry.Name = "LblInfoSearchCustomerCountry";
            LblInfoSearchCustomerCountry.Size = new Size(60, 20);
            LblInfoSearchCustomerCountry.TabIndex = 1;
            LblInfoSearchCustomerCountry.Text = "Country";
            // 
            // LblInfoSearchCustomerNumber
            // 
            LblInfoSearchCustomerNumber.AutoSize = true;
            LblInfoSearchCustomerNumber.Location = new Point(30, 40);
            LblInfoSearchCustomerNumber.Margin = new Padding(5, 0, 5, 0);
            LblInfoSearchCustomerNumber.Name = "LblInfoSearchCustomerNumber";
            LblInfoSearchCustomerNumber.Size = new Size(130, 20);
            LblInfoSearchCustomerNumber.TabIndex = 1;
            LblInfoSearchCustomerNumber.Text = "Customer Number";
            // 
            // CmdImportCustomers_Click
            // 
            CmdImportCustomers_Click.Location = new Point(307, 474);
            CmdImportCustomers_Click.Margin = new Padding(3, 4, 3, 4);
            CmdImportCustomers_Click.Name = "CmdImportCustomers_Click";
            CmdImportCustomers_Click.Size = new Size(142, 31);
            CmdImportCustomers_Click.TabIndex = 3;
            CmdImportCustomers_Click.Text = "Import Customers";
            CmdImportCustomers_Click.UseVisualStyleBackColor = true;
            CmdImportCustomers_Click.Click += CmdImportCustomers_Click_Click;
            // 
            // UsrCtrlCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GrpInformation);
            Controls.Add(GrpSearch);
            Controls.Add(GrpResults);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsrCtrlCustomers";
            Size = new Size(1240, 853);
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
        private Button CmdImportCustomers_Click;
    }
}
