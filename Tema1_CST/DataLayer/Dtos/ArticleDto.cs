namespace Tema1_CST.DataLayer.Dtos
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Guid AuthorId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public List<CommentDto> Comments { get; set; } = new List<CommentDto>();
    }
}
