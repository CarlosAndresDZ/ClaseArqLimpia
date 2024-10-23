using EjercicioCapas.Bussiness.Entities;

namespace EjercicioCapas.Data.Repositories
{
    public class AutorRepository
    {
        private readonly AppDBContext _dbContext;
        public AutorRepository(AppDBContext dbContext) { 
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public int Insert(Autor autor) { 
            _dbContext.Autores.Add(autor);
            var result = _dbContext.SaveChanges(); //commit
            return result;
        }
        public Autor FindById(int id)
        {
            var result = _dbContext.Autores.Find(id);
            if (result != null) { return result; }
            throw new Exception($"User {id} was not found!.");
        }

        public List<Autor> GetAll()
        {
            return _dbContext.Autores.ToList();
        }
    }
}
