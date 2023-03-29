using Tema1_CST.DataLayer.Entities;

namespace Tema1_CST.DataLayer.Repositories
{
    public class AuthorsRepository
    {
        private readonly DataContext _dataContext;
        public AuthorsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Author> GetAuthorByIdAsync(Guid id)
        {
            return await _dataContext.Authors
                .Include(a => a.Articles)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
