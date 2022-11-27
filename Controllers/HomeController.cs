using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderService.Dtos;
using OrderService.Models;
using OrderService.Repos;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class HomeController : ControllerBase
    {
        private readonly IOrderRepo _repo;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public HomeController(IOrderRepo repo, ILogger<HomeController> logger, IMapper mapper)
        {
            _repo = repo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{businessID}")]
        public ActionResult<IEnumerable<Order>> GetOrders(int businessID)
        {
            return _repo.GetOrders(businessID).ToList();
        }

        [HttpPost]
        public ActionResult<OrderCreateMessage> CreateOrder(OrderCreateDto order)
        {
            Stack stackTransferable = new Stack()
            {
                Quantity = order.Quantity,
                Length = order.Length,
                Size = order.Size
            };

            Order orderTransferable = new Order()
            {
                ReceivedDate = DateTime.Now,
                EstimatedFulfillment = DateTime.Now,
                IsFulfilled = false,
                Stack = stackTransferable,
                //Business = order.BusinessID.
            };

            _repo.CreateOrder(orderTransferable);
            _repo.SaveChanges();

            OrderCreateMessage message = new OrderCreateMessage()
            {
                Message = "Success",
                OrderNumber = orderTransferable.ID
            };
            
            return message;
        }

    }
}