/************************************************
*Author: KIM
*Create Time: 10/7/2016 14:13:40
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
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RestfulService.API.Controllers
{
    
    public class UserController : ApiController
    {
        [HttpPost]
        //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
        public HttpResponseMessage Login(User user)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.StatusCode = System.Net.HttpStatusCode.Accepted;
            if(!user.UserName.ToLower().Equals("admin"))
            {
                msg.StatusCode = System.Net.HttpStatusCode.NonAuthoritativeInformation;
            }

            if(!user.Password.Equals("admin"))
            {
                msg.StatusCode = System.Net.HttpStatusCode.Forbidden;
            }
            return msg;
        }
    }
}