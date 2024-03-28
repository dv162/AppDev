using AppDev.Models;

namespace AppDev.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        void Update(Book entity);

    }
}
