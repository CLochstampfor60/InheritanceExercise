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
        public int LaysEggs { get; set; }

        public string FeatherColor { get; set; }


        public bool WarmBlooded { get; set; }
 

        public bool Beak { get; set; }


        public bool Wings { get; set; }

        public Bird() { }

        public Bird(
            string name,
            bool multicellular,
            int legs,
            bool huntsFood,
            int age,
            int layseggs,
            string featherColor,
            bool warmBlooded,
            bool beak,
            bool wings
            )
        {
            Name = name;
            Multicellular = multicellular;
            Legs = legs;
            HuntsFood = huntsFood;
            Age = age;
            LaysEggs = layseggs;
            FeatherColor = featherColor;
            WarmBlooded = warmBlooded;
            Beak = beak;
            Wings = wings;
        }
    }
}
