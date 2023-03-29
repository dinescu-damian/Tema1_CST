namespace Tema1_CST.DataLayer.Dtos
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public string? ProfileImageUrl { get; set; }

        public List<ArticleDto> Articles { get; set; } = new List<ArticleDto>();
    }
}
