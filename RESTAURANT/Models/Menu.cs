using System.ComponentModel.DataAnnotations;
namespace RESTAURANT.Models
{
    public class Menu
    {
        public int MenuId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Details { get; set; }



    }
}
