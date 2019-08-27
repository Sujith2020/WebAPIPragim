using DairyDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DairyDataAccess.Repositories
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            SwarnaContext swarnacontext = new SwarnaContext();
            List<Product> products = new  List<Product>();
            products = swarnacontext.Products.ToList();
            return products;
        }

        public Product GetProduct(int id)
        {
       
            Product product = new Product();
            product = GetProducts().Where(x => x.Id == id).FirstOrDefault();
            return product;
        }

        public Product AddProduct(Product prod)
        {

            using (var swarnacontext = new SwarnaContext())
            {
                swarnacontext.Products.Add(prod);
                swarnacontext.SaveChanges();
                return prod;
            }

        }

        public void UpdateProduct(int id, Product product)
        {
            using (var swarnacontext = new SwarnaContext())
            {
                swarnacontext.Entry(product).State = EntityState.Modified;
                try
                {
                    swarnacontext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(id))
                    {
                        //return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        public Product DeleteProduct(int id)
        {
            SwarnaContext swarnacontext = new SwarnaContext();
            Product product = swarnacontext.Products.Find(id);
            if (product == null)
            {
                //return NotFound();
            }

            swarnacontext.Products.Remove(product);
            swarnacontext.SaveChanges();
            return product;
        }

        private bool ProductExists(int id)
        {
            SwarnaContext swarnacontext = new SwarnaContext();
            return swarnacontext.Products.Count(e => e.Id == id) > 0;
        }
    }
}
