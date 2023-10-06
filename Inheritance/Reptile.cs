using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    {

        /*public bool LaysEggsOnLand { get; set; }*/
        public void LaysEggsOnLand()
        {
            Console.WriteLine($"Reptiles lay eggs, but only on land. Never in the water.");
        }

        /*public bool CoveredInScales { get; set; }*/
        public void CoveredInScales()
        {
            Console.WriteLine($"Reptiles are completely covered in scales.");
        }

        /* public bool ColdBlooded { get; set; }*/
        public void ColdBlooded()
        {
            Console.WriteLine($"Reptiles are cold-blooded creatures, the opposite of many other animal species.");
        }


        /*public int NumberOfLegs { get; set; }*/
        public void HaveLegs()
        {
            Console.WriteLine($"Reptiles usually have two legs, but sometimes have four legs.");
        }

    }
}
