/************************************************
*Author: KIM
*Create Time: 10/7/2016 13:53:56
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
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
