using DairyDataAccess.Models;
using DairyDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DairyAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Product> Get()
        {
            //return new string[] { "The permanent members of the United Nations Security Council (also known as the Permanent Five, Big Five, or P5) are " +
            //    "the five states which the UN Charter of 1945 grants a permanent seat on the UN Security Council: China (formerly the Republic of China), " +
            //    "France, Russia (formerly the Soviet Union), the United Kingdom, and the United States. These countries were all allies in World War II, which turned " +
            //    "out victorious. They are also all nuclear weapons states. A total of 15 UN member states serve on the UNSC, the remainder of which are elected. Any one " +
            //    "of the five permanent members have the power of veto, which enables them to prevent the adoption of any draft Council resolution, regardless of its level " +
            //    "of international support", "value2 type" };
            List<Product> products = new List<Product>();


            //ProductRepository prodRepository = new ProductRepository();



            Product product = new Product() { Name = "SwarnaMilk", Type ="Milk", Fat = 08.09M, ManufacturedType = "Packet", Measure="mL", Price = 19, Quantity =450  };
            products.Add(product);
            //return products;


            string ConnectionString = "Server=SUJITH-HP-ABEAS;Database=SwarnaProducts;Trusted_Connection=True;";
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = ConnectionString;
            // Creating a SQL string and data adapter object
            string sql = "select * from Product";
            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, myConnection);
            // Construct the dataset and fill it
            DataTable myDataSet = new DataTable("Student");
            myAdapter.Fill(myDataSet);
            // Bind the List box to the Dataset

            return products;

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
