using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Models
{
    public class Person
    {
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Range(0,150)]
        public int Age { get; set; }
    }
}
