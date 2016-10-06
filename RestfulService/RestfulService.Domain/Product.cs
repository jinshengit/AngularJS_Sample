/************************************************
*Author: KIM
*Create Time: 10/6/2016 15:41:46
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
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
