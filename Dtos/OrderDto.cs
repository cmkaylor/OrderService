using System;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class OrderDto
    {
        [Required]
        public DateTime ReceivedDate {get; set;}

        [Required]
        public DateTime EstimatedFulfillment {get; set;}

        [Required]
        public bool IsFulfilled {get; set;} 

        [Required]
        public virtual Stack Stack {get; set;}

        [Required]
        public virtual Business Business {get; set;}
    }
}