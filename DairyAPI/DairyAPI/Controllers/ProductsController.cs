using DairyDataAccess.Models;
using DairyDataAccess;
using DairyDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DairyAPI.Controllers
{
    public class ProductsController : ApiController
    {
        ProductRepository prodrep = new ProductRepository();
        [RequireHttps]
        public IEnumerable<Product> GetProducts()
        {
            List <Product> products =  prodrep.GetProducts();
            return products;
        }
        [Route("{id:int}/details")]
        public IHttpActionResult GetProducts(int id)
        {
            Product prod = new Product();
            prod = prodrep.GetProduct(id);
            return Ok(prod);
        }

        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            prodrep.AddProduct(product);
            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        [HttpPut]
        public IHttpActionResult PutProduct([FromUri]int id,[FromBody] Product product)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            if (id != product.Id)
            {
                return BadRequest();
            }

            prodrep.UpdateProduct(id,product);

            return StatusCode(HttpStatusCode.OK);

        }

        public IHttpActionResult DeleteProduct(int id)
        {
            Product prod = new Product();
            prodrep.DeleteProduct(id);
            return Ok(prod);
        }
    }
}
