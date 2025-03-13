namespace BusinessApplicationProject.View
{
    partial class FormMain
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GrpNavigation = new GroupBox();
            CmdInvoices = new Button();
            CmdArticles = new Button();
            CmdCloseProgram = new Button();
            CmdOrders = new Button();
            CmdCustomers = new Button();
            PnlMainView = new Panel();
            GrpNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // GrpNavigation
            // 
            GrpNavigation.Controls.Add(CmdInvoices);
            GrpNavigation.Controls.Add(CmdArticles);
            GrpNavigation.Controls.Add(CmdCloseProgram);
            GrpNavigation.Controls.Add(CmdOrders);
            GrpNavigation.Controls.Add(CmdCustomers);
            GrpNavigation.Location = new Point(9, 8);
            GrpNavigation.Name = "GrpNavigation";
            GrpNavigation.Size = new Size(110, 634);
            GrpNavigation.TabIndex = 2;
            GrpNavigation.TabStop = false;
            GrpNavigation.Text = "Navigation";
            // 
            // CmdInvoices
            // 
            CmdInvoices.Location = new Point(6, 107);
            CmdInvoices.Name = "CmdInvoices";
            CmdInvoices.Size = new Size(99, 23);
            CmdInvoices.TabIndex = 1;
            CmdInvoices.Text = "Invoices";
            CmdInvoices.UseVisualStyleBackColor = true;
            CmdInvoices.Click += CmdInvoices_Click;
            // 
            // CmdArticles
            // 
            CmdArticles.Location = new Point(6, 20);
            CmdArticles.Name = "CmdArticles";
            CmdArticles.Size = new Size(99, 23);
            CmdArticles.TabIndex = 0;
            CmdArticles.Text = "Articles";
            CmdArticles.UseVisualStyleBackColor = true;
            CmdArticles.Click += CmdArticles_Click;
            // 
            // CmdCloseProgram
            // 
            CmdCloseProgram.Location = new Point(6, 164);
            CmdCloseProgram.Name = "CmdCloseProgram";
            CmdCloseProgram.Size = new Size(99, 23);
            CmdCloseProgram.TabIndex = 0;
            CmdCloseProgram.Text = "Exit";
            CmdCloseProgram.UseVisualStyleBackColor = true;
            CmdCloseProgram.Click += CmdCloseProgram_Click;
            // 
            // CmdOrders
            // 
            CmdOrders.Location = new Point(6, 78);
            CmdOrders.Name = "CmdOrders";
            CmdOrders.Size = new Size(99, 23);
            CmdOrders.TabIndex = 0;
            CmdOrders.Text = "Orders";
            CmdOrders.UseVisualStyleBackColor = true;
            CmdOrders.Click += CmdOrders_Click;
            // 
            // CmdCustomers
            // 
            CmdCustomers.Location = new Point(6, 49);
            CmdCustomers.Name = "CmdCustomers";
            CmdCustomers.Size = new Size(99, 23);
            CmdCustomers.TabIndex = 0;
            CmdCustomers.Text = "Customers";
            CmdCustomers.UseVisualStyleBackColor = true;
            CmdCustomers.Click += CmdCustomers_Click;
            // 
            // PnlMainView
            // 
            PnlMainView.Location = new Point(124, 7);
            PnlMainView.Margin = new Padding(2);
            PnlMainView.Name = "PnlMainView";
            PnlMainView.Size = new Size(1085, 640);
            PnlMainView.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(PnlMainView);
            Controls.Add(GrpNavigation);
            Margin = new Padding(2);
            Name = "FormMain";
            Text = "FormMain";
            GrpNavigation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrpNavigation;
        private Button CmdInvoices;
        private Button CmdArticles;
        private Button CmdCloseProgram;
        private Button CmdOrders;
        private Button CmdCustomers;
        private Panel PnlMainView;
    }
}