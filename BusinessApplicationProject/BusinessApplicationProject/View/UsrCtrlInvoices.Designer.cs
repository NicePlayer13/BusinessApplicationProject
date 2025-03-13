namespace BusinessApplicationProject.View
{
    partial class UsrCtrlInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            LblNoResults = new Label();
            label12 = new Label();
            DataGridViewBillingAddress = new DataGridView();
            DataGridViewInvoices = new DataGridView();
            CmdCopyCustomerNumber = new Button();
            CmdCopyOrderNumber = new Button();
            DataGridViewCustomerInformations = new DataGridView();
            DataGridViewOrderDetails = new DataGridView();
            CmdCopyArticleNumber = new Button();
            DataGridViewOrderPositions = new DataGridView();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label8 = new Label();
            label10 = new Label();
            TxtStreetAddress = new TextBox();
            label6 = new Label();
            label9 = new Label();
            DatPckInvoiceDateTo = new DateTimePicker();
            TxtSearchCountry = new TextBox();
            DatPckInvoiceDateFrom = new DateTimePicker();
            TxtSearchZipCode = new TextBox();
            TxtSearchLastName = new TextBox();
            label11 = new Label();
            label7 = new Label();
            TxtSearchFirstName = new TextBox();
            label5 = new Label();
            TxtSearchOrderNumber = new TextBox();
            label3 = new Label();
            CmdResetFilters = new Button();
            TxtSearchCustomerNumber = new TextBox();
            label2 = new Label();
            TxtSearchInvoiceNumber = new TextBox();
            label1 = new Label();
            CmdSearchInvoices = new Button();
            groupBox3 = new GroupBox();
            CmdEditDelete = new Button();
            TxtEditCity = new TextBox();
            label13 = new Label();
            label24 = new Label();
            CmbEditPaymentStatus = new ComboBox();
            label20 = new Label();
            CmbEditPaymentMethod = new ComboBox();
            NumEditTaxes = new NumericUpDown();
            NumEditDiscount = new NumericUpDown();
            label16 = new Label();
            label19 = new Label();
            label14 = new Label();
            ChkEditUseCustomerAddress = new CheckBox();
            label15 = new Label();
            TxtEditStreetAddress = new TextBox();
            label17 = new Label();
            TxtEditCountry = new TextBox();
            TxtEditZipCode = new TextBox();
            label18 = new Label();
            TxtEditOrderNumber = new TextBox();
            label21 = new Label();
            CmdEditClear = new Button();
            TxtEditInvoiceNumber = new TextBox();
            label23 = new Label();
            CmdEditSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBillingAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerInformations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumEditTaxes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumEditDiscount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(DataGridViewBillingAddress);
            groupBox1.Controls.Add(CmdCopyCustomerNumber);
            groupBox1.Controls.Add(CmdCopyOrderNumber);
            groupBox1.Controls.Add(DataGridViewCustomerInformations);
            groupBox1.Controls.Add(DataGridViewOrderDetails);
            groupBox1.Controls.Add(DataGridViewOrderPositions);
            groupBox1.Controls.Add(LblNoResults);
            groupBox1.Controls.Add(DataGridViewInvoices);
            groupBox1.Controls.Add(CmdCopyArticleNumber);
            groupBox1.Location = new Point(3, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1079, 316);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results";
            // 
            // LblNoResults
            // 
            LblNoResults.AutoSize = true;
            LblNoResults.Location = new Point(282, 162);
            LblNoResults.Name = "LblNoResults";
            LblNoResults.Size = new Size(154, 15);
            LblNoResults.TabIndex = 4;
            LblNoResults.Text = "No items meet filter criteria.";
            LblNoResults.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(728, 17);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 47;
            label12.Text = "Billing Address";
            // 
            // DataGridViewBillingAddress
            // 
            DataGridViewBillingAddress.AllowUserToDeleteRows = false;
            DataGridViewBillingAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewBillingAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBillingAddress.Location = new Point(728, 37);
            DataGridViewBillingAddress.Margin = new Padding(4, 5, 4, 5);
            DataGridViewBillingAddress.MultiSelect = false;
            DataGridViewBillingAddress.Name = "DataGridViewBillingAddress";
            DataGridViewBillingAddress.ReadOnly = true;
            DataGridViewBillingAddress.RowHeadersWidth = 62;
            DataGridViewBillingAddress.Size = new Size(329, 32);
            DataGridViewBillingAddress.TabIndex = 46;
            // 
            // DataGridViewInvoices
            // 
            DataGridViewInvoices.AllowUserToDeleteRows = false;
            DataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewInvoices.Location = new Point(7, 24);
            DataGridViewInvoices.Margin = new Padding(4, 5, 4, 5);
            DataGridViewInvoices.MultiSelect = false;
            DataGridViewInvoices.Name = "DataGridViewInvoices";
            DataGridViewInvoices.ReadOnly = true;
            DataGridViewInvoices.RowHeadersWidth = 62;
            DataGridViewInvoices.Size = new Size(697, 287);
            DataGridViewInvoices.TabIndex = 2;
            DataGridViewInvoices.SelectionChanged += DataGridViewInvoices_SelectionChanged;
            // 
            // CmdCopyCustomerNumber
            // 
            CmdCopyCustomerNumber.Location = new Point(727, 109);
            CmdCopyCustomerNumber.Name = "CmdCopyCustomerNumber";
            CmdCopyCustomerNumber.Size = new Size(205, 32);
            CmdCopyCustomerNumber.TabIndex = 6;
            CmdCopyCustomerNumber.Text = "Copy Customer Number";
            CmdCopyCustomerNumber.UseVisualStyleBackColor = true;
            CmdCopyCustomerNumber.Click += CmdCopyCustomerNumber_Click;
            // 
            // CmdCopyOrderNumber
            // 
            CmdCopyOrderNumber.Location = new Point(727, 180);
            CmdCopyOrderNumber.Name = "CmdCopyOrderNumber";
            CmdCopyOrderNumber.Size = new Size(205, 34);
            CmdCopyOrderNumber.TabIndex = 5;
            CmdCopyOrderNumber.Text = "Copy Order Number";
            CmdCopyOrderNumber.UseVisualStyleBackColor = true;
            CmdCopyOrderNumber.Click += CmdCopyOrderNumber_Click;
            // 
            // DataGridViewCustomerInformations
            // 
            DataGridViewCustomerInformations.AllowUserToDeleteRows = false;
            DataGridViewCustomerInformations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCustomerInformations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomerInformations.Location = new Point(728, 74);
            DataGridViewCustomerInformations.Margin = new Padding(4, 5, 4, 5);
            DataGridViewCustomerInformations.MultiSelect = false;
            DataGridViewCustomerInformations.Name = "DataGridViewCustomerInformations";
            DataGridViewCustomerInformations.ReadOnly = true;
            DataGridViewCustomerInformations.RowHeadersWidth = 62;
            DataGridViewCustomerInformations.Size = new Size(329, 32);
            DataGridViewCustomerInformations.TabIndex = 10;
            // 
            // DataGridViewOrderDetails
            // 
            DataGridViewOrderDetails.AllowUserToDeleteRows = false;
            DataGridViewOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrderDetails.Location = new Point(728, 217);
            DataGridViewOrderDetails.Margin = new Padding(4, 5, 4, 5);
            DataGridViewOrderDetails.MultiSelect = false;
            DataGridViewOrderDetails.Name = "DataGridViewOrderDetails";
            DataGridViewOrderDetails.ReadOnly = true;
            DataGridViewOrderDetails.RowHeadersWidth = 62;
            DataGridViewOrderDetails.Size = new Size(329, 59);
            DataGridViewOrderDetails.TabIndex = 7;
            // 
            // CmdCopyArticleNumber
            // 
            CmdCopyArticleNumber.Location = new Point(727, 278);
            CmdCopyArticleNumber.Name = "CmdCopyArticleNumber";
            CmdCopyArticleNumber.Size = new Size(205, 34);
            CmdCopyArticleNumber.TabIndex = 9;
            CmdCopyArticleNumber.Text = "Copy Article Number";
            CmdCopyArticleNumber.UseVisualStyleBackColor = true;
            CmdCopyArticleNumber.Click += CmdCopyArticleNumber_Click;
            // 
            // DataGridViewOrderPositions
            // 
            DataGridViewOrderPositions.AllowUserToDeleteRows = false;
            DataGridViewOrderPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewOrderPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrderPositions.Location = new Point(728, 145);
            DataGridViewOrderPositions.Margin = new Padding(4, 5, 4, 5);
            DataGridViewOrderPositions.MultiSelect = false;
            DataGridViewOrderPositions.Name = "DataGridViewOrderPositions";
            DataGridViewOrderPositions.ReadOnly = true;
            DataGridViewOrderPositions.RowHeadersWidth = 62;
            DataGridViewOrderPositions.Size = new Size(329, 32);
            DataGridViewOrderPositions.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(TxtStreetAddress);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(DatPckInvoiceDateTo);
            groupBox2.Controls.Add(TxtSearchCountry);
            groupBox2.Controls.Add(DatPckInvoiceDateFrom);
            groupBox2.Controls.Add(TxtSearchZipCode);
            groupBox2.Controls.Add(TxtSearchLastName);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TxtSearchFirstName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtSearchOrderNumber);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(CmdResetFilters);
            groupBox2.Controls.Add(TxtSearchCustomerNumber);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxtSearchInvoiceNumber);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(CmdSearchInvoices);
            groupBox2.Location = new Point(3, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(494, 318);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Invoices";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 94);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 45;
            label4.Text = "Invoice Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 197);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 44;
            label8.Text = "To";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 94);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 26;
            label10.Text = "Street Address";
            // 
            // TxtStreetAddress
            // 
            TxtStreetAddress.Location = new Point(7, 125);
            TxtStreetAddress.Margin = new Padding(4, 5, 4, 5);
            TxtStreetAddress.Name = "TxtStreetAddress";
            TxtStreetAddress.Size = new Size(145, 23);
            TxtStreetAddress.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 131);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 43;
            label6.Text = "From";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 161);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 28;
            label9.Text = "Zip Code";
            // 
            // DatPckInvoiceDateTo
            // 
            DatPckInvoiceDateTo.Format = DateTimePickerFormat.Short;
            DatPckInvoiceDateTo.Location = new Point(355, 192);
            DatPckInvoiceDateTo.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            DatPckInvoiceDateTo.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            DatPckInvoiceDateTo.Name = "DatPckInvoiceDateTo";
            DatPckInvoiceDateTo.Size = new Size(126, 23);
            DatPckInvoiceDateTo.TabIndex = 42;
            DatPckInvoiceDateTo.Value = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            // 
            // TxtSearchCountry
            // 
            TxtSearchCountry.Location = new Point(7, 259);
            TxtSearchCountry.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCountry.Name = "TxtSearchCountry";
            TxtSearchCountry.Size = new Size(145, 23);
            TxtSearchCountry.TabIndex = 31;
            // 
            // DatPckInvoiceDateFrom
            // 
            DatPckInvoiceDateFrom.Format = DateTimePickerFormat.Short;
            DatPckInvoiceDateFrom.Location = new Point(355, 125);
            DatPckInvoiceDateFrom.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            DatPckInvoiceDateFrom.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            DatPckInvoiceDateFrom.Name = "DatPckInvoiceDateFrom";
            DatPckInvoiceDateFrom.Size = new Size(127, 23);
            DatPckInvoiceDateFrom.TabIndex = 41;
            DatPckInvoiceDateFrom.Value = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // TxtSearchZipCode
            // 
            TxtSearchZipCode.Location = new Point(7, 192);
            TxtSearchZipCode.Margin = new Padding(4, 5, 4, 5);
            TxtSearchZipCode.Name = "TxtSearchZipCode";
            TxtSearchZipCode.Size = new Size(145, 23);
            TxtSearchZipCode.TabIndex = 29;
            // 
            // TxtSearchLastName
            // 
            TxtSearchLastName.Location = new Point(160, 192);
            TxtSearchLastName.Margin = new Padding(4, 5, 4, 5);
            TxtSearchLastName.Name = "TxtSearchLastName";
            TxtSearchLastName.Size = new Size(145, 23);
            TxtSearchLastName.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 228);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 30;
            label11.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 161);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 24;
            label7.Text = "Last Name";
            // 
            // TxtSearchFirstName
            // 
            TxtSearchFirstName.Location = new Point(160, 125);
            TxtSearchFirstName.Margin = new Padding(4, 5, 4, 5);
            TxtSearchFirstName.Name = "TxtSearchFirstName";
            TxtSearchFirstName.Size = new Size(145, 23);
            TxtSearchFirstName.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 94);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 22;
            label5.Text = "First Name";
            // 
            // TxtSearchOrderNumber
            // 
            TxtSearchOrderNumber.Location = new Point(313, 58);
            TxtSearchOrderNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchOrderNumber.Name = "TxtSearchOrderNumber";
            TxtSearchOrderNumber.Size = new Size(145, 23);
            TxtSearchOrderNumber.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 8;
            label3.Text = "Order Number";
            // 
            // CmdResetFilters
            // 
            CmdResetFilters.Location = new Point(188, 278);
            CmdResetFilters.Name = "CmdResetFilters";
            CmdResetFilters.Size = new Size(97, 34);
            CmdResetFilters.TabIndex = 7;
            CmdResetFilters.Text = "Clear";
            CmdResetFilters.UseVisualStyleBackColor = true;
            CmdResetFilters.Click += CmdResetFilters_Click;
            // 
            // TxtSearchCustomerNumber
            // 
            TxtSearchCustomerNumber.Location = new Point(160, 58);
            TxtSearchCustomerNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerNumber.Name = "TxtSearchCustomerNumber";
            TxtSearchCustomerNumber.Size = new Size(145, 23);
            TxtSearchCustomerNumber.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Customer Number";
            // 
            // TxtSearchInvoiceNumber
            // 
            TxtSearchInvoiceNumber.Location = new Point(7, 58);
            TxtSearchInvoiceNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchInvoiceNumber.Name = "TxtSearchInvoiceNumber";
            TxtSearchInvoiceNumber.Size = new Size(145, 23);
            TxtSearchInvoiceNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Invoice Number";
            // 
            // CmdSearchInvoices
            // 
            CmdSearchInvoices.Location = new Point(291, 278);
            CmdSearchInvoices.Name = "CmdSearchInvoices";
            CmdSearchInvoices.Size = new Size(197, 34);
            CmdSearchInvoices.TabIndex = 0;
            CmdSearchInvoices.Text = "Search Invoices";
            CmdSearchInvoices.UseVisualStyleBackColor = true;
            CmdSearchInvoices.Click += CmdSearchInvoices_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CmdEditDelete);
            groupBox3.Controls.Add(TxtEditCity);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(CmbEditPaymentStatus);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(CmbEditPaymentMethod);
            groupBox3.Controls.Add(NumEditTaxes);
            groupBox3.Controls.Add(NumEditDiscount);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(ChkEditUseCustomerAddress);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(TxtEditStreetAddress);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(TxtEditCountry);
            groupBox3.Controls.Add(TxtEditZipCode);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(TxtEditOrderNumber);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(CmdEditClear);
            groupBox3.Controls.Add(TxtEditInvoiceNumber);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(CmdEditSave);
            groupBox3.Location = new Point(512, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(570, 318);
            groupBox3.TabIndex = 48;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit / Create Invoice";
            // 
            // CmdEditDelete
            // 
            CmdEditDelete.Location = new Point(274, 278);
            CmdEditDelete.Name = "CmdEditDelete";
            CmdEditDelete.Size = new Size(76, 34);
            CmdEditDelete.TabIndex = 61;
            CmdEditDelete.Text = "Delete";
            CmdEditDelete.UseVisualStyleBackColor = true;
            CmdEditDelete.Click += CmdEditDelete_Click;
            // 
            // TxtEditCity
            // 
            TxtEditCity.Location = new Point(185, 220);
            TxtEditCity.Margin = new Padding(4, 5, 4, 5);
            TxtEditCity.Name = "TxtEditCity";
            TxtEditCity.Size = new Size(145, 23);
            TxtEditCity.TabIndex = 60;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(183, 200);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 59;
            label13.Text = "City";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(363, 141);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(89, 15);
            label24.TabIndex = 58;
            label24.Text = "Payment Status";
            // 
            // CmbEditPaymentStatus
            // 
            CmbEditPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEditPaymentStatus.FormattingEnabled = true;
            CmbEditPaymentStatus.Location = new Point(360, 161);
            CmbEditPaymentStatus.Name = "CmbEditPaymentStatus";
            CmbEditPaymentStatus.Size = new Size(145, 23);
            CmbEditPaymentStatus.TabIndex = 57;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(362, 85);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(99, 15);
            label20.TabIndex = 56;
            label20.Text = "Payment Method";
            // 
            // CmbEditPaymentMethod
            // 
            CmbEditPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEditPaymentMethod.FormattingEnabled = true;
            CmbEditPaymentMethod.Location = new Point(360, 100);
            CmbEditPaymentMethod.Name = "CmbEditPaymentMethod";
            CmbEditPaymentMethod.Size = new Size(143, 23);
            CmbEditPaymentMethod.TabIndex = 55;
            // 
            // NumEditTaxes
            // 
            NumEditTaxes.DecimalPlaces = 2;
            NumEditTaxes.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            NumEditTaxes.Location = new Point(186, 162);
            NumEditTaxes.Name = "NumEditTaxes";
            NumEditTaxes.Size = new Size(144, 23);
            NumEditTaxes.TabIndex = 54;
            NumEditTaxes.Value = new decimal(new int[] { 81, 0, 0, 65536 });
            // 
            // NumEditDiscount
            // 
            NumEditDiscount.DecimalPlaces = 2;
            NumEditDiscount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumEditDiscount.Location = new Point(185, 101);
            NumEditDiscount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NumEditDiscount.Name = "NumEditDiscount";
            NumEditDiscount.Size = new Size(144, 23);
            NumEditDiscount.TabIndex = 53;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(185, 83);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 51;
            label16.Text = "Discount";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(187, 139);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(56, 15);
            label19.TabIndex = 52;
            label19.Text = "Taxes [%]";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 83);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(85, 15);
            label14.TabIndex = 48;
            label14.Text = "Billing Address";
            // 
            // ChkEditUseCustomerAddress
            // 
            ChkEditUseCustomerAddress.AutoSize = true;
            ChkEditUseCustomerAddress.Location = new Point(9, 102);
            ChkEditUseCustomerAddress.Name = "ChkEditUseCustomerAddress";
            ChkEditUseCustomerAddress.Size = new Size(131, 19);
            ChkEditUseCustomerAddress.TabIndex = 46;
            ChkEditUseCustomerAddress.Text = "Billing to cust. addr.";
            ChkEditUseCustomerAddress.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 142);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 26;
            label15.Text = "Street Address";
            // 
            // TxtEditStreetAddress
            // 
            TxtEditStreetAddress.Location = new Point(11, 162);
            TxtEditStreetAddress.Margin = new Padding(4, 5, 4, 5);
            TxtEditStreetAddress.Name = "TxtEditStreetAddress";
            TxtEditStreetAddress.Size = new Size(145, 23);
            TxtEditStreetAddress.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 200);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(55, 15);
            label17.TabIndex = 28;
            label17.Text = "Zip Code";
            // 
            // TxtEditCountry
            // 
            TxtEditCountry.Location = new Point(11, 274);
            TxtEditCountry.Margin = new Padding(4, 5, 4, 5);
            TxtEditCountry.Name = "TxtEditCountry";
            TxtEditCountry.Size = new Size(145, 23);
            TxtEditCountry.TabIndex = 31;
            // 
            // TxtEditZipCode
            // 
            TxtEditZipCode.Location = new Point(11, 220);
            TxtEditZipCode.Margin = new Padding(4, 5, 4, 5);
            TxtEditZipCode.Name = "TxtEditZipCode";
            TxtEditZipCode.Size = new Size(145, 23);
            TxtEditZipCode.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 254);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(50, 15);
            label18.TabIndex = 30;
            label18.Text = "Country";
            // 
            // TxtEditOrderNumber
            // 
            TxtEditOrderNumber.Location = new Point(185, 47);
            TxtEditOrderNumber.Margin = new Padding(4, 5, 4, 5);
            TxtEditOrderNumber.Name = "TxtEditOrderNumber";
            TxtEditOrderNumber.Size = new Size(145, 23);
            TxtEditOrderNumber.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(185, 28);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(84, 15);
            label21.TabIndex = 8;
            label21.Text = "Order Number";
            // 
            // CmdEditClear
            // 
            CmdEditClear.Location = new Point(356, 278);
            CmdEditClear.Name = "CmdEditClear";
            CmdEditClear.Size = new Size(103, 34);
            CmdEditClear.TabIndex = 7;
            CmdEditClear.Text = "Clear / New";
            CmdEditClear.UseVisualStyleBackColor = true;
            CmdEditClear.Click += CmdEditClear_Click;
            // 
            // TxtEditInvoiceNumber
            // 
            TxtEditInvoiceNumber.Enabled = false;
            TxtEditInvoiceNumber.Location = new Point(11, 47);
            TxtEditInvoiceNumber.Margin = new Padding(4, 5, 4, 5);
            TxtEditInvoiceNumber.Name = "TxtEditInvoiceNumber";
            TxtEditInvoiceNumber.Size = new Size(145, 23);
            TxtEditInvoiceNumber.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(7, 27);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(92, 15);
            label23.TabIndex = 3;
            label23.Text = "Invoice Number";
            // 
            // CmdEditSave
            // 
            CmdEditSave.Location = new Point(465, 278);
            CmdEditSave.Name = "CmdEditSave";
            CmdEditSave.Size = new Size(83, 34);
            CmdEditSave.TabIndex = 0;
            CmdEditSave.Text = "Save";
            CmdEditSave.UseVisualStyleBackColor = true;
            CmdEditSave.Click += CmdEditSave_Click;
            // 
            // UsrCtrlInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "UsrCtrlInvoices";
            Size = new Size(1085, 640);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBillingAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerInformations).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumEditTaxes).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumEditDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DataGridViewInvoices;
        private GroupBox groupBox2;
        private Label LblNoResults;
        private Button CmdSearchInvoices;
        private TextBox TxtSearchInvoiceNumber;
        private Label label1;
        private TextBox TxtSearchCustomerNumber;
        private Label label2;
        private TextBox TxtSearchOrderNumber;
        private Label label3;
        private Button CmdResetFilters;
        private Button CmdCopyCustomerNumber;
        private Button CmdCopyOrderNumber;
        private TextBox TxtSearchFirstName;
        private Label label5;
        private TextBox TxtSearchLastName;
        private Label label7;
        private TextBox TxtSearchCountry;
        private Label label11;
        private TextBox TxtSearchZipCode;
        private Label label9;
        private TextBox TxtStreetAddress;
        private Label label10;
        private Label label4;
        private Label label8;
        private Label label6;
        private DateTimePicker DatPckInvoiceDateTo;
        private DateTimePicker DatPckInvoiceDateFrom;
        private DataGridView DataGridViewOrderDetails;
        private DataGridView DataGridViewOrderPositions;
        private Button CmdCopyArticleNumber;
        private DataGridView DataGridViewCustomerInformations;
        private Label label12;
        private DataGridView DataGridViewBillingAddress;
        private GroupBox groupBox3;
        private Label label15;
        private TextBox TxtEditStreetAddress;
        private Label label17;
        private TextBox TxtEditCountry;
        private TextBox TxtEditZipCode;
        private Label label18;
        private TextBox TxtEditOrderNumber;
        private Label label21;
        private Button CmdEditClear;
        private TextBox textBox7;
        private Label label22;
        private TextBox TxtEditInvoiceNumber;
        private Label label23;
        private Button CmdEditSave;
        private CheckBox ChkEditUseCustomerAddress;
        private Label label14;
        private Label label16;
        private Label label19;
        private NumericUpDown NumEditTaxes;
        private NumericUpDown NumEditDiscount;
        private Label label20;
        private ComboBox CmbEditPaymentMethod;
        private Label label24;
        private ComboBox CmbEditPaymentStatus;
        private TextBox TxtEditCity;
        private Label label13;
        private Button CmdEditDelete;
    }
}
