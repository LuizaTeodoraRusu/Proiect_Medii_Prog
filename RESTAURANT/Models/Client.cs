using System.ComponentModel.DataAnnotations;

namespace RESTAURANT.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string? Nume { get; set; }


        public string? Prenume { get; set; }

        public string? Adresa { get; set; }
        public string Email { get; set; }
        public string? Telefon { get; set; }

        //public ICollection<Reservation>? Reservations{ get; set; }

        //public ICollection<Menu>? Menus { get; set; }
    }
}

