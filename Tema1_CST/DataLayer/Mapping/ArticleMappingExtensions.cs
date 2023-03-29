using Tema1_CST.DataLayer.Dtos;
using Tema1_CST.DataLayer.Entities;

namespace Tema1_CST.DataLayer.Mapping
{
    public static class ArticleMappingExtensions
    {
        public static ArticleDto ToDto(this Article article)
        {
            return new ArticleDto
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,
                PublishDate = article.PublishDate,
                AuthorId = article.AuthorId,
                Comments = article.Comments.Select(c => c.ToDto()).ToList()
            };
        }
        public static Article ToEntity(this ArticleDto articleDto)
        {
            return new Article
            {
                Id = articleDto.Id,
                Title = articleDto.Title,
                Content = articleDto.Content,
                PublishDate = articleDto.PublishDate,
                AuthorId = articleDto.AuthorId,
                // Get the Author from the database using the AuthorId
                //Author
                Comments = articleDto.Comments.Select(c => c.ToEntity()).ToList()
            };
        }
    }
}
