using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common
        public Animal() { }

        public string Name { get; set; }

        public bool Multicellular { get; set; }

        public int Legs { get; set; }

        public bool HuntsFood { get; set; }

        public int Age {  get; set; } 
    }
}
