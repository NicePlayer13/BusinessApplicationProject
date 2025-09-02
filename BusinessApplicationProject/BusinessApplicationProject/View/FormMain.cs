using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;

namespace BusinessApplicationProject.View
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

        private readonly Controller<Order> _orderController = new Controller<Order>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = ctx => new Repository<Order>(ctx)
        };

        private readonly Controller<Article> _articleController = new Controller<Article>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = ctx => new Repository<Article>(ctx)
        };

        private readonly Controller<ArticleGroup> _articleGroupController = new Controller<ArticleGroup>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = ctx => new Repository<ArticleGroup>(ctx)
        };


        private readonly Controller<Customer> _customerController = new Controller<Customer>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = ctx => new Repository<Customer>(ctx)
        };

        private readonly Controller<Order> _temporalOrderController = new Controller<Order>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = ctx => new TemporalRepository<Order>(ctx)
        };


        private readonly Controller<Invoice> _invoiceController = new Controller<Invoice>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = ctx => new Repository<Invoice>(ctx)
        };

        private readonly Controller<Order> _invoiceOrderController = new Controller<Order>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = ctx => new Repository<Order>(ctx)
        };

        private readonly TemporalController<Article> _articleTemporalController = new TemporalController<Article>
        {
            GetContext = () => new AppDbContext(),
            GetTemporalRepository = ctx => new TemporalRepository<Article>(ctx),
            GetRepository = ctx => new TemporalRepository<Article>(ctx)
        };

        public FormMain()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            ordersControl = new UsrCtrlOrders(this, _orderController);
            UsrCtrlOrders.instance = ordersControl;

            UsrCtrlArticles.instance = new UsrCtrlArticles(_articleController, _articleGroupController);
            UsrCtrlInvoices.instance = new UsrCtrlInvoices(_invoiceController, _invoiceOrderController, _articleTemporalController);
            UsrCtrlCustomers.instance = new UsrCtrlCustomers(_customerController, _temporalOrderController);


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