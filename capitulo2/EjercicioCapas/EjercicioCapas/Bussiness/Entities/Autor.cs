using System.Globalization;
using System.Text.Json.Serialization;

namespace EjercicioCapas.Bussiness.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }


        public Autor(int Id, string Name, string Nationality) {
            this.Id = Id;
            this.Name = Name;
            this.Nationality = Nationality;
        }

        public Autor() { }

        [JsonIgnore]
        public ICollection<Book> Books { get; set; }
    }
}
