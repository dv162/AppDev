using AppDev.Data;
using AppDev.Repository.IRepository;
using AppDev.Repository;
using AppDev.Data;
using AppDev.Repository.IRepository;

namespace AppDev.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
        public ApplicationDbContext _dbContext;
        public ICategoryRepository CategoryRepository { get; private set; }

        public IBookRepository BookRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            CategoryRepository = new CategoryRepository(dbContext);
            BookRepository = new BookRepository(dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}