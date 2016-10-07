/************************************************
*Author: KIM
*Create Time: 10/7/2016 12:32:41
*CLR Version: 4.0.30319.42000
*Description:
*
*Update History:
*
***********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulService.Domain
{
    public class Order
    {
        public Order()
        {
            products = new List<Product>();
        }

        public Guid Id { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public bool giftWrap { get; set; }
        public IList<Product> products { get; set; }
    }
}
