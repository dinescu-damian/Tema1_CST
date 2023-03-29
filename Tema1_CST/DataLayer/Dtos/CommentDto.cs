namespace Tema1_CST.DataLayer.Dtos
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public string CommentAuthor { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
    }
}
