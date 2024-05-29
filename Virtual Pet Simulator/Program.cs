using System;

namespace VirtualPet
{
    class Pet
    {
        static void Main(string[] args)
        { // Variable declaration
            string petType = " ";
            string petName = " ";
            int hunger = 6;
            int happiness = 7;
            int health = 8;

            // Pet Creation
            Console.WriteLine("Please choose a pet type: ");
            Console.WriteLine("Cat");
            Console.WriteLine("Dog");
            Console.WriteLine("Rabbit");
            petType = Console.ReadLine();

            Console.WriteLine("You have choosen a" + " " + petType + "." + " " + "what would you like to name your pet?");
            petName = Console.ReadLine();

            Console.WriteLine("/nWelcome," + " " + petName + "." + "Lets take good care of him");

        }
    }
}
