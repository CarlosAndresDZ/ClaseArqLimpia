using EjercicioCapas.Bussiness.Entities;

namespace EjercicioCapas.Data.Repositories
{
    public class BookRepository
    {
        private readonly AppDBContext _dbContext;
        public BookRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Insert(Book book) { 
            _dbContext.Books.Add(book);
            var result=_dbContext.SaveChanges();
            return result;
        }

        public Book FindbyId(int id)
        {
            var book= _dbContext.Books.Find(id);
            return book != null ? book : throw new Exception($"no existe {book}");
        }

        public int Update(Book book) { 
            var rSearch=_dbContext.Books.Find(book.Id);
            if (rSearch != null)
            {
                _dbContext.Update(book);
                return _dbContext.SaveChanges();
            }
            throw new Exception($"no existe {book.Id}");
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.ToList();
        }
        //public List<Book> GetAvailable()
        //{
        //    return _dbContext.Books.Where(t=> t.Available).ToList();
        //}
    }
}
