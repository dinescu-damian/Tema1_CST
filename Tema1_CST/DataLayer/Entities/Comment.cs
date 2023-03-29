namespace Tema1_CST.DataLayer.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public Article Article { get; set; } = null!;
        public string CommentAuthor { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
    }
}
