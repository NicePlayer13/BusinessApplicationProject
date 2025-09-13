using BusinessApplicationProject;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject.Repository
{
    /// <summary>
    /// Repository for the ArticleGroup entity. Provides access to the article group hierarchy.
    /// </summary>
    public class ArticleGroupRepository : Repository<ArticleGroup>
    {
        public ArticleGroupRepository(AppDbContext context) : base(context) { }

        /// <summary>
        /// Retrieves the hierarchical structure of article groups using a recursive CTE.
        /// </summary>
        /// <returns>List of article groups with parent-child relationships.</returns>
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
