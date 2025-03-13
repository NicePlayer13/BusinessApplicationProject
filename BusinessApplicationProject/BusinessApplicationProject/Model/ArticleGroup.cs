using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    public class ArticleGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Name { get; set; }

        public int? ParentId { get; set; } // Nullable for root groups
        [ForeignKey(nameof(ParentId))]
        public ArticleGroup? Parent { get; set; }

        // ✅ Fix: Add navigation property for Articles
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
