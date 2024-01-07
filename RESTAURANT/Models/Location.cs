using System.ComponentModel.DataAnnotations;
namespace RESTAURANT.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

    }
}
