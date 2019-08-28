using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDataAccess.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string  Username { get; set; }
        public string Password { get; set; }
        public int EmpId { get; set; }
        //[ForeignKey("EmpId")]
        public Employee employee{ get; set; }

    // forcepasswordchange
    // 
}
}
