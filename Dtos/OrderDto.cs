using System;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class OrderDto
    {
        public int ID {get; set;}
        public DateTime ReceivedDate {get; set;}
        public DateTime EstimatedFulfillment {get; set;}
        public bool IsFulfilled {get; set;} 
    }
}