using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces.Services
{
    public interface IBookService : ICrudService<Book>
    {
    }
}
