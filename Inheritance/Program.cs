using System;

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
            var BaldEagle = new Bird();

            Console.Write("\nBald Eagles are birds that share the following biological and actionable traits with other birds:\n");
            BaldEagle.HasLegs();
            BaldEagle.WarmBlooded();
            BaldEagle.HasFeathers();
            BaldEagle.HasWings();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var KomodoDragon = new Reptile();

            Console.Write("\nKomodo Dragons are reptiles share the following biological and actionable traits with other reptiles:\n");
            KomodoDragon.ColdBlooded();
            KomodoDragon.CoveredInScales();
            KomodoDragon.LaysEggsOnLand();
            KomodoDragon.HaveLegs();
        }
    }
}
