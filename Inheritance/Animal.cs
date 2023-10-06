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

        /*        public void ReproduceSexually()
                {
                    Console.WriteLine($"All animals reproduce sexually: 'It takes two to tango.'");
                }*/

        /*        public void MultiCellular()
                {
                    Console.WriteLine($"All animals are genetically made up of many cells.");
                }*/
        public bool Multicellular { get; set; }

   /*     public void CanMove()
        {
            Console.WriteLine($"All animals are mobile, some move more than others at different frequencies, intensities, and distances.");
        }*/

        public int Legs { get; set; }

    /*    public void HuntForFood()
        {
            Console.WriteLine($"All animals are hunt for their food because they cannot independently make it. Whether they eat plants or other animals, they must hunt for consumption to stay alive.");
        }*/

        public bool HuntsFood { get; set; }
/*        public void NeedsSleep()
        {
            Console.WriteLine($"All animals are need sleep to recover their energy levels and to live.");
        }
*/
        public int Age {  get; set; } 
    }
}
