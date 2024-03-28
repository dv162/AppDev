using AppDev.Models;

namespace AppDev.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category entity);

    }
}
