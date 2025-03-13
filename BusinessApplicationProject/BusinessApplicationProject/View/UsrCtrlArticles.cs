using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlArticles : UserControl
    {
        public static UsrCtrlArticles instance = new();

        public UsrCtrlArticles()
        {
            InitializeComponent();
            LoadArticleGroups();
        }

        private Controller<ArticleGroup> articleGroupController = new Controller<ArticleGroup>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = context => new Repository<ArticleGroup>(context)
        };

        private Controller<Article> articleController = new Controller<Article>
        {
            GetContext = () => new AppDbContext(),
            GetRepository = context => new Repository<Article>(context)
        };



        public void LoadArticleGroups()
        {
            CmbInputArticleGroup.Items.Clear();
            CmbInputArticleGroupParent.Items.Clear();
            CmbSearchArticleGroup.Items.Clear();

            CmbInputArticleGroupParent.Items.Add(string.Empty);
            CmbSearchArticleGroup.Items.Add(string.Empty);


            List<ArticleGroup> articleGroups = [];

            articleGroups = articleGroupController.GetAll();

            foreach (ArticleGroup group in articleGroups)
            {
                CmbInputArticleGroup.Items.Add(group.Name);
                CmbInputArticleGroupParent.Items.Add(group.Name);
                CmbSearchArticleGroup.Items.Add(group.Name);
            }

        }

        #region Search
        private void CmdSearchArticles_Click(object sender, EventArgs e)
        {
            TreeViewArticles.Nodes.Clear();
            LblSearchArticlesNoResult.Visible = false;

            UpdateArticleGroups();
            UpdateArticles();
        }

        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            EmptyFieldsArticles();
        }

        private void EmptyFieldsArticles()
        {
            CmbSearchArticleGroup.Text = string.Empty;
            TxtSearchArticleName.Text = string.Empty;
            TxtSearchArticleNumber.Text = string.Empty;
        }

        #endregion


        #region Articles

        private void CmdShowAllArticles_Click(object sender, EventArgs e)
        {
            //Load all Articles into Treeview
            TreeViewArticles.Nodes.Clear();
            EmptyFieldsArticles();

            LblSearchArticlesNoResult.Visible = false;


            //-------------
            var artGrp1 = new ArticleGroup { Name = "Consumer Electronics" };
            var artGrp2 = new ArticleGroup { Parent = artGrp1, Name = "Personal Computing" };
            var artGrp3 = new ArticleGroup { Name = "Software" };
            var artGrp4 = new ArticleGroup { Parent = artGrp3, Name = "Subscription Based" };
            var artGrp5 = new ArticleGroup { Parent = artGrp4, Name = "Productivity" };

            var art1 = new Article()
            {
                ArticleNumber = "A-00001",
                Name = "MacBook Air 13",
                Price = 2100,
                Group = artGrp2
            };

            var art2 = new Article()
            {
                ArticleNumber = "A-00002",
                Name = "Chat GPT Pro 1 Mo",
                Price = 20,
                Group = artGrp5
            };

            List<ArticleGroup> articleGroupsTest = [];

            articleGroupsTest.Add(artGrp1);
            articleGroupsTest.Add(artGrp2);
            articleGroupsTest.Add(artGrp3);
            articleGroupsTest.Add(artGrp4);
            articleGroupsTest.Add(artGrp5);

            List<Article> articlesTest = new List<Article>();

            articlesTest.Add(art1);
            articlesTest.Add(art2);
            //---------------


            UpdateArticleGroups();
            UpdateArticles();
        }

        #region treeview



        public void UpdateArticleGroups()
        {
            try
            {
                List<ArticleGroup> articleGroups = [];
                //var filter = CreateFilterFunctionArticleGroup();
                articleGroups = articleGroupController.GetAll();

                if (articleGroups.Count > 0)
                {
                    List<ArticleGroup> articleGroupsWithParents = [];
                    foreach (var articleGroup in articleGroups)
                    {
                        if (articleGroup.Parent == null)
                        {
                            TreeNode value = new TreeNode(articleGroup.Name);
                            TreeViewArticles.Nodes.Add(value);
                        }
                        else
                        {
                            articleGroupsWithParents.Add(articleGroup);
                        }
                    }

                    foreach (var articleGroup in articleGroupsWithParents)
                    {
                        TreeNode value = new TreeNode(articleGroup.Name);
                        foreach (TreeNode node in TreeViewArticles.Nodes)
                        {
                            if (node.Text == articleGroup.Parent.Name) { node.Nodes.Add(value); }
                        }
                    }

                }
                else
                {
                    LblSearchArticlesNoResult.Visible = true;
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

        public void UpdateArticles()
        {
            try
            {
                List<Article> articles = [];
                var filter = CreateFilterFunction();
                articles = articleController.Find(filter);

                if (articles.Count > 0)
                {
                    foreach (var article in articles)
                    {
                        TreeNode value = new TreeNode(article.Name);

                        TreeNode result = GetParentTreeNode(article.Group.Name, TreeViewArticles.Nodes);
                        if (result != null)
                        {
                            result.Nodes.Add(value);
                        }

                    }

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

        public TreeNode GetParentTreeNode(string name, TreeNodeCollection collection)
        {
            foreach (TreeNode node in collection)
            {
                if (node.Text == name) { return node; }

                TreeNode foundNode = GetParentTreeNode(name, node.Nodes);

                if (foundNode != null)
                {
                    return foundNode;
                }
            }

            return null;
        }

        private Expression<Func<Article, bool>> CreateFilterFunction()
        {
            return article =>
                (string.IsNullOrEmpty(TxtSearchArticleNumber.Text) || article.ArticleNumber.Contains(TxtSearchArticleNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchArticleName.Text) || article.Name.Contains(TxtSearchArticleName.Text)) &&
                (string.IsNullOrEmpty(CmbSearchArticleGroup.Text) || article.Group.Name.Contains(CmbSearchArticleGroup.Text));
        }

        #endregion

        private void CmdEditSelectedObject_Click(object sender, EventArgs e)
        {
            //Edit selected Object
            GrpInformationArticle.Visible = true;
        }


        private void CmdDeleteSelectedObjects_Click(object sender, EventArgs e)
        {
            //check if Node is selected
            if (TreeViewArticles.SelectedNode == null) { return; }

            //Throw warning
            if (WarningDeletedObject())
            {
                //Delete all selected Objects
                DeleteSelectedObjectsTreeView();
            }
        }

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

        private void DeleteSelectedObjectsTreeView()
        {
            TreeNode node = TreeViewArticles.SelectedNode;

            if (node.Parent != null)
            {
                node.Parent.Nodes.Remove(node);
            }
            else
            {
                TreeViewArticles.Nodes.Remove(node);
            }

        }
        #endregion
    }
}
