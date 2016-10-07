/************************************************
*Author: KIM
*Create Time: 10/7/2016 12:36:57
*CLR Version: 4.0.30319.42000
*Description:
*
*Update History:
*
***********************************************/

using RestfulService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RestfulService.API.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrderController : ApiController
    {
        public IEnumerable<Order> GetOrders()
        {
            return DataFactory.Orders;
        }

        [HttpPost]
        public Order CreateOrder(Order order)
        {
            order.Id = Guid.NewGuid();
            DataFactory.Orders.Add(order);
            return order;
        }
    }
}