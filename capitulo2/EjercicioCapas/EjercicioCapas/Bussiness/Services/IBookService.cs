using EjercicioCapas.Bussiness.Entities;
using EjercicioCapas.Data.DTO_s;

namespace EjercicioCapas.Bussiness.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        int Insert(BookDTO dto);
        List<Book> GetAvailableBooks();

    }
}
