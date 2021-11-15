using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Models
{
    public class Person : IComparable
    {
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Range(0,150)]
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is null)
            {
                return 1;
            }

            if (obj is not Person otherPerson)
            {
                throw new ArgumentException("Object is not a Person");
            }

            return Age.CompareTo(otherPerson.Age);
        }
    }
}
