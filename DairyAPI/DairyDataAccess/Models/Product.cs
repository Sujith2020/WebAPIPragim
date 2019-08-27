using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDataAccess.Models
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Fat { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string Measure { get; set; }
        public string ManufacturedType { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
