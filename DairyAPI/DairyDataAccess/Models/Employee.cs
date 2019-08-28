using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDataAccess.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        public string name { get; set; }
        public DateTime dateofbirth { get; set; }
        public int salary { get; set; }
        public string Gender { get; set; }
        //mobile
        //alternatemobile
        //address - link with address table
        //department
        //

    }
}
