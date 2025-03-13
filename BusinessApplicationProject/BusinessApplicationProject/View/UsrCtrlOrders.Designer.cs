namespace BusinessApplicationProject.View
{
    partial class UsrCtrlOrders
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
            CmdDeleteOrder = new Button();
            LblInfoOrderNumber = new Label();
            LblInfoCustomerFirstName = new Label();
            LblInfoOrderCustomerNumber = new Label();
            LblInfoCustomerLastName = new Label();
            TxtInputOrderCustomerFirstName = new TextBox();
            TxtInputOrderCustomerLastName = new TextBox();
            TxtInputOrderNumber = new TextBox();
            TxtInputCustomerNumber = new TextBox();
            GrpPositions = new GroupBox();
            GrpInformationSelectedPosition = new GroupBox();
            CmbInputArticle = new ComboBox();
            CmdDeletePosition = new Button();
            CmdSavePositionChanges = new Button();
            CmdSaveAsNewPosition = new Button();
            TxtInputOrderPositionArticleQuantity = new TextBox();
            LblInfoPositionArticleQuantity = new Label();
            LblInfoPositionArticle = new Label();
            TxtInputPositionNumber = new TextBox();
            LblInfoPositionNumber = new Label();
            DataGridViewOrderPositions = new DataGridView();
            positionNumber = new DataGridViewTextBoxColumn();
            article = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            CmdOpenSelectedPosition = new Button();
            CmdAddNewPosition = new Button();
            CmdDeleteSelectedPositions = new Button();
            GrpInformation = new GroupBox();
            CmdShowInvoice = new Button();
            TxtInputOrderDate = new TextBox();
            TxtInputInvoiceNumber = new TextBox();
            LblInfoOrderDate = new Label();
            LblInfoInvoiceNumber = new Label();
            LblInfoSearchOrdersCustomerNumber = new Label();
            LblInfoSearchOrdersCustomerFirstName = new Label();
            LblInfoSearchOrdersPriceFrom = new Label();
            LblInfoSearchOrdersCustomerLastName = new Label();
            LblInfoSearchOrdersPriceTo = new Label();
            CmdSearchOrders = new Button();
            CmdResetSearchFilters = new Button();
            TxtSearchCustomerNumber = new TextBox();
            TxtSearchOrderPriceFrom = new TextBox();
            TxtSearchOrderPriceTo = new TextBox();
            TxtSearchCustomerFirstName = new TextBox();
            TxtSearchCustomerLastName = new TextBox();
            LblInfoSearchOrdersDateFrom = new Label();
            LblInfoSearchOrdersDateUntil = new Label();
            LblInfoSearchOrdersPositionNumber = new Label();
            TxtSearchOrdersPositionNumber = new TextBox();
            DatSearchOrdersFrom = new DateTimePicker();
            DatSearchOrdersUntil = new DateTimePicker();
            GrpSearch = new GroupBox();
            CmdDeleteSelectedObject = new Button();
            CmdEditSelectedOrder = new Button();
            CmdShowAllOrders = new Button();
            DataGridViewOrdersResults = new DataGridView();
            GrpResults = new GroupBox();
            LblGridViewOrdersNoResults = new Label();
            GrpPositions.SuspendLayout();
            GrpInformationSelectedPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).BeginInit();
            GrpInformation.SuspendLayout();
            GrpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrdersResults).BeginInit();
            GrpResults.SuspendLayout();
            SuspendLayout();
            // 
            // CmdDeleteOrder
            // 
            CmdDeleteOrder.Location = new Point(412, 106);
            CmdDeleteOrder.Name = "CmdDeleteOrder";
            CmdDeleteOrder.Size = new Size(110, 23);
            CmdDeleteOrder.TabIndex = 0;
            CmdDeleteOrder.Text = "Delete Order";
            CmdDeleteOrder.UseVisualStyleBackColor = true;
            CmdDeleteOrder.Click += CmdDeleteOrder_Click;
            // 
            // LblInfoOrderNumber
            // 
            LblInfoOrderNumber.AutoSize = true;
            LblInfoOrderNumber.Location = new Point(21, 30);
            LblInfoOrderNumber.Name = "LblInfoOrderNumber";
            LblInfoOrderNumber.Size = new Size(84, 15);
            LblInfoOrderNumber.TabIndex = 1;
            LblInfoOrderNumber.Text = "Order Number";
            // 
            // LblInfoCustomerFirstName
            // 
            LblInfoCustomerFirstName.AutoSize = true;
            LblInfoCustomerFirstName.Location = new Point(264, 50);
            LblInfoCustomerFirstName.Name = "LblInfoCustomerFirstName";
            LblInfoCustomerFirstName.Size = new Size(64, 15);
            LblInfoCustomerFirstName.TabIndex = 1;
            LblInfoCustomerFirstName.Text = "First Name";
            // 
            // LblInfoOrderCustomerNumber
            // 
            LblInfoOrderCustomerNumber.AutoSize = true;
            LblInfoOrderCustomerNumber.Location = new Point(263, 31);
            LblInfoOrderCustomerNumber.Name = "LblInfoOrderCustomerNumber";
            LblInfoOrderCustomerNumber.Size = new Size(106, 15);
            LblInfoOrderCustomerNumber.TabIndex = 1;
            LblInfoOrderCustomerNumber.Text = "Customer Number";
            // 
            // LblInfoCustomerLastName
            // 
            LblInfoCustomerLastName.AutoSize = true;
            LblInfoCustomerLastName.Location = new Point(264, 69);
            LblInfoCustomerLastName.Name = "LblInfoCustomerLastName";
            LblInfoCustomerLastName.Size = new Size(63, 15);
            LblInfoCustomerLastName.TabIndex = 1;
            LblInfoCustomerLastName.Text = "Last Name";
            // 
            // TxtInputOrderCustomerFirstName
            // 
            TxtInputOrderCustomerFirstName.BackColor = SystemColors.ScrollBar;
            TxtInputOrderCustomerFirstName.BorderStyle = BorderStyle.None;
            TxtInputOrderCustomerFirstName.Cursor = Cursors.IBeam;
            TxtInputOrderCustomerFirstName.Location = new Point(382, 50);
            TxtInputOrderCustomerFirstName.Name = "TxtInputOrderCustomerFirstName";
            TxtInputOrderCustomerFirstName.ReadOnly = true;
            TxtInputOrderCustomerFirstName.Size = new Size(125, 16);
            TxtInputOrderCustomerFirstName.TabIndex = 2;
            // 
            // TxtInputOrderCustomerLastName
            // 
            TxtInputOrderCustomerLastName.BackColor = SystemColors.ScrollBar;
            TxtInputOrderCustomerLastName.BorderStyle = BorderStyle.None;
            TxtInputOrderCustomerLastName.Cursor = Cursors.IBeam;
            TxtInputOrderCustomerLastName.Location = new Point(382, 69);
            TxtInputOrderCustomerLastName.Name = "TxtInputOrderCustomerLastName";
            TxtInputOrderCustomerLastName.ReadOnly = true;
            TxtInputOrderCustomerLastName.Size = new Size(125, 16);
            TxtInputOrderCustomerLastName.TabIndex = 2;
            // 
            // TxtInputOrderNumber
            // 
            TxtInputOrderNumber.BackColor = SystemColors.ScrollBar;
            TxtInputOrderNumber.BorderStyle = BorderStyle.None;
            TxtInputOrderNumber.Cursor = Cursors.IBeam;
            TxtInputOrderNumber.Location = new Point(133, 31);
            TxtInputOrderNumber.Name = "TxtInputOrderNumber";
            TxtInputOrderNumber.ReadOnly = true;
            TxtInputOrderNumber.Size = new Size(125, 16);
            TxtInputOrderNumber.TabIndex = 2;
            // 
            // TxtInputCustomerNumber
            // 
            TxtInputCustomerNumber.BackColor = SystemColors.ScrollBar;
            TxtInputCustomerNumber.BorderStyle = BorderStyle.None;
            TxtInputCustomerNumber.Cursor = Cursors.IBeam;
            TxtInputCustomerNumber.Location = new Point(382, 31);
            TxtInputCustomerNumber.Name = "TxtInputCustomerNumber";
            TxtInputCustomerNumber.ReadOnly = true;
            TxtInputCustomerNumber.Size = new Size(125, 16);
            TxtInputCustomerNumber.TabIndex = 2;
            // 
            // GrpPositions
            // 
            GrpPositions.Controls.Add(GrpInformationSelectedPosition);
            GrpPositions.Controls.Add(DataGridViewOrderPositions);
            GrpPositions.Controls.Add(CmdOpenSelectedPosition);
            GrpPositions.Controls.Add(CmdAddNewPosition);
            GrpPositions.Controls.Add(CmdDeleteSelectedPositions);
            GrpPositions.ForeColor = SystemColors.ControlText;
            GrpPositions.Location = new Point(0, 144);
            GrpPositions.Name = "GrpPositions";
            GrpPositions.Size = new Size(528, 492);
            GrpPositions.TabIndex = 2;
            GrpPositions.TabStop = false;
            GrpPositions.Text = "Positions";
            // 
            // GrpInformationSelectedPosition
            // 
            GrpInformationSelectedPosition.Controls.Add(CmbInputArticle);
            GrpInformationSelectedPosition.Controls.Add(CmdDeletePosition);
            GrpInformationSelectedPosition.Controls.Add(CmdSavePositionChanges);
            GrpInformationSelectedPosition.Controls.Add(CmdSaveAsNewPosition);
            GrpInformationSelectedPosition.Controls.Add(TxtInputOrderPositionArticleQuantity);
            GrpInformationSelectedPosition.Controls.Add(LblInfoPositionArticleQuantity);
            GrpInformationSelectedPosition.Controls.Add(LblInfoPositionArticle);
            GrpInformationSelectedPosition.Controls.Add(TxtInputPositionNumber);
            GrpInformationSelectedPosition.Controls.Add(LblInfoPositionNumber);
            GrpInformationSelectedPosition.Location = new Point(0, 357);
            GrpInformationSelectedPosition.Name = "GrpInformationSelectedPosition";
            GrpInformationSelectedPosition.Size = new Size(528, 135);
            GrpInformationSelectedPosition.TabIndex = 4;
            GrpInformationSelectedPosition.TabStop = false;
            GrpInformationSelectedPosition.Text = "Information selected Position";
            GrpInformationSelectedPosition.Visible = false;
            // 
            // CmbInputArticle
            // 
            CmbInputArticle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbInputArticle.BackColor = SystemColors.Window;
            CmbInputArticle.FormattingEnabled = true;
            CmbInputArticle.ItemHeight = 15;
            CmbInputArticle.Items.AddRange(new object[] { "-", "Fahrzeuge", "Lebensmittel" });
            CmbInputArticle.Location = new Point(133, 60);
            CmbInputArticle.Name = "CmbInputArticle";
            CmbInputArticle.Size = new Size(145, 23);
            CmbInputArticle.Sorted = true;
            CmbInputArticle.TabIndex = 4;
            // 
            // CmdDeletePosition
            // 
            CmdDeletePosition.Location = new Point(412, 106);
            CmdDeletePosition.Name = "CmdDeletePosition";
            CmdDeletePosition.Size = new Size(110, 23);
            CmdDeletePosition.TabIndex = 0;
            CmdDeletePosition.Text = "Delete Position";
            CmdDeletePosition.UseVisualStyleBackColor = true;
            // 
            // CmdSavePositionChanges
            // 
            CmdSavePositionChanges.Location = new Point(307, 106);
            CmdSavePositionChanges.Name = "CmdSavePositionChanges";
            CmdSavePositionChanges.Size = new Size(99, 23);
            CmdSavePositionChanges.TabIndex = 0;
            CmdSavePositionChanges.Text = "Save changes";
            CmdSavePositionChanges.UseVisualStyleBackColor = true;
            CmdSavePositionChanges.Click += CmdSavePositionChanges_Click;
            // 
            // CmdSaveAsNewPosition
            // 
            CmdSaveAsNewPosition.Location = new Point(6, 106);
            CmdSaveAsNewPosition.Name = "CmdSaveAsNewPosition";
            CmdSaveAsNewPosition.Size = new Size(156, 23);
            CmdSaveAsNewPosition.TabIndex = 0;
            CmdSaveAsNewPosition.Text = "Save as new Position";
            CmdSaveAsNewPosition.UseVisualStyleBackColor = true;
            CmdSaveAsNewPosition.Click += CmdSaveAsNewPosition_Click;
            // 
            // TxtInputOrderPositionArticleQuantity
            // 
            TxtInputOrderPositionArticleQuantity.BackColor = SystemColors.Window;
            TxtInputOrderPositionArticleQuantity.BorderStyle = BorderStyle.None;
            TxtInputOrderPositionArticleQuantity.Cursor = Cursors.IBeam;
            TxtInputOrderPositionArticleQuantity.Location = new Point(382, 64);
            TxtInputOrderPositionArticleQuantity.Name = "TxtInputOrderPositionArticleQuantity";
            TxtInputOrderPositionArticleQuantity.Size = new Size(125, 16);
            TxtInputOrderPositionArticleQuantity.TabIndex = 2;
            // 
            // LblInfoPositionArticleQuantity
            // 
            LblInfoPositionArticleQuantity.AutoSize = true;
            LblInfoPositionArticleQuantity.Location = new Point(286, 63);
            LblInfoPositionArticleQuantity.Name = "LblInfoPositionArticleQuantity";
            LblInfoPositionArticleQuantity.Size = new Size(90, 15);
            LblInfoPositionArticleQuantity.TabIndex = 1;
            LblInfoPositionArticleQuantity.Text = "Article Quantity";
            // 
            // LblInfoPositionArticle
            // 
            LblInfoPositionArticle.AutoSize = true;
            LblInfoPositionArticle.Location = new Point(21, 63);
            LblInfoPositionArticle.Name = "LblInfoPositionArticle";
            LblInfoPositionArticle.Size = new Size(88, 15);
            LblInfoPositionArticle.TabIndex = 1;
            LblInfoPositionArticle.Text = "Selected Article";
            // 
            // TxtInputPositionNumber
            // 
            TxtInputPositionNumber.BackColor = SystemColors.ScrollBar;
            TxtInputPositionNumber.BorderStyle = BorderStyle.None;
            TxtInputPositionNumber.Cursor = Cursors.IBeam;
            TxtInputPositionNumber.Location = new Point(133, 38);
            TxtInputPositionNumber.Name = "TxtInputPositionNumber";
            TxtInputPositionNumber.ReadOnly = true;
            TxtInputPositionNumber.Size = new Size(133, 16);
            TxtInputPositionNumber.TabIndex = 2;
            // 
            // LblInfoPositionNumber
            // 
            LblInfoPositionNumber.AutoSize = true;
            LblInfoPositionNumber.Location = new Point(21, 38);
            LblInfoPositionNumber.Name = "LblInfoPositionNumber";
            LblInfoPositionNumber.Size = new Size(97, 15);
            LblInfoPositionNumber.TabIndex = 1;
            LblInfoPositionNumber.Text = "Position Number";
            // 
            // DataGridViewOrderPositions
            // 
            DataGridViewOrderPositions.AllowUserToAddRows = false;
            DataGridViewOrderPositions.AllowUserToDeleteRows = false;
            DataGridViewOrderPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrderPositions.Columns.AddRange(new DataGridViewColumn[] { positionNumber, article, quantity });
            DataGridViewOrderPositions.Location = new Point(6, 22);
            DataGridViewOrderPositions.Name = "DataGridViewOrderPositions";
            DataGridViewOrderPositions.ReadOnly = true;
            DataGridViewOrderPositions.Size = new Size(516, 291);
            DataGridViewOrderPositions.TabIndex = 1;
            // 
            // positionNumber
            // 
            positionNumber.HeaderText = "Position Number";
            positionNumber.Name = "positionNumber";
            positionNumber.ReadOnly = true;
            positionNumber.Width = 150;
            // 
            // article
            // 
            article.HeaderText = "Article";
            article.Name = "article";
            article.ReadOnly = true;
            article.Width = 150;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 150;
            // 
            // CmdOpenSelectedPosition
            // 
            CmdOpenSelectedPosition.Location = new Point(6, 319);
            CmdOpenSelectedPosition.Name = "CmdOpenSelectedPosition";
            CmdOpenSelectedPosition.Size = new Size(142, 23);
            CmdOpenSelectedPosition.TabIndex = 0;
            CmdOpenSelectedPosition.Text = "Open selected Position";
            CmdOpenSelectedPosition.UseVisualStyleBackColor = true;
            CmdOpenSelectedPosition.Click += CmdOpenSelectedPosition_Click;
            // 
            // CmdAddNewPosition
            // 
            CmdAddNewPosition.Location = new Point(233, 319);
            CmdAddNewPosition.Name = "CmdAddNewPosition";
            CmdAddNewPosition.Size = new Size(114, 23);
            CmdAddNewPosition.TabIndex = 0;
            CmdAddNewPosition.Text = "Add new Position";
            CmdAddNewPosition.UseVisualStyleBackColor = true;
            CmdAddNewPosition.Click += CmdAddNewPosition_Click;
            // 
            // CmdDeleteSelectedPositions
            // 
            CmdDeleteSelectedPositions.Location = new Point(353, 319);
            CmdDeleteSelectedPositions.Name = "CmdDeleteSelectedPositions";
            CmdDeleteSelectedPositions.Size = new Size(169, 23);
            CmdDeleteSelectedPositions.TabIndex = 0;
            CmdDeleteSelectedPositions.Text = "Delete selected Positions(s)";
            CmdDeleteSelectedPositions.UseVisualStyleBackColor = true;
            CmdDeleteSelectedPositions.Click += CmdDeleteSelectedPositions_Click;
            // 
            // GrpInformation
            // 
            GrpInformation.Controls.Add(GrpPositions);
            GrpInformation.Controls.Add(TxtInputCustomerNumber);
            GrpInformation.Controls.Add(CmdShowInvoice);
            GrpInformation.Controls.Add(TxtInputOrderDate);
            GrpInformation.Controls.Add(TxtInputInvoiceNumber);
            GrpInformation.Controls.Add(TxtInputOrderNumber);
            GrpInformation.Controls.Add(TxtInputOrderCustomerLastName);
            GrpInformation.Controls.Add(TxtInputOrderCustomerFirstName);
            GrpInformation.Controls.Add(LblInfoCustomerLastName);
            GrpInformation.Controls.Add(LblInfoOrderCustomerNumber);
            GrpInformation.Controls.Add(LblInfoOrderDate);
            GrpInformation.Controls.Add(LblInfoInvoiceNumber);
            GrpInformation.Controls.Add(LblInfoCustomerFirstName);
            GrpInformation.Controls.Add(LblInfoOrderNumber);
            GrpInformation.Controls.Add(CmdDeleteOrder);
            GrpInformation.Location = new Point(555, 0);
            GrpInformation.Name = "GrpInformation";
            GrpInformation.Size = new Size(528, 636);
            GrpInformation.TabIndex = 3;
            GrpInformation.TabStop = false;
            GrpInformation.Text = "Information selected Order";
            // 
            // CmdShowInvoice
            // 
            CmdShowInvoice.Location = new Point(6, 106);
            CmdShowInvoice.Name = "CmdShowInvoice";
            CmdShowInvoice.Size = new Size(179, 23);
            CmdShowInvoice.TabIndex = 0;
            CmdShowInvoice.Text = "Show corresponding Invoice";
            CmdShowInvoice.UseVisualStyleBackColor = true;
            CmdShowInvoice.Click += CmdShowInvoice_Click;
            // 
            // TxtInputOrderDate
            // 
            TxtInputOrderDate.BackColor = SystemColors.ScrollBar;
            TxtInputOrderDate.BorderStyle = BorderStyle.None;
            TxtInputOrderDate.Cursor = Cursors.IBeam;
            TxtInputOrderDate.Location = new Point(133, 50);
            TxtInputOrderDate.Name = "TxtInputOrderDate";
            TxtInputOrderDate.ReadOnly = true;
            TxtInputOrderDate.Size = new Size(125, 16);
            TxtInputOrderDate.TabIndex = 2;
            // 
            // TxtInputInvoiceNumber
            // 
            TxtInputInvoiceNumber.BackColor = SystemColors.ScrollBar;
            TxtInputInvoiceNumber.BorderStyle = BorderStyle.None;
            TxtInputInvoiceNumber.Cursor = Cursors.IBeam;
            TxtInputInvoiceNumber.Location = new Point(133, 69);
            TxtInputInvoiceNumber.Name = "TxtInputInvoiceNumber";
            TxtInputInvoiceNumber.ReadOnly = true;
            TxtInputInvoiceNumber.Size = new Size(125, 16);
            TxtInputInvoiceNumber.TabIndex = 2;
            // 
            // LblInfoOrderDate
            // 
            LblInfoOrderDate.AutoSize = true;
            LblInfoOrderDate.Location = new Point(21, 50);
            LblInfoOrderDate.Name = "LblInfoOrderDate";
            LblInfoOrderDate.Size = new Size(64, 15);
            LblInfoOrderDate.TabIndex = 1;
            LblInfoOrderDate.Text = "Order Date";
            // 
            // LblInfoInvoiceNumber
            // 
            LblInfoInvoiceNumber.AutoSize = true;
            LblInfoInvoiceNumber.Location = new Point(21, 68);
            LblInfoInvoiceNumber.Name = "LblInfoInvoiceNumber";
            LblInfoInvoiceNumber.Size = new Size(92, 15);
            LblInfoInvoiceNumber.TabIndex = 1;
            LblInfoInvoiceNumber.Text = "Invoice Number";
            // 
            // LblInfoSearchOrdersCustomerNumber
            // 
            LblInfoSearchOrdersCustomerNumber.AutoSize = true;
            LblInfoSearchOrdersCustomerNumber.Location = new Point(26, 30);
            LblInfoSearchOrdersCustomerNumber.Name = "LblInfoSearchOrdersCustomerNumber";
            LblInfoSearchOrdersCustomerNumber.Size = new Size(106, 15);
            LblInfoSearchOrdersCustomerNumber.TabIndex = 1;
            LblInfoSearchOrdersCustomerNumber.Text = "Customer Number";
            // 
            // LblInfoSearchOrdersCustomerFirstName
            // 
            LblInfoSearchOrdersCustomerFirstName.AutoSize = true;
            LblInfoSearchOrdersCustomerFirstName.Location = new Point(192, 30);
            LblInfoSearchOrdersCustomerFirstName.Name = "LblInfoSearchOrdersCustomerFirstName";
            LblInfoSearchOrdersCustomerFirstName.Size = new Size(64, 15);
            LblInfoSearchOrdersCustomerFirstName.TabIndex = 1;
            LblInfoSearchOrdersCustomerFirstName.Text = "First Name";
            // 
            // LblInfoSearchOrdersPriceFrom
            // 
            LblInfoSearchOrdersPriceFrom.AutoSize = true;
            LblInfoSearchOrdersPriceFrom.Location = new Point(26, 144);
            LblInfoSearchOrdersPriceFrom.Name = "LblInfoSearchOrdersPriceFrom";
            LblInfoSearchOrdersPriceFrom.Size = new Size(95, 15);
            LblInfoSearchOrdersPriceFrom.TabIndex = 1;
            LblInfoSearchOrdersPriceFrom.Text = "Order Price from";
            // 
            // LblInfoSearchOrdersCustomerLastName
            // 
            LblInfoSearchOrdersCustomerLastName.AutoSize = true;
            LblInfoSearchOrdersCustomerLastName.Location = new Point(357, 30);
            LblInfoSearchOrdersCustomerLastName.Name = "LblInfoSearchOrdersCustomerLastName";
            LblInfoSearchOrdersCustomerLastName.Size = new Size(63, 15);
            LblInfoSearchOrdersCustomerLastName.TabIndex = 1;
            LblInfoSearchOrdersCustomerLastName.Text = "Last Name";
            // 
            // LblInfoSearchOrdersPriceTo
            // 
            LblInfoSearchOrdersPriceTo.AutoSize = true;
            LblInfoSearchOrdersPriceTo.Location = new Point(192, 144);
            LblInfoSearchOrdersPriceTo.Name = "LblInfoSearchOrdersPriceTo";
            LblInfoSearchOrdersPriceTo.Size = new Size(97, 15);
            LblInfoSearchOrdersPriceTo.TabIndex = 1;
            LblInfoSearchOrdersPriceTo.Text = "Order Price up to";
            // 
            // CmdSearchOrders
            // 
            CmdSearchOrders.Location = new Point(396, 216);
            CmdSearchOrders.Name = "CmdSearchOrders";
            CmdSearchOrders.Size = new Size(126, 23);
            CmdSearchOrders.TabIndex = 0;
            CmdSearchOrders.Text = "Search Orders";
            CmdSearchOrders.UseVisualStyleBackColor = true;
            CmdSearchOrders.Click += CmdSearchCustomers_Click;
            // 
            // CmdResetSearchFilters
            // 
            CmdResetSearchFilters.Location = new Point(273, 216);
            CmdResetSearchFilters.Name = "CmdResetSearchFilters";
            CmdResetSearchFilters.Size = new Size(117, 23);
            CmdResetSearchFilters.TabIndex = 0;
            CmdResetSearchFilters.Text = "Reset search filters";
            CmdResetSearchFilters.UseVisualStyleBackColor = true;
            CmdResetSearchFilters.Click += CmdResetSearchFilters_Click;
            // 
            // TxtSearchCustomerNumber
            // 
            TxtSearchCustomerNumber.Location = new Point(26, 50);
            TxtSearchCustomerNumber.Name = "TxtSearchCustomerNumber";
            TxtSearchCustomerNumber.Size = new Size(145, 23);
            TxtSearchCustomerNumber.TabIndex = 2;
            // 
            // TxtSearchOrderPriceFrom
            // 
            TxtSearchOrderPriceFrom.Location = new Point(26, 164);
            TxtSearchOrderPriceFrom.Name = "TxtSearchOrderPriceFrom";
            TxtSearchOrderPriceFrom.Size = new Size(145, 23);
            TxtSearchOrderPriceFrom.TabIndex = 2;
            // 
            // TxtSearchOrderPriceTo
            // 
            TxtSearchOrderPriceTo.Location = new Point(192, 164);
            TxtSearchOrderPriceTo.Name = "TxtSearchOrderPriceTo";
            TxtSearchOrderPriceTo.Size = new Size(145, 23);
            TxtSearchOrderPriceTo.TabIndex = 2;
            // 
            // TxtSearchCustomerFirstName
            // 
            TxtSearchCustomerFirstName.BackColor = SystemColors.Window;
            TxtSearchCustomerFirstName.BorderStyle = BorderStyle.FixedSingle;
            TxtSearchCustomerFirstName.Location = new Point(192, 50);
            TxtSearchCustomerFirstName.Name = "TxtSearchCustomerFirstName";
            TxtSearchCustomerFirstName.Size = new Size(145, 23);
            TxtSearchCustomerFirstName.TabIndex = 2;
            // 
            // TxtSearchCustomerLastName
            // 
            TxtSearchCustomerLastName.BackColor = SystemColors.Window;
            TxtSearchCustomerLastName.BorderStyle = BorderStyle.FixedSingle;
            TxtSearchCustomerLastName.Location = new Point(357, 50);
            TxtSearchCustomerLastName.Name = "TxtSearchCustomerLastName";
            TxtSearchCustomerLastName.Size = new Size(145, 23);
            TxtSearchCustomerLastName.TabIndex = 2;
            // 
            // LblInfoSearchOrdersDateFrom
            // 
            LblInfoSearchOrdersDateFrom.AutoSize = true;
            LblInfoSearchOrdersDateFrom.Location = new Point(26, 89);
            LblInfoSearchOrdersDateFrom.Name = "LblInfoSearchOrdersDateFrom";
            LblInfoSearchOrdersDateFrom.Size = new Size(60, 15);
            LblInfoSearchOrdersDateFrom.TabIndex = 5;
            LblInfoSearchOrdersDateFrom.Text = "Date from";
            // 
            // LblInfoSearchOrdersDateUntil
            // 
            LblInfoSearchOrdersDateUntil.AutoSize = true;
            LblInfoSearchOrdersDateUntil.Location = new Point(192, 89);
            LblInfoSearchOrdersDateUntil.Name = "LblInfoSearchOrdersDateUntil";
            LblInfoSearchOrdersDateUntil.Size = new Size(58, 15);
            LblInfoSearchOrdersDateUntil.TabIndex = 4;
            LblInfoSearchOrdersDateUntil.Text = "Date until";
            // 
            // LblInfoSearchOrdersPositionNumber
            // 
            LblInfoSearchOrdersPositionNumber.AutoSize = true;
            LblInfoSearchOrdersPositionNumber.Location = new Point(357, 89);
            LblInfoSearchOrdersPositionNumber.Name = "LblInfoSearchOrdersPositionNumber";
            LblInfoSearchOrdersPositionNumber.Size = new Size(94, 15);
            LblInfoSearchOrdersPositionNumber.TabIndex = 3;
            LblInfoSearchOrdersPositionNumber.Text = "PositionNumber";
            // 
            // TxtSearchOrdersPositionNumber
            // 
            TxtSearchOrdersPositionNumber.Location = new Point(357, 107);
            TxtSearchOrdersPositionNumber.Name = "TxtSearchOrdersPositionNumber";
            TxtSearchOrdersPositionNumber.Size = new Size(145, 23);
            TxtSearchOrdersPositionNumber.TabIndex = 6;
            // 
            // DatSearchOrdersFrom
            // 
            DatSearchOrdersFrom.CustomFormat = "HTML Format";
            DatSearchOrdersFrom.Format = DateTimePickerFormat.Short;
            DatSearchOrdersFrom.Location = new Point(26, 107);
            DatSearchOrdersFrom.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DatSearchOrdersFrom.Name = "DatSearchOrdersFrom";
            DatSearchOrdersFrom.Size = new Size(145, 23);
            DatSearchOrdersFrom.TabIndex = 9;
            DatSearchOrdersFrom.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // DatSearchOrdersUntil
            // 
            DatSearchOrdersUntil.CustomFormat = "HTML Format";
            DatSearchOrdersUntil.Format = DateTimePickerFormat.Short;
            DatSearchOrdersUntil.Location = new Point(192, 107);
            DatSearchOrdersUntil.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DatSearchOrdersUntil.Name = "DatSearchOrdersUntil";
            DatSearchOrdersUntil.Size = new Size(145, 23);
            DatSearchOrdersUntil.TabIndex = 9;
            DatSearchOrdersUntil.Value = new DateTime(2100, 1, 1, 0, 0, 0, 0);
            // 
            // GrpSearch
            // 
            GrpSearch.Controls.Add(DatSearchOrdersUntil);
            GrpSearch.Controls.Add(DatSearchOrdersFrom);
            GrpSearch.Controls.Add(TxtSearchOrdersPositionNumber);
            GrpSearch.Controls.Add(LblInfoSearchOrdersPositionNumber);
            GrpSearch.Controls.Add(LblInfoSearchOrdersDateUntil);
            GrpSearch.Controls.Add(LblInfoSearchOrdersDateFrom);
            GrpSearch.Controls.Add(TxtSearchCustomerLastName);
            GrpSearch.Controls.Add(TxtSearchCustomerFirstName);
            GrpSearch.Controls.Add(TxtSearchOrderPriceTo);
            GrpSearch.Controls.Add(TxtSearchOrderPriceFrom);
            GrpSearch.Controls.Add(TxtSearchCustomerNumber);
            GrpSearch.Controls.Add(CmdResetSearchFilters);
            GrpSearch.Controls.Add(CmdSearchOrders);
            GrpSearch.Controls.Add(LblInfoSearchOrdersPriceTo);
            GrpSearch.Controls.Add(LblInfoSearchOrdersCustomerLastName);
            GrpSearch.Controls.Add(LblInfoSearchOrdersPriceFrom);
            GrpSearch.Controls.Add(LblInfoSearchOrdersCustomerFirstName);
            GrpSearch.Controls.Add(LblInfoSearchOrdersCustomerNumber);
            GrpSearch.ForeColor = SystemColors.ControlText;
            GrpSearch.Location = new Point(3, 0);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Size = new Size(528, 245);
            GrpSearch.TabIndex = 2;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // CmdDeleteSelectedObject
            // 
            CmdDeleteSelectedObject.Location = new Point(358, 356);
            CmdDeleteSelectedObject.Name = "CmdDeleteSelectedObject";
            CmdDeleteSelectedObject.Size = new Size(165, 23);
            CmdDeleteSelectedObject.TabIndex = 0;
            CmdDeleteSelectedObject.Text = "Delete selected Object";
            CmdDeleteSelectedObject.UseVisualStyleBackColor = true;
            CmdDeleteSelectedObject.Click += CmdDeleteSelectedObject_Click;
            // 
            // CmdEditSelectedOrder
            // 
            CmdEditSelectedOrder.Location = new Point(217, 356);
            CmdEditSelectedOrder.Name = "CmdEditSelectedOrder";
            CmdEditSelectedOrder.Size = new Size(135, 23);
            CmdEditSelectedOrder.TabIndex = 0;
            CmdEditSelectedOrder.Text = "Edit selected Order";
            CmdEditSelectedOrder.UseVisualStyleBackColor = true;
            CmdEditSelectedOrder.Click += CmdEditSelectedOrder_Click;
            // 
            // CmdShowAllOrders
            // 
            CmdShowAllOrders.Location = new Point(7, 356);
            CmdShowAllOrders.Name = "CmdShowAllOrders";
            CmdShowAllOrders.Size = new Size(126, 23);
            CmdShowAllOrders.TabIndex = 0;
            CmdShowAllOrders.Text = "Show all Orders";
            CmdShowAllOrders.UseVisualStyleBackColor = true;
            CmdShowAllOrders.Click += CmdShowAllOrders_Click;
            // 
            // DataGridViewOrdersResults
            // 
            DataGridViewOrdersResults.AllowUserToDeleteRows = false;
            DataGridViewOrdersResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrdersResults.Location = new Point(7, 22);
            DataGridViewOrdersResults.Name = "DataGridViewOrdersResults";
            DataGridViewOrdersResults.Size = new Size(516, 328);
            DataGridViewOrdersResults.TabIndex = 2;
            // 
            // GrpResults
            // 
            GrpResults.Controls.Add(LblGridViewOrdersNoResults);
            GrpResults.Controls.Add(DataGridViewOrdersResults);
            GrpResults.Controls.Add(CmdShowAllOrders);
            GrpResults.Controls.Add(CmdEditSelectedOrder);
            GrpResults.Controls.Add(CmdDeleteSelectedObject);
            GrpResults.ForeColor = SystemColors.ControlText;
            GrpResults.Location = new Point(3, 251);
            GrpResults.Name = "GrpResults";
            GrpResults.Size = new Size(528, 385);
            GrpResults.TabIndex = 2;
            GrpResults.TabStop = false;
            GrpResults.Text = "Orders";
            // 
            // LblGridViewOrdersNoResults
            // 
            LblGridViewOrdersNoResults.AutoSize = true;
            LblGridViewOrdersNoResults.Location = new Point(226, 182);
            LblGridViewOrdersNoResults.Name = "LblGridViewOrdersNoResults";
            LblGridViewOrdersNoResults.Size = new Size(63, 15);
            LblGridViewOrdersNoResults.TabIndex = 1;
            LblGridViewOrdersNoResults.Text = "No Results";
            // 
            // UsrCtrlOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GrpInformation);
            Controls.Add(GrpSearch);
            Controls.Add(GrpResults);
            Name = "UsrCtrlOrders";
            Size = new Size(1085, 640);
            GrpPositions.ResumeLayout(false);
            GrpInformationSelectedPosition.ResumeLayout(false);
            GrpInformationSelectedPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).EndInit();
            GrpInformation.ResumeLayout(false);
            GrpInformation.PerformLayout();
            GrpSearch.ResumeLayout(false);
            GrpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrdersResults).EndInit();
            GrpResults.ResumeLayout(false);
            GrpResults.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TxtInputArticleGroupParent;
        private Button CmdCreateNewOrder;
        private Button CmdSaveChangesCustomer;
        private Button CmdDeleteOrder;
        private Label LblInfoOrderNumber;
        private Label LblInfoCustomerFirstName;
        private Label LblInfoOrderCustomerNumber;
        private Label LblInfoCustomerLastName;
        private TextBox TxtInputOrderCustomerFirstName;
        private TextBox TxtInputOrderCustomerLastName;
        private TextBox TxtInputOrderNumber;
        private TextBox TxtInputCustomerNumber;
        private GroupBox GrpPositions;
        private DataGridView DataGridViewOrderPositions;
        private Button CmdOpenSelectedPosition;
        private Button CmdAddNewPosition;
        private Button CmdDeleteSelectedPositions;
        private GroupBox GrpInformation;
        private Label LblInfoSearchOrdersCustomerNumber;
        private Label LblInfoSearchOrdersCustomerFirstName;
        private Label LblInfoSearchOrdersPriceFrom;
        private Label LblInfoSearchOrdersCustomerLastName;
        private Label LblInfoSearchOrdersPriceTo;
        private Button CmdSearchOrders;
        private Button CmdResetSearchFilters;
        private TextBox TxtSearchCustomerNumber;
        private TextBox TxtSearchOrderPriceFrom;
        private TextBox TxtSearchOrderPriceTo;
        private TextBox TxtSearchCustomerFirstName;
        private TextBox TxtSearchCustomerLastName;
        private Label LblInfoSearchOrdersDateFrom;
        private Label LblInfoSearchOrdersDateUntil;
        private Label LblInfoSearchOrdersPositionNumber;
        private TextBox TxtSearchOrdersPositionNumber;
        private DateTimePicker DatSearchOrdersFrom;
        private DateTimePicker DatSearchOrdersUntil;
        private GroupBox GrpSearch;
        private Button CmdDeleteSelectedObject;
        private Button CmdEditSelectedOrder;
        private Button CmdShowAllOrders;
        private DataGridView DataGridViewOrdersResults;
        private GroupBox GrpResults;
        private TextBox TxtInputOrderDate;
        private Label LblInfoOrderDate;
        private GroupBox GrpInformationSelectedPosition;
        private Button CmdDeletePosition;
        private Button CmdSavePositionChanges;
        private Button CmdSaveAsNewPosition;
        private DataGridViewTextBoxColumn positionNumber;
        private DataGridViewTextBoxColumn article;
        private DataGridViewTextBoxColumn quantity;
        private TextBox TxtInputPositionNumber;
        private Label LblInfoPositionNumber;
        private Button CmdShowInvoice;
        private TextBox TxtInputInvoiceNumber;
        private Label LblInfoInvoiceNumber;
        private TextBox TxtInputCustomerFirstName;
        private TextBox TxtInputCustomerPassword;
        private TextBox TxtInputOrderPositionArticleQuantity;
        private Label LblInfoPositionArticleQuantity;
        private Label LblInfoPositionArticle;
        private ComboBox CmbInputArticle;
        private Label LblGridViewOrdersNoResults;
        //private TextBox TxtInputOrderCustomerLastName;
    }
}
