using System.Text.Json.Serialization;

namespace EjercicioCapas.Bussiness.Entities
{
    public class Book
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        public string Description { get; set; }
        public int AutorId { get; set; }

        public Autor? Autor { get; set; }

        public Book(int Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }

        public Book() { }

        //[JsonIgnore]
        //public ICollection<Reservation> Reservations { get; set; }
    }
}
