using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Dtos
{
    public class OrderCreateDto
    {
        [Required]
        public int BusinessID {get; set;}

        [Required]
        public int Quantity {get; set;}

        [Required]
        public float Length {get; set;}

        [Required]
        public string Size {get; set;}
    }
}