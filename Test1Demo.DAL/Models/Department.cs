using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Demo.DAL.Models
{
    internal class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required!")]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
