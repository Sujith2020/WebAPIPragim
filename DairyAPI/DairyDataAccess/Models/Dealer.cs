using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDataAccess.Models
{
    public class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Contact { get; set; }
        [Column("Alternate Contact")]
        public int AlternateContact { get; set; }

        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
