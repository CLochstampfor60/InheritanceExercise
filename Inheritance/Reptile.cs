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

        public bool LaysEggsOnLand { get; set; }

        public string ScaleColor { get; set; }

        public bool ColdBlooded { get; set; }

        public string TongueSize { get; set; }

        public Reptile() { }

        public Reptile(
            string name, 
            bool multicellular,
            int legs,
            bool huntsFood,
            int age,
            bool laysEggsOnLand,
            string scaleColor,
            bool coldBlooded,
            string tongueSize
            ) 
        {
            Name = name;
            Multicellular = multicellular;
            Legs = legs;
            HuntsFood = huntsFood;
            Age = age;
            LaysEggsOnLand = laysEggsOnLand;
            ScaleColor = scaleColor;
            ColdBlooded = coldBlooded;
            TongueSize = tongueSize;
        }
    }
}
