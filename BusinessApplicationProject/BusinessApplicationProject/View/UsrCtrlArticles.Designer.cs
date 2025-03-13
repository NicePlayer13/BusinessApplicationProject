namespace BusinessApplicationProject.View
{
    partial class UsrCtrlArticles
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
            LblSearchArticlesNoResult = new Label();
            CmdShowAllArticles = new Button();
            CmdEditSelectedObject = new Button();
            CmdDeleteSelectedObject = new Button();
            TreeViewArticles = new TreeView();
            GrpSearch = new GroupBox();
            TxtSearchArticleNumber = new TextBox();
            TxtSearchArticleName = new TextBox();
            CmdResetSearchFilters = new Button();
            CmdSearchArticles = new Button();
            LblInfoSearchArticleNumber = new Label();
            CmbSearchArticleGroup = new ComboBox();
            LblInfoSearchArticleName = new Label();
            LblInfoSearchArticleGroup = new Label();
            GrpInformationArticleGroup = new GroupBox();
            TxtInputArticleGroupName = new TextBox();
            GrpInformationArticleGroupName = new Label();
            GrpInformationArticleGroupParent = new Label();
            button4 = new Button();
            button6 = new Button();
            CmbInputArticleGroupParent = new ComboBox();
            GrpInformationArticle = new GroupBox();
            TxtInputArticleNumber = new TextBox();
            TxtInputArticlePrice = new TextBox();
            TxtInputArticleName = new TextBox();
            LblInfoArticlePrice = new Label();
            LblInfoArticleName = new Label();
            LblInfoArticleNumber = new Label();
            LblInfoArticleGroup = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            CmbInputArticleGroup = new ComboBox();
            GrpResults.SuspendLayout();
            GrpSearch.SuspendLayout();
            GrpInformationArticleGroup.SuspendLayout();
            GrpInformationArticle.SuspendLayout();
            SuspendLayout();
            // 
            // GrpResults
            // 
            GrpResults.Controls.Add(LblSearchArticlesNoResult);
            GrpResults.Controls.Add(CmdShowAllArticles);
            GrpResults.Controls.Add(CmdEditSelectedObject);
            GrpResults.Controls.Add(CmdDeleteSelectedObject);
            GrpResults.Controls.Add(TreeViewArticles);
            GrpResults.ForeColor = SystemColors.ControlText;
            GrpResults.Location = new Point(3, 129);
            GrpResults.Name = "GrpResults";
            GrpResults.Size = new Size(528, 507);
            GrpResults.TabIndex = 2;
            GrpResults.TabStop = false;
            GrpResults.Text = "Articles";
            // 
            // LblSearchArticlesNoResult
            // 
            LblSearchArticlesNoResult.AutoSize = true;
            LblSearchArticlesNoResult.Location = new Point(226, 242);
            LblSearchArticlesNoResult.Name = "LblSearchArticlesNoResult";
            LblSearchArticlesNoResult.Size = new Size(58, 15);
            LblSearchArticlesNoResult.TabIndex = 1;
            LblSearchArticlesNoResult.Text = "No Result";
            // 
            // CmdShowAllArticles
            // 
            CmdShowAllArticles.Location = new Point(6, 478);
            CmdShowAllArticles.Name = "CmdShowAllArticles";
            CmdShowAllArticles.Size = new Size(126, 23);
            CmdShowAllArticles.TabIndex = 0;
            CmdShowAllArticles.Text = "Show all Articles";
            CmdShowAllArticles.UseVisualStyleBackColor = true;
            CmdShowAllArticles.Click += CmdShowAllArticles_Click;
            // 
            // CmdEditSelectedObject
            // 
            CmdEditSelectedObject.Location = new Point(216, 478);
            CmdEditSelectedObject.Name = "CmdEditSelectedObject";
            CmdEditSelectedObject.Size = new Size(135, 23);
            CmdEditSelectedObject.TabIndex = 0;
            CmdEditSelectedObject.Text = "Edit selected Object";
            CmdEditSelectedObject.UseVisualStyleBackColor = true;
            CmdEditSelectedObject.Click += CmdEditSelectedObject_Click;
            // 
            // CmdDeleteSelectedObject
            // 
            CmdDeleteSelectedObject.Location = new Point(357, 478);
            CmdDeleteSelectedObject.Name = "CmdDeleteSelectedObject";
            CmdDeleteSelectedObject.Size = new Size(165, 23);
            CmdDeleteSelectedObject.TabIndex = 0;
            CmdDeleteSelectedObject.Text = "Delete selected Object";
            CmdDeleteSelectedObject.UseVisualStyleBackColor = true;
            CmdDeleteSelectedObject.Click += CmdDeleteSelectedObjects_Click;
            // 
            // TreeViewArticles
            // 
            TreeViewArticles.Location = new Point(6, 22);
            TreeViewArticles.Name = "TreeViewArticles";
            TreeViewArticles.Size = new Size(516, 450);
            TreeViewArticles.TabIndex = 2;
            // 
            // GrpSearch
            // 
            GrpSearch.Controls.Add(TxtSearchArticleNumber);
            GrpSearch.Controls.Add(TxtSearchArticleName);
            GrpSearch.Controls.Add(CmdResetSearchFilters);
            GrpSearch.Controls.Add(CmdSearchArticles);
            GrpSearch.Controls.Add(LblInfoSearchArticleNumber);
            GrpSearch.Controls.Add(CmbSearchArticleGroup);
            GrpSearch.Controls.Add(LblInfoSearchArticleName);
            GrpSearch.Controls.Add(LblInfoSearchArticleGroup);
            GrpSearch.ForeColor = SystemColors.ControlText;
            GrpSearch.Location = new Point(3, 0);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Size = new Size(528, 123);
            GrpSearch.TabIndex = 2;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // TxtSearchArticleNumber
            // 
            TxtSearchArticleNumber.Location = new Point(357, 50);
            TxtSearchArticleNumber.Name = "TxtSearchArticleNumber";
            TxtSearchArticleNumber.Size = new Size(145, 23);
            TxtSearchArticleNumber.TabIndex = 2;
            // 
            // TxtSearchArticleName
            // 
            TxtSearchArticleName.Location = new Point(192, 50);
            TxtSearchArticleName.Name = "TxtSearchArticleName";
            TxtSearchArticleName.Size = new Size(145, 23);
            TxtSearchArticleName.TabIndex = 2;
            // 
            // CmdResetSearchFilters
            // 
            CmdResetSearchFilters.Location = new Point(273, 89);
            CmdResetSearchFilters.Name = "CmdResetSearchFilters";
            CmdResetSearchFilters.Size = new Size(117, 23);
            CmdResetSearchFilters.TabIndex = 0;
            CmdResetSearchFilters.Text = "Reset search filters";
            CmdResetSearchFilters.UseVisualStyleBackColor = true;
            CmdResetSearchFilters.Click += CmdResetSearchFilters_Click;
            // 
            // CmdSearchArticles
            // 
            CmdSearchArticles.Location = new Point(396, 89);
            CmdSearchArticles.Name = "CmdSearchArticles";
            CmdSearchArticles.Size = new Size(126, 23);
            CmdSearchArticles.TabIndex = 0;
            CmdSearchArticles.Text = "Search Articles";
            CmdSearchArticles.UseVisualStyleBackColor = true;
            CmdSearchArticles.Click += CmdSearchArticles_Click;
            // 
            // LblInfoSearchArticleNumber
            // 
            LblInfoSearchArticleNumber.AutoSize = true;
            LblInfoSearchArticleNumber.Location = new Point(357, 30);
            LblInfoSearchArticleNumber.Name = "LblInfoSearchArticleNumber";
            LblInfoSearchArticleNumber.Size = new Size(88, 15);
            LblInfoSearchArticleNumber.TabIndex = 1;
            LblInfoSearchArticleNumber.Text = "Article Number";
            // 
            // CmbSearchArticleGroup
            // 
            CmbSearchArticleGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbSearchArticleGroup.BackColor = SystemColors.Window;
            CmbSearchArticleGroup.FormattingEnabled = true;
            CmbSearchArticleGroup.ItemHeight = 15;
            CmbSearchArticleGroup.Location = new Point(26, 50);
            CmbSearchArticleGroup.Name = "CmbSearchArticleGroup";
            CmbSearchArticleGroup.Size = new Size(145, 23);
            CmbSearchArticleGroup.Sorted = true;
            CmbSearchArticleGroup.TabIndex = 3;
            // 
            // LblInfoSearchArticleName
            // 
            LblInfoSearchArticleName.AutoSize = true;
            LblInfoSearchArticleName.Location = new Point(192, 30);
            LblInfoSearchArticleName.Name = "LblInfoSearchArticleName";
            LblInfoSearchArticleName.Size = new Size(76, 15);
            LblInfoSearchArticleName.TabIndex = 1;
            LblInfoSearchArticleName.Text = "Article Name";
            // 
            // LblInfoSearchArticleGroup
            // 
            LblInfoSearchArticleGroup.AutoSize = true;
            LblInfoSearchArticleGroup.Location = new Point(26, 30);
            LblInfoSearchArticleGroup.Name = "LblInfoSearchArticleGroup";
            LblInfoSearchArticleGroup.Size = new Size(77, 15);
            LblInfoSearchArticleGroup.TabIndex = 1;
            LblInfoSearchArticleGroup.Text = "Article Group";
            // 
            // GrpInformationArticleGroup
            // 
            GrpInformationArticleGroup.Controls.Add(TxtInputArticleGroupName);
            GrpInformationArticleGroup.Controls.Add(GrpInformationArticleGroupName);
            GrpInformationArticleGroup.Controls.Add(GrpInformationArticleGroupParent);
            GrpInformationArticleGroup.Controls.Add(button4);
            GrpInformationArticleGroup.Controls.Add(button6);
            GrpInformationArticleGroup.Controls.Add(CmbInputArticleGroupParent);
            GrpInformationArticleGroup.Location = new Point(555, 129);
            GrpInformationArticleGroup.Name = "GrpInformationArticleGroup";
            GrpInformationArticleGroup.Size = new Size(528, 123);
            GrpInformationArticleGroup.TabIndex = 3;
            GrpInformationArticleGroup.TabStop = false;
            GrpInformationArticleGroup.Text = "Information selected Article Group";
            // 
            // TxtInputArticleGroupName
            // 
            TxtInputArticleGroupName.BackColor = SystemColors.Window;
            TxtInputArticleGroupName.BorderStyle = BorderStyle.None;
            TxtInputArticleGroupName.Cursor = Cursors.IBeam;
            TxtInputArticleGroupName.Location = new Point(120, 54);
            TxtInputArticleGroupName.Name = "TxtInputArticleGroupName";
            TxtInputArticleGroupName.Size = new Size(133, 16);
            TxtInputArticleGroupName.TabIndex = 2;
            // 
            // GrpInformationArticleGroupName
            // 
            GrpInformationArticleGroupName.AutoSize = true;
            GrpInformationArticleGroupName.Location = new Point(21, 55);
            GrpInformationArticleGroupName.Name = "GrpInformationArticleGroupName";
            GrpInformationArticleGroupName.Size = new Size(75, 15);
            GrpInformationArticleGroupName.TabIndex = 1;
            GrpInformationArticleGroupName.Text = "Group Name";
            // 
            // GrpInformationArticleGroupParent
            // 
            GrpInformationArticleGroupParent.AutoSize = true;
            GrpInformationArticleGroupParent.Location = new Point(21, 30);
            GrpInformationArticleGroupParent.Name = "GrpInformationArticleGroupParent";
            GrpInformationArticleGroupParent.Size = new Size(77, 15);
            GrpInformationArticleGroupParent.TabIndex = 1;
            GrpInformationArticleGroupParent.Text = "Group Parent";
            // 
            // button4
            // 
            button4.Location = new Point(412, 89);
            button4.Name = "button4";
            button4.Size = new Size(110, 23);
            button4.TabIndex = 0;
            button4.Text = "Delete Group";
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(6, 89);
            button6.Name = "button6";
            button6.Size = new Size(156, 23);
            button6.TabIndex = 0;
            button6.Text = "Save as new Article Group";
            button6.UseVisualStyleBackColor = true;
            // 
            // CmbInputArticleGroupParent
            // 
            CmbInputArticleGroupParent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbInputArticleGroupParent.BackColor = SystemColors.Window;
            CmbInputArticleGroupParent.FormattingEnabled = true;
            CmbInputArticleGroupParent.ItemHeight = 15;
            CmbInputArticleGroupParent.Location = new Point(120, 25);
            CmbInputArticleGroupParent.Name = "CmbInputArticleGroupParent";
            CmbInputArticleGroupParent.Size = new Size(133, 23);
            CmbInputArticleGroupParent.Sorted = true;
            CmbInputArticleGroupParent.TabIndex = 3;
            // 
            // GrpInformationArticle
            // 
            GrpInformationArticle.Controls.Add(TxtInputArticleNumber);
            GrpInformationArticle.Controls.Add(TxtInputArticlePrice);
            GrpInformationArticle.Controls.Add(TxtInputArticleName);
            GrpInformationArticle.Controls.Add(LblInfoArticlePrice);
            GrpInformationArticle.Controls.Add(LblInfoArticleName);
            GrpInformationArticle.Controls.Add(LblInfoArticleNumber);
            GrpInformationArticle.Controls.Add(LblInfoArticleGroup);
            GrpInformationArticle.Controls.Add(button3);
            GrpInformationArticle.Controls.Add(button2);
            GrpInformationArticle.Controls.Add(button1);
            GrpInformationArticle.Controls.Add(CmbInputArticleGroup);
            GrpInformationArticle.Location = new Point(555, 0);
            GrpInformationArticle.Name = "GrpInformationArticle";
            GrpInformationArticle.Size = new Size(528, 123);
            GrpInformationArticle.TabIndex = 4;
            GrpInformationArticle.TabStop = false;
            GrpInformationArticle.Text = "Information selected Article";
            // 
            // TxtInputArticleNumber
            // 
            TxtInputArticleNumber.BackColor = SystemColors.ScrollBar;
            TxtInputArticleNumber.BorderStyle = BorderStyle.None;
            TxtInputArticleNumber.Cursor = Cursors.IBeam;
            TxtInputArticleNumber.Location = new Point(374, 30);
            TxtInputArticleNumber.Name = "TxtInputArticleNumber";
            TxtInputArticleNumber.ReadOnly = true;
            TxtInputArticleNumber.Size = new Size(133, 16);
            TxtInputArticleNumber.TabIndex = 2;
            // 
            // TxtInputArticlePrice
            // 
            TxtInputArticlePrice.BackColor = SystemColors.Window;
            TxtInputArticlePrice.BorderStyle = BorderStyle.None;
            TxtInputArticlePrice.Cursor = Cursors.IBeam;
            TxtInputArticlePrice.Location = new Point(374, 57);
            TxtInputArticlePrice.Name = "TxtInputArticlePrice";
            TxtInputArticlePrice.Size = new Size(133, 16);
            TxtInputArticlePrice.TabIndex = 2;
            // 
            // TxtInputArticleName
            // 
            TxtInputArticleName.BackColor = SystemColors.Window;
            TxtInputArticleName.BorderStyle = BorderStyle.None;
            TxtInputArticleName.Cursor = Cursors.IBeam;
            TxtInputArticleName.Location = new Point(120, 57);
            TxtInputArticleName.Name = "TxtInputArticleName";
            TxtInputArticleName.Size = new Size(133, 16);
            TxtInputArticleName.TabIndex = 2;
            // 
            // LblInfoArticlePrice
            // 
            LblInfoArticlePrice.AutoSize = true;
            LblInfoArticlePrice.Location = new Point(275, 58);
            LblInfoArticlePrice.Name = "LblInfoArticlePrice";
            LblInfoArticlePrice.Size = new Size(70, 15);
            LblInfoArticlePrice.TabIndex = 1;
            LblInfoArticlePrice.Text = "Article Price";
            // 
            // LblInfoArticleName
            // 
            LblInfoArticleName.AutoSize = true;
            LblInfoArticleName.Location = new Point(21, 58);
            LblInfoArticleName.Name = "LblInfoArticleName";
            LblInfoArticleName.Size = new Size(76, 15);
            LblInfoArticleName.TabIndex = 1;
            LblInfoArticleName.Text = "Article Name";
            // 
            // LblInfoArticleNumber
            // 
            LblInfoArticleNumber.AutoSize = true;
            LblInfoArticleNumber.Location = new Point(275, 30);
            LblInfoArticleNumber.Name = "LblInfoArticleNumber";
            LblInfoArticleNumber.Size = new Size(88, 15);
            LblInfoArticleNumber.TabIndex = 1;
            LblInfoArticleNumber.Text = "Article Number";
            // 
            // LblInfoArticleGroup
            // 
            LblInfoArticleGroup.AutoSize = true;
            LblInfoArticleGroup.Location = new Point(21, 30);
            LblInfoArticleGroup.Name = "LblInfoArticleGroup";
            LblInfoArticleGroup.Size = new Size(77, 15);
            LblInfoArticleGroup.TabIndex = 1;
            LblInfoArticleGroup.Text = "Article Group";
            // 
            // button3
            // 
            button3.Location = new Point(412, 89);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 0;
            button3.Text = "Delete Article";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(307, 89);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 0;
            button2.Text = "Save changes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 89);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 0;
            button1.Text = "Save as new Article";
            button1.UseVisualStyleBackColor = true;
            // 
            // CmbInputArticleGroup
            // 
            CmbInputArticleGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbInputArticleGroup.BackColor = SystemColors.Window;
            CmbInputArticleGroup.FormattingEnabled = true;
            CmbInputArticleGroup.ItemHeight = 15;
            CmbInputArticleGroup.Location = new Point(120, 27);
            CmbInputArticleGroup.Name = "CmbInputArticleGroup";
            CmbInputArticleGroup.Size = new Size(133, 23);
            CmbInputArticleGroup.Sorted = true;
            CmbInputArticleGroup.TabIndex = 3;
            // 
            // UsrCtrlArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GrpInformationArticleGroup);
            Controls.Add(GrpInformationArticle);
            Controls.Add(GrpSearch);
            Controls.Add(GrpResults);
            Name = "UsrCtrlArticles";
            Size = new Size(1085, 640);
            GrpResults.ResumeLayout(false);
            GrpResults.PerformLayout();
            GrpSearch.ResumeLayout(false);
            GrpSearch.PerformLayout();
            GrpInformationArticleGroup.ResumeLayout(false);
            GrpInformationArticleGroup.PerformLayout();
            GrpInformationArticle.ResumeLayout(false);
            GrpInformationArticle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GrpResults;
        private GroupBox GrpSearch;
        private Button CmdEditSelectedObject;
        private Button CmdDeleteSelectedObject;
        private Button CmdShowAllArticles;
        private Button CmdResetSearchFilters;
        private Button CmdSearchArticles;
        private Label LblInfoSearchArticleGroup;
        private Label LblInfoSearchArticleNumber;
        private Label LblInfoSearchArticleName;
        private TextBox TxtSearchArticleNumber;
        private TextBox TxtSearchArticleName;
        private TreeView TreeViewArticles;
        private GroupBox GrpInformationArticleGroup;
        private TextBox TxtInputArticleGroupName;
        private Label GrpInformationArticleGroupName;
        private Label GrpInformationArticleGroupParent;
        private Button button4;
        private Button button6;
        private ComboBox CmbInputArticleGroupParent;
        private GroupBox GrpInformationArticle;
        private TextBox TxtInputArticleNumber;
        private TextBox TxtInputArticlePrice;
        private TextBox TxtInputArticleName;
        private Label LblInfoArticlePrice;
        private Label LblInfoArticleName;
        private Label LblInfoArticleNumber;
        private Label LblInfoArticleGroup;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox CmbInputArticleGroup;
        private ComboBox CmbSearchArticleGroup;
        private Label LblSearchArticlesNoResult;
    }
}
