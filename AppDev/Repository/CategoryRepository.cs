using AppDev.Data;
using AppDev.Models;
using AppDev.Repository.IRepository;

namespace AppDev.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public void Update(Category entity)
        {
            _dbContext.Categories.Update(entity);
        }
    }
}
