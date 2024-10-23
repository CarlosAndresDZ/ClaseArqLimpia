using Microsoft.EntityFrameworkCore;
using EjercicioCapas.Bussiness.Entities;

namespace EjercicioCapas.Data
{
    /* Esta clase representa al contexto (Conexion a la BD)   */
    public class AppDBContext : DbContext
    {
        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        /* Declarando Entidades */
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseMySQL("server=localhost; port=3306");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Configurando PK de Tablas */
            modelBuilder.Entity<Autor>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Book>().Property(t => t.Id).ValueGeneratedOnAdd();


            /* FK */
            modelBuilder.Entity<Autor>()
                .HasMany(t => t.Books)
                .WithOne(a => a.Autor)
                .HasForeignKey(a=> a.AutorId);

            base.OnModelCreating(modelBuilder);
        }
    }

}
