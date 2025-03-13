using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{/// <summary>
/// Article class
/// </summary>
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string ArticleNumber { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }

        public int? GroupId { get; set; }
        [ForeignKey(nameof(GroupId))]
        public ArticleGroup? Group { get; set; }
    }
}
