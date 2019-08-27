using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDataAccess.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product  product { get; set; }
        public int Quantity { get; set; }
        public int DealerId { get; set; }
        [ForeignKey("DealerId")]
        public Dealer dealer { get; set; }
        public string PaymentMode { get; set; }
        public string DeliveryTypes { get; set; }
        public decimal TotalBill { get; set; }
        public DateTime DueDate { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
