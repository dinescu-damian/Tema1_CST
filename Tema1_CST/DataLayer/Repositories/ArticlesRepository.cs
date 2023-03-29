using Tema1_CST.DataLayer.Dtos;
using Tema1_CST.DataLayer.Entities;
using Tema1_CST.DataLayer.Mapping;

namespace Tema1_CST.DataLayer.Repositories
{
    public class ArticlesRepository
    {
        private readonly DataContext _dataContext;
        public ArticlesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Article> GetArticleByIdAsync(Guid id)
        {
            return await _dataContext.Articles
                .Include(a => a.Comments)
                .Include(a => a.Author)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await _dataContext.Articles
                .Include(a => a.Comments)
                .Include(a => a.Author)
                .ToListAsync();
        }

        public async Task<bool> CreateArticleAsync(ArticleDto article)
        {
            // Create a new article with the given model DTO
            var articleEntity = article.ToEntity();
            var articleAuthor = await _dataContext.Authors.FirstOrDefaultAsync(a => a.Id == article.AuthorId);
            if (articleAuthor != null) {
                articleEntity.Author = articleAuthor;
            }
            else
            {
                return false;
            }



            await _dataContext.Articles.AddAsync(articleEntity);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> UpdateArticleAsync(ArticleDto articleToUpdate)
        {
            // Create a new article with the given model DTO
            var articleEntity = articleToUpdate.ToEntity();
            var articleAuthor = await _dataContext.Authors.FirstOrDefaultAsync(a => a.Id == articleToUpdate.AuthorId);
            if (articleAuthor != null)
            {
                articleEntity.Author = articleAuthor;
            }
            else
            {
                return false;
            }



            _dataContext.Articles.Update(articleEntity);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeleteArticleAsync(Guid id)
        {
            var article = await GetArticleByIdAsync(id);
            _dataContext.Articles.Remove(article);
            var deleted = await _dataContext.SaveChangesAsync();
            return deleted > 0;
        }
    }
}
