using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{/// <summary>
/// ArticleGroup class
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
    }
}
