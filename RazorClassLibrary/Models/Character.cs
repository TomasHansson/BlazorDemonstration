using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Models
{
    public class Character : IComparable
    {
        public string Hero { get; set; }
        public string Archetype { get; set; }
        public string Class { get; set; }
        public string Subclass { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is null)
            {
                return 1;
            }

            if (obj is not Character otherCharacter)
            {
                throw new ArgumentException("Object is not a Character");
            }
                
            return Hero.CompareTo(otherCharacter.Hero);
        }
    }
}
