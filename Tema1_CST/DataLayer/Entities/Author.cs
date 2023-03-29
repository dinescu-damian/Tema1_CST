namespace Tema1_CST.DataLayer.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public string? ProfileImageUrl { get; set; }

        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
