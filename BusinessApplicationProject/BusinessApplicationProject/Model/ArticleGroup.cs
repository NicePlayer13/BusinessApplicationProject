using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Represents a hierarchical group for organizing articles.
    /// </summary>
    public class ArticleGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public required string Name { get; set; }


        public int? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public ArticleGroup? Parent { get; set; }


        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
