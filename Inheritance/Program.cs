using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
              var 
             * Creatively display the class member values 
             */
            Bird yugiohRa = new Bird()
            {
                Name = "Wing Dragon of Ra",
                Multicellular = true,
                Legs = 2,
                HuntsFood = true,
                Age = 10000000,
                LaysEggs = 0,
                FeatherColor = "gold",
                WarmBlooded = true,
                Beak = true,
                Wings = 2,
                OriginLocation = "Eqypt",
            };

            Console.WriteLine($"The {yugiohRa.Name} is a terrible force, originating all the way back to {yugiohRa.OriginLocation}, {yugiohRa.Age} years ago.");
            Console.WriteLine($"The {yugiohRa.Name} is a magnificent creature, a god-bird of the sky. It has {yugiohRa.Legs} legs and {yugiohRa.Wings} wings, and a radiant {yugiohRa.FeatherColor} color feather coat. Our scientists have confirmed the following speculations too:\n Beak: {yugiohRa.Beak}, \n Warmblooded: {yugiohRa.WarmBlooded},\n Hunts For Food: {yugiohRa.HuntsFood}, and \n Does it lay eggs: {yugiohRa.LaysEggs}.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile dragon = new Reptile()
            {
                Name = "Shenron",
                Multicellular = true,
                Legs = 4,
                HuntsFood = false,
                Age = 320000000,
                LaysEggsOnLand = false,
                ScaleColor = "green",
                ColdBlooded = true,
                TongueSize = "large",
                OriginLocation = "God of Earth, summoned through the Dragonballs"
            };

            Console.WriteLine($"\nThe reptie dragon {dragon.Name}, is {dragon.Age} years old, originating from the {dragon.OriginLocation}.");
            Console.WriteLine($"\n{dragon.Name} has {dragon.Legs} legs, a {dragon.TongueSize} tongue, confirmed {dragon.ColdBlooded} coldblooded, and he has a {dragon.ScaleColor} scale color.");
           
        }
    }
}
