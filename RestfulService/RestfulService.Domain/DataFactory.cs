/************************************************
*Author: KIM
*Create Time: 10/6/2016 15:42:29
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
    public class DataFactory
    {
        private static IList<Product> _products;
        public static IList<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new List<Product>
                    {
                        new Product{ Id = Guid.NewGuid(), Name="Kayak", Description="A boat for one person", Category="Watersports", Price=275 },
                        new Product{ Id = Guid.NewGuid(), Name="Lifejacket", Description="Protective and fashionable", Category="Watersports", Price=48.95 },
                        new Product{ Id = Guid.NewGuid(), Name="Soccer Ball", Description="FIFA-approved size and weight", Category="Soccer", Price=19.5 },
                        new Product{ Id = Guid.NewGuid(), Name="Corner Flags", Description="Give your playing field a professional touch", Category="Soccer", Price=34.95 },
                        new Product{ Id = Guid.NewGuid(), Name="Stadium", Description="Flat-packed 35,000-seat stadium", Category="Soccer", Price=79500.00 },
                        new Product{ Id = Guid.NewGuid(), Name="Thinking Cap", Description="Improve your brain efficiency by 75%", Category="Chess", Price=16 },
                        new Product{ Id = Guid.NewGuid(), Name="Unsteady Chair", Description="Secretly give your opponent a disadvantage", Category="Chess", Price=29.95 },
                        new Product{ Id = Guid.NewGuid(), Name="Human Chess Board", Description="A fun game for the family", Category="Chess", Price=75 },
                        new Product{ Id = Guid.NewGuid(), Name="Bling-Bling King", Description="Gold-plated, diamond-studded King", Category="Chess", Price=1200 },
                    };
                }
                return _products;
            }
        }

        private static IList<Order> _orders;
        public static IList<Order> Orders
        {
            get
            {
                if(_orders == null)
                {
                    _orders = new List<Order>();
                }
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        private static IList<User> _users;
        public static IList<User> Users
        {
            get
            {
                if(_users == null)
                {
                    _users = new List<User>();
                }
                return _users;
            }
            set
            {
                _users = value;
            }
        }
    }
}
