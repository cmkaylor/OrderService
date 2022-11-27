using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Stack
    {
        [Key]
        [Required]
        public int ID {get; set;}

        [Required]
        public int Quantity {get; set;}

        [Required]
        public float Length {get; set;}

        [Required]
        public string Size {get; set;}
    }
}