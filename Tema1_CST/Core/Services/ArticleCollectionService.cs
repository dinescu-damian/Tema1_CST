using Tema1_CST.DataLayer;
using Tema1_CST.DataLayer.Dtos;
using Tema1_CST.DataLayer.Entities;
using Tema1_CST.DataLayer.Mapping;
using Tema1_CST.DataLayer.Repositories;

namespace Tema1_CST.Core.Services
{
    public class ArticleCollectionService : IArticleCollectionService
    {
        private ArticlesRepository _articlesRepository;
        public ArticleCollectionService(ArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }

        public async Task<bool> Create(ArticleDto model)
        {
            // Create a new article with the given model
            var article = await _articlesRepository.CreateArticleAsync(model);
            return article;
        }

        public async Task<bool> Delete(Guid id)
        {
            // Delete the article having the specified id
            var article = await _articlesRepository.DeleteArticleAsync(id);
            return article;
            
        }

        public async Task<ArticleDto> Get(Guid id)
        {
            // Get the article with the specified id
            var article = await _articlesRepository.GetArticleByIdAsync(id);
            var result = article.ToDto();
            return result;
        }

        public async Task<List<ArticleDto>> GetAll()
        {
            // Get all the articles from the DB
            var articles = await _articlesRepository.GetAllArticlesAsync();
            var results = articles.ToDtos();
            return results;
        }

        public async Task<bool> Update(Guid id, ArticleDto model)
        {
            // Update the article having the specified id with the new model
            var article = await _articlesRepository.UpdateArticleAsync(model);
            return article;

            
        }
    }
}
