using Tema1_CST.DataLayer.Dtos;
using Tema1_CST.DataLayer.Entities;

namespace Tema1_CST.DataLayer.Mapping
{
    public static class CommentMappingExtensions
    {
        public static CommentDto ToDto(this Comment comment)
        {
            return new CommentDto
            {
                Id = comment.Id,
                ArticleId = comment.ArticleId,
                CommentAuthor = comment.CommentAuthor,
                Email = comment.Email,
                Content = comment.Content,
                PublishDate = comment.PublishDate
            };
        }

        public static List<CommentDto> ToDtos(this List<Comment> comments)
        {
            return comments.Select(c => c.ToDto()).ToList();
        }

        public static Comment ToEntity(this CommentDto commentDto)
        {
            return new Comment
            {
                Id = commentDto.Id,
                ArticleId = commentDto.ArticleId,
                CommentAuthor = commentDto.CommentAuthor,
                Email = commentDto.Email,
                Content = commentDto.Content,
                PublishDate = commentDto.PublishDate
            };
        }
    }
}
