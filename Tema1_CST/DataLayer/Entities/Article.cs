namespace Tema1_CST.DataLayer.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Guid AuthorId { get; set; }
        public Author Author { get; set; } = null!;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public List<Comment> Comments { get; set; } = new List<Comment>();
        
    }
}
