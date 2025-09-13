using System.Linq.Expressions;
using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;
using BusinessApplicationProject.Helpers;


namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlArticles : UserControl
    {
        public static UsrCtrlArticles instance;

        private readonly Controller<Article> _articleController;
        private readonly Controller<ArticleGroup> _articleGroupController;

        public UsrCtrlArticles(
            Controller<Article> articleController,
            Controller<ArticleGroup> articleGroupController)
        {
            InitializeComponent();

            _articleController = articleController;
            _articleGroupController = articleGroupController;

            LoadArticleGroups();
        }

        public void LoadArticleGroups()
        {
            CmbInputArticleGroup.Items.Clear();
            CmbInputArticleGroupParent.Items.Clear();
            CmbSearchArticleGroup.Items.Clear();

            CmbInputArticleGroupParent.Items.Add(string.Empty);
            CmbSearchArticleGroup.Items.Add(string.Empty);

            List<ArticleGroup> articleGroups = _articleGroupController.GetAll().ToList();

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
                // ✅ Create the correct filter for ArticleGroup (not Article)
                Expression<Func<ArticleGroup, bool>> filter = ag => ag.Parent != null;

                List<ArticleGroup> articleGroups = _articleGroupController
                    .Find(filter) // ✅ Corrected: Now uses ArticleGroup filter
                    .Include(ag => ag.Parent) // ✅ Apply Include() before ToList()
                    .ToList();


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
                            if (node.Text == articleGroup.Parent.Name)
                            {
                                node.Nodes.Add(value);
                            }
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        public void UpdateArticles()
        {
            try
            {
                using var context = new AppDbContext();

                // ✅ Get all article groups with their articles
                var articleGroups = context.ArticleGroups
                    .Include(g => g.Articles) // ✅ Load related articles
                    .Include(g => g.Parent)   // ✅ Load parent groups
                    .ToList();

                // ✅ Clear the tree before adding new nodes
                TreeViewArticles.Nodes.Clear();

                // ✅ Dictionary to keep track of parent nodes
                Dictionary<int, TreeNode> groupNodes = new();

                // ✅ Create nodes for groups and add them first
                foreach (var group in articleGroups)
                {
                    var groupNode = new TreeNode($"{group.Name}");
                    groupNode.Tag = group; // Store the group object

                    if (group.Parent == null)
                    {
                        // ✅ This is a top-level group
                        TreeViewArticles.Nodes.Add(groupNode);
                    }

                    groupNodes[group.Id] = groupNode;
                }

                // ✅ Add subgroups to their parents
                foreach (var group in articleGroups)
                {
                    if (group.Parent != null && groupNodes.ContainsKey(group.Parent.Id))
                    {
                        groupNodes[group.Parent.Id].Nodes.Add(groupNodes[group.Id]);
                    }
                }

                // ✅ Add articles under their respective groups
                foreach (var group in articleGroups)
                {
                    if (groupNodes.TryGetValue(group.Id, out TreeNode parentNode))
                    {
                        foreach (var article in group.Articles)
                        {
                            var articleNode = new TreeNode($"{article.Name} - ${article.Price:F2}"); // ✅ Show Name and Price
                            articleNode.Tag = article; // Store the article object
                            parentNode.Nodes.Add(articleNode);
                        }
                    }
                }

                TreeViewArticles.ExpandAll(); // Expand all nodes for better visibility
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database connection failed. Connection timed out.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating articles: " + ex.Message);
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
        private Article? selectedArticle = null; // Store the currently selected article

        private void CmdEditSelectedObject_Click(object sender, EventArgs e)
        {
            if (TreeViewArticles.SelectedNode == null)
            {
                MessageBox.Show("Please select an article to edit.");
                return;
            }

            // ✅ Get the selected article from TreeView
            selectedArticle = TreeViewArticles.SelectedNode.Tag as Article;

            if (selectedArticle == null)
            {
                MessageBox.Show("Invalid article selection.");
                return;
            }

            // ✅ Populate article fields
            TxtInputArticleNumber.Text = selectedArticle.ArticleNumber;
            TxtInputArticleName.Text = selectedArticle.Name;
            TxtInputArticlePrice.Text = selectedArticle.Price.ToString();

            using (var context = new AppDbContext())
            {
                var articleGroups = context.ArticleGroups.Include(g => g.Parent).ToList();

                // ✅ Populate the dropdowns before selection
                CmbInputArticleGroup.Items.Clear();
                CmbInputArticleGroupParent.Items.Clear();

                foreach (var group in articleGroups)
                {
                    CmbInputArticleGroup.Items.Add(group);
                    CmbInputArticleGroupParent.Items.Add(group);
                }

                CmbInputArticleGroup.DisplayMember = "Name";
                CmbInputArticleGroupParent.DisplayMember = "Name";

                // ✅ Set selected values
                var selectedGroup = articleGroups.FirstOrDefault(g => g.Id == selectedArticle.GroupId);
                CmbInputArticleGroup.SelectedItem = selectedGroup;

                if (selectedGroup?.Parent != null)
                {
                    CmbInputArticleGroupParent.SelectedItem = selectedGroup.Parent;
                }
            }

            GrpInformationArticle.Visible = true;
        }






        private void CmdDeleteSelectedObjects_Click(object sender, EventArgs e)
        {
            // Check if Node is selected
            if (TreeViewArticles.SelectedNode == null)
            {
                MessageBox.Show("Please select an article to delete.");
                return;
            }

            // Get selected article from TreeView
            var selectedArticle = TreeViewArticles.SelectedNode.Tag as Article;
            if (selectedArticle == null)
            {
                MessageBox.Show("Invalid selection. Please try again.");
                return;
            }

            // Confirm deletion
            if (MessageBox.Show($"Are you sure you want to delete '{selectedArticle.Name}'?",
                                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using var context = new AppDbContext();

                    // Find the article in the database
                    var articleToDelete = context.Articles.FirstOrDefault(a => a.Id == selectedArticle.Id);
                    if (articleToDelete == null)
                    {
                        MessageBox.Show("Article not found in database.");
                        return;
                    }

                    // Remove from database
                    context.Articles.Remove(articleToDelete);
                    context.SaveChanges();

                    // Remove from TreeView
                    TreeViewArticles.Nodes.Remove(TreeViewArticles.SelectedNode);

                    MessageBox.Show("Article deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting article: " + ex.Message);
                }
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

        private void CmdSaveNewArticleGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtInputArticleName.Text) ||
                string.IsNullOrWhiteSpace(TxtInputArticlePrice.Text) ||
                string.IsNullOrWhiteSpace(TxtInputArticleGroupName.Text)) // Ensure group name is provided
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using var context = new AppDbContext();

                // ✅ Find or create the article group
                var selectedGroup = context.ArticleGroups
                    .FirstOrDefault(g => g.Name == TxtInputArticleGroupName.Text);

                if (selectedGroup == null)
                {
                    selectedGroup = new ArticleGroup
                    {
                        Name = TxtInputArticleGroupName.Text,
                        Parent = string.IsNullOrWhiteSpace(CmbInputArticleGroupParent.Text)
                                    ? null
                                    : context.ArticleGroups.FirstOrDefault(g => g.Name == CmbInputArticleGroupParent.Text)
                    };

                    context.ArticleGroups.Add(selectedGroup);
                    context.SaveChanges(); // Save the new group before adding an article
                }

                // ✅ Check if updating or creating a new article
                if (selectedArticle != null)
                {
                    selectedArticle.Name = TxtInputArticleName.Text;
                    selectedArticle.Price = double.Parse(TxtInputArticlePrice.Text);
                    selectedArticle.GroupId = selectedGroup.Id;

                    context.Entry(selectedArticle).State = EntityState.Modified;
                }
                else
                {
                    var newArticle = new Article
                    {
                        ArticleNumber = GenerateArticleNumber(context),
                        Name = TxtInputArticleName.Text,
                        Price = double.Parse(TxtInputArticlePrice.Text),
                        GroupId = selectedGroup.Id
                    };

                    context.Articles.Add(newArticle);
                }

                context.SaveChanges();
                MessageBox.Show("Article saved successfully!");

                // ✅ Refresh UI
                LoadArticleGroups();
                UpdateArticlesWithGroups();
                ClearArticleFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the article: " + ex.Message);
            }
        }




        private string GenerateArticleNumber(AppDbContext context)
        {
            int nextId = context.Articles.Any() ? context.Articles.Max(a => a.Id) + 1 : 1;
            return $"A-{nextId:D5}"; // Generates A-00001, A-00002, etc.
        }


        private void LoadArticles()
        {
            TreeViewArticles.Nodes.Clear();

            using var context = new AppDbContext();
            var articles = context.Articles.Include(a => a.Group).ToList();

            foreach (var article in articles)
            {
                var node = new TreeNode($"{article.Name} ({article.ArticleNumber})");
                node.Tag = article; // Store the article object in the node

                TreeNode parentGroup = GetParentTreeNode(article.Group.Name, TreeViewArticles.Nodes);
                if (parentGroup != null)
                {
                    parentGroup.Nodes.Add(node);
                }
                else
                {
                    TreeViewArticles.Nodes.Add(node);
                }
            }
        }

        private void CmdSaveArticleChanges_Click(object sender, EventArgs e)
        {
            if (selectedArticle == null)
            {
                MessageBox.Show("Please select an article to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtInputArticleName.Text) ||
                string.IsNullOrWhiteSpace(TxtInputArticlePrice.Text) ||
                CmbInputArticleGroup.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using var context = new AppDbContext();

                var articleToUpdate = context.Articles.FirstOrDefault(a => a.Id == selectedArticle.Id);
                if (articleToUpdate == null)
                {
                    MessageBox.Show("Selected article not found in database.");
                    return;
                }

                var selectedGroup = context.ArticleGroups.Local
                    .FirstOrDefault(g => g.Name == CmbInputArticleGroup.SelectedItem.ToString())
                    ?? context.ArticleGroups.AsNoTracking().FirstOrDefault(g => g.Name == CmbInputArticleGroup.SelectedItem.ToString());

                if (selectedGroup == null)
                {
                    MessageBox.Show("Invalid article group selection.");
                    return;
                }

                // Update article properties
                articleToUpdate.Name = TxtInputArticleName.Text;
                articleToUpdate.Price = double.Parse(TxtInputArticlePrice.Text);
                articleToUpdate.GroupId = selectedGroup.Id;

                context.Entry(articleToUpdate).State = EntityState.Modified;
                context.SaveChanges();

                MessageBox.Show("Article updated successfully!");

                // Refresh UI
                LoadArticles();
                UpdateArticles();

                // ✅ Clear input fields
                ClearArticleFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating the article: " + ex.Message);
            }
        }


        private void CmdDeleteGroup_Click(object sender, EventArgs e)
        {
            if (TreeViewArticles.SelectedNode == null)
            {
                MessageBox.Show("Bitte wähle eine Artikelgruppe aus.");
                return;
            }

            // Prüfen, ob das selektierte Element eine Gruppe ist
            if (TreeViewArticles.SelectedNode.Tag is not ArticleGroup selectedGroup)
            {
                MessageBox.Show("Bitte wähle eine gültige Artikelgruppe aus (keinen Artikel).");
                return;
            }

            var confirm = MessageBox.Show(
                $"Möchtest du die Artikelgruppe '{selectedGroup.Name}' wirklich löschen?\nAlle zugehörigen Artikel werden ebenfalls entfernt!",
                "Gruppe löschen bestätigen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var context = new AppDbContext();

                // Aktuelle Gruppe mit Artikeln laden
                var group = context.ArticleGroups
                    .Include(g => g.Articles)
                    .FirstOrDefault(g => g.Id == selectedGroup.Id);

                if (group == null)
                {
                    MessageBox.Show("Gruppe wurde nicht in der Datenbank gefunden.");
                    return;
                }

                // Erst Artikel löschen (wegen FK)
                if (group.Articles.Any())
                {
                    context.Articles.RemoveRange(group.Articles);
                }

                // Dann Gruppe löschen
                context.ArticleGroups.Remove(group);
                context.SaveChanges();

                MessageBox.Show("Artikelgruppe erfolgreich gelöscht!");

                // TreeView und Gruppen aktualisieren
                UpdateArticlesWithGroups();
                LoadArticleGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen der Gruppe: " + ex.Message);
            }
        }


        private void ClearArticleFields()
        {
            TxtInputArticleNumber.Text = "";
            TxtInputArticleName.Text = "";
            TxtInputArticlePrice.Text = "";
            CmbInputArticleGroup.SelectedIndex = -1;
            TxtInputArticleGroupName.Text = "";
            CmbInputArticleGroupParent.Text = "";
        }


        private void CmdSaveNewArticle_Click(object sender, EventArgs e)
        {
            // ✅ Validate input fields
            if (string.IsNullOrWhiteSpace(TxtInputArticleName.Text) ||
                string.IsNullOrWhiteSpace(TxtInputArticlePrice.Text) ||
                string.IsNullOrWhiteSpace(TxtInputArticleGroupName.Text)) // Ensure group name is filled
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using var context = new AppDbContext();

                // ✅ Check if the group exists, otherwise create it
                var selectedGroup = context.ArticleGroups.FirstOrDefault(g => g.Name == TxtInputArticleGroupName.Text);

                if (selectedGroup == null) // If group does not exist, create a new one
                {
                    selectedGroup = new ArticleGroup
                    {
                        Name = TxtInputArticleGroupName.Text,
                        Parent = string.IsNullOrWhiteSpace(CmbInputArticleGroupParent.Text) ? null :
                                 context.ArticleGroups.FirstOrDefault(g => g.Name == CmbInputArticleGroupParent.Text) // Set parent group
                    };

                    context.ArticleGroups.Add(selectedGroup);
                    context.SaveChanges(); // Save new group to database
                }

                // ✅ Generate a new article number
                string newArticleNumber = GenerateArticleNumber(context);

                // ✅ Create a new article instance
                var newArticle = new Article
                {
                    ArticleNumber = newArticleNumber,
                    Name = TxtInputArticleName.Text,
                    Price = double.Parse(TxtInputArticlePrice.Text),
                    GroupId = selectedGroup.Id // Assign the correct group
                };

                // ✅ Save to database
                context.Articles.Add(newArticle);
                context.SaveChanges();

                MessageBox.Show($"New article '{newArticle.Name}' has been added successfully!");

                // ✅ Refresh the tree view
                UpdateArticlesWithGroups();

                // ✅ Clear input fields after saving
                ClearArticleFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the article: " + ex.Message);
            }
        }

        private void UpdateArticlesWithGroups()
        {
            try
            {
                using var context = new AppDbContext();
                var articles = context.Articles.Include(a => a.Group).ToList();

                TreeViewArticles.Nodes.Clear(); // Clear previous data

                var groupNodes = new Dictionary<string, TreeNode>();

                foreach (var article in articles)
                {
                    string groupName = article.Group?.Name ?? "Ungrouped"; // Handle articles with no group

                    // Ensure the group node exists
                    if (!groupNodes.ContainsKey(groupName))
                    {
                        TreeNode groupNode = new TreeNode(groupName)
                        {
                            Tag = article.Group // Store group reference
                        };
                        TreeViewArticles.Nodes.Add(groupNode);
                        groupNodes[groupName] = groupNode;
                    }

                    // Add article under its group with price
                    TreeNode articleNode = new TreeNode($"{article.Name} - {article.Price:C} ({article.ArticleNumber})")
                    {
                        Tag = article // Store article reference for editing/deleting
                    };
                    groupNodes[groupName].Nodes.Add(articleNode);
                }

                TreeViewArticles.ExpandAll(); // Expand nodes for better visibility
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating article list: " + ex.Message);
            }
        }




        private void TreeViewArticles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void CmdExportArticles_Click_Click(object sender, EventArgs e)
        {
            DateTime exportTime = DtpExportArticlesTime.Value;

            using var context = new AppDbContext();

            var articles = context.Articles
                .TemporalAsOf(exportTime)
                .Include(a => a.Group)
                .ToList();

            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml",
                Title = "Export Articles as of Time",
                DefaultExt = "json"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(dialog.FileName).ToLowerInvariant();
                try
                {
                    if (ext == ".json")
                        SerializationHelper.SerializeToJson(articles, dialog.FileName);
                    else
                        SerializationHelper.SerializeToXml(articles, dialog.FileName);

                    MessageBox.Show("Temporal export successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed: {ex.Message}");
                }
            }
        }



        private void CmdImportArticles_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml",
                Title = "Import Articles",
                DefaultExt = "json"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var ext = Path.GetExtension(dialog.FileName).ToLowerInvariant();
                List<Article> articles;

                if (ext == ".json")
                    articles = SerializationHelper.DeserializeFromJson<Article>(dialog.FileName);
                else
                    articles = SerializationHelper.DeserializeFromXml<Article>(dialog.FileName);

                int imported = 0, updated = 0, failed = 0;

                using var context = new AppDbContext();

                foreach (var a in articles)
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(a.ArticleNumber))
                            throw new Exception("Article number is missing.");

                        if (string.IsNullOrWhiteSpace(a.Name))
                            throw new Exception("Article name is missing.");

                        var existing = context.Articles
                            .Include(x => x.Group)
                            .FirstOrDefault(x => x.ArticleNumber == a.ArticleNumber);

                        // Try to resolve ArticleGroup if provided
                        ArticleGroup? group = null;
                        if (a.Group != null)
                        {
                            group = context.ArticleGroups.FirstOrDefault(g => g.Name == a.Group.Name);
                            if (group == null)
                            {
                                // Create missing group if needed
                                group = new ArticleGroup { Name = a.Group.Name };
                                context.ArticleGroups.Add(group);
                                context.SaveChanges(); // Save to get new group Id
                            }
                        }

                        if (existing != null)
                        {
                            // Update existing
                            existing.Name = a.Name;
                            existing.Price = a.Price;
                            existing.Group = group;
                            updated++;
                        }
                        else
                        {
                            // Insert new
                            var newArticle = new Article
                            {
                                ArticleNumber = a.ArticleNumber,
                                Name = a.Name,
                                Price = a.Price,
                                Group = group
                            };
                            context.Articles.Add(newArticle);
                            imported++;
                        }
                    }
                    catch (Exception ex)
                    {
                        failed++;
                        MessageBox.Show($"Error importing article '{a.ArticleNumber}': {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                context.SaveChanges();

                MessageBox.Show($"Import complete:\n\nNew: {imported}\nUpdated: {updated}\nFailed: {failed}",
                    "Import Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General import failed: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

