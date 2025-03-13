using BusinessApplicationProject.Model;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject.Repository
{
    /// <summary>
    /// Repository for the ArticleGroup entity.
    /// </summary>
    public class ArticleGroupRepository : Repository<ArticleGroup>
    {
        public ArticleGroupRepository(AppDbContext context) : base(context) { }

        public List<ArticleGroup> GetHierarchy()
        {
            string cteQuery = @"
                ;WITH ArticleGroupHierarchy AS (
                    SELECT Id, Name, ParentId
                    FROM ArticleGroups
                    WHERE ParentId IS NULL
                    UNION ALL
                    SELECT ag.Id, ag.Name, ag.ParentId
                    FROM ArticleGroups ag
                    INNER JOIN ArticleGroupHierarchy agh ON ag.ParentId = agh.Id
                )
                SELECT * FROM ArticleGroupHierarchy";

            return Context.ArticleGroups.FromSqlRaw(cteQuery).ToList();
        }
    }
}
