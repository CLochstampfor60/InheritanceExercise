using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        /*public string LaysEggs { get; set; }*/
        public void LaysEggs()
        {
            Console.WriteLine($"Birds lay eggs during the procreation process,");
        }

        /*public bool CoveredInFeathers { get; set; }*/
        public void HasFeathers()
        {
            Console.WriteLine($"Birds are completely covered with feathers,");
        }

        /*public bool WarmBlooded { get; set; }*/
        public void WarmBlooded()
        {
            Console.WriteLine($"Birds are warm-blooded animals,");
        }

        /* public int NumberOfLegs { get; set; }*/
        public void HasLegs()
        {
            Console.WriteLine($"Birds have two legs,");
        }

        /*  public bool Wings { get; set; }*/
        public void HasWings()
        {
            Console.WriteLine($"Birds have two wings,");
        }
    }
}
