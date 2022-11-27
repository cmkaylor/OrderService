using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Business
    {
        [Key]
        [Required]
        public int ID {get; set;}

        [Required]
        public string Name {get; set;}

        [Required]
        public string Address {get; set;}
    }
}