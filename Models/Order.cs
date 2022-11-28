using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderService.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int ID {get; set;}

        [Required]
        public DateTime ReceivedDate {get; set;}
        public DateTime EstimatedFulfillment {get; set;}

        [Required]
        public bool IsFulfilled {get; set;} 

        [Required]
        public virtual Stack Stack {get; set;}
        
        [Display(Name = "Business")]
        [Required]
        public virtual int BusinessID {get; set;}

        [ForeignKey("BusinessID")] 
        public virtual Business Business {get; set;}
    }
}