using Tema1_CST.DataLayer.Dtos;
using Tema1_CST.DataLayer.Entities;

namespace Tema1_CST.DataLayer.Mapping
{
    public static class AuthorMappingExtensions
    {
        public static AuthorDto ToDto(this Author author)
        {
            return new AuthorDto
            {
                Id = author.Id,
                Name = author.Name,
                Email = author.Email,
                Telephone = author.Telephone,
                Bio = author.Bio,
                ProfileImageUrl = author.ProfileImageUrl,
                Articles = author.Articles.Select(a => a.ToDto()).ToList()
            };
        }

        public static List<AuthorDto> ToDtos(this List<Author> authors)
        {
            return authors.Select(a => a.ToDto()).ToList();
        }

        public static Author ToEntity(this AuthorDto authorDto)
        {
            return new Author
            {
                Id = authorDto.Id,
                Name = authorDto.Name,
                Email = authorDto.Email,
                Telephone = authorDto.Telephone,
                Bio = authorDto.Bio,
                ProfileImageUrl = authorDto.ProfileImageUrl,
                Articles = authorDto.Articles.Select(a => a.ToEntity()).ToList()
            };
        }
    }
}
