using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDataAccess.Models
{
    [Table("Address")]
    public class Address
    {
        [Column(Order = 1)]
        public int Id { get; set; }
        public string Address1 { get; set; }
        [Column(Order = 3)]
        public string Address2 { get; set; }
        public string Village { get; set; }
        public string Mandal { get; set; }
        public string District { get; set; }
        public string State { get; set; }

        [Column("Postal Code", Order = 5)]
        public int PostalCode { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
