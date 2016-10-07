/************************************************
*Author: KIM
*Create Time: 10/6/2016 15:48:05
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
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RestfulService.API.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return DataFactory.Products;
        }

        public Product GetProduct(string id)
        {
            Guid guid = Guid.Parse(id);
            Product product = DataFactory.Products.FirstOrDefault(p => p.Id.Equals(guid));
            if (null == product)
            {
                HttpContext.Current.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            return product;
        }

        [HttpPost]
        public void CreateProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            DataFactory.Products.Add(product);
        }

        [HttpPut]
        public void UpdateProduct(Product product)
        {
            this.Delete(product.Id.ToString());
            DataFactory.Products.Add(product);
        }

        [HttpDelete]
        public void Delete(string id)
        {
            Product product = this.GetProduct(id);
            if (null != product)
            {
                DataFactory.Products.Remove(product);
            }
        }

        //[HttpGet]
        //public string SimpleString()
        //{
        //    return "This is for action invoke";
        //}
    }
}