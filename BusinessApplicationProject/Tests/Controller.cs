using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessApplicationProject.Tests
{
    [TestClass]
    public class ArticleControllerTests
    {
        private Controller<Article> _controller = null!;
        private Mock<IRepository<Article>> _mockRepo = null!;

        [TestInitialize]
        public void Setup()
        {
            var articles = new List<Article>
            {
                new Article { Id = 1, ArticleNumber = "A-001", Name = "Laptop", Price = 1000 },
                new Article { Id = 2, ArticleNumber = "A-002", Name = "Phone", Price = 500 },
            };

            _mockRepo = new Mock<IRepository<Article>>();
            _mockRepo.Setup(r => r.GetAll()).Returns(articles);
            _mockRepo.Setup(r => r.Find(It.IsAny<System.Linq.Expressions.Expression<System.Func<Article, bool>>>()))
                     .Returns((System.Linq.Expressions.Expression<System.Func<Article, bool>> predicate) =>
                         articles.AsQueryable().Where(predicate).ToList());

            _mockRepo.Setup(r => r.AddAsync(It.IsAny<Article>())).Returns(Task.CompletedTask);

            _controller = new Controller<Article>
            {
                GetContext = () => null!, // unused due to mocking
                GetRepository = (_) => _mockRepo.Object
            };
        }

        [TestMethod]
        public void GetAll_ReturnsAllArticles()
        {
            var result = _controller.GetAll().ToList();

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("A-001", result[0].ArticleNumber);
        }

        [TestMethod]
        public void Find_ReturnsMatchingArticles()
        {
            var result = _controller.Find(a => a.Price > 600).ToList();

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Laptop", result[0].Name);
        }

        [TestMethod]
        public async Task AddAsync_AddsArticle()
        {
            var newArticle = new Article { Id = 3, ArticleNumber = "A-003", Name = "Tablet", Price = 300 };

            await _controller.AddAsync(newArticle);

            _mockRepo.Verify(r => r.AddAsync(It.Is<Article>(a => a.ArticleNumber == "A-003")), Times.Once);
        }
    }
}
