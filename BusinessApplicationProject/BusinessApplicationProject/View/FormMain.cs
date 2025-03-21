﻿namespace BusinessApplicationProject.View
{
    public partial class FormMain : Form
    {
       public enum View
        {
            Articles,
            Orders,
            Invoices,
            Customers
        }
        private UsrCtrlOrders ordersControl;
        public FormMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            ordersControl = new UsrCtrlOrders(this);
            // ✅ Ensure the static instance is initialized
    UsrCtrlInvoices.instance = new UsrCtrlInvoices();
            // Set default view to customers
            ToggleView(View.Customers, CmdCustomers);
        }

        private void CmdArticles_Click(object sender, EventArgs e)
        {
            ToggleView(View.Articles, sender);
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            ToggleView(View.Customers, sender);
        }

        private void CmdOrders_Click(object sender, EventArgs e)
        {
            ToggleView(View.Orders, sender);
        }

        public void CmdInvoices_Click(object sender, EventArgs e)
        {
            ToggleView(View.Invoices, sender);
        }

        private void CmdCloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ToggleView(View nextView, object sender)
        {
            EnableAllNavigationButtons();
            ((Button)sender).Enabled = false;

            switch (nextView)
            {
                case View.Articles:
                    SwapViewInstance(UsrCtrlArticles.instance);
                    break;

                case View.Orders:
                    SwapViewInstance(UsrCtrlOrders.instance);
                    break;

                case View.Invoices:
                    SwapViewInstance(UsrCtrlInvoices.instance);
                    break;

                default:
                    SwapViewInstance(UsrCtrlCustomers.instance);
                    break;
            }
        }

        private void EnableAllNavigationButtons()
        {
            CmdArticles.Enabled = true;
            CmdCustomers.Enabled = true;
            CmdOrders.Enabled = true;
            CmdInvoices.Enabled = true;
            CmdCloseProgram.Enabled = true;
        }

        public void SwapViewInstance(UserControl instance)
        {
            if (!PnlMainView.Controls.Contains(instance))
            {
                PnlMainView.Controls.Clear();
                PnlMainView.Controls.Add(instance);
            }
        }
    }
}