using AppDev.Data;
using AppDev.Models;
using AppDev.Repository.IRepository;

namespace AppDev.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BookRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public void Update(Book entity)
        {
            _dbContext.Books.Update(entity);
        }
    }
}
