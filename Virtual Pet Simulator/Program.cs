using System;
using System.Data;

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

            Console.WriteLine("\nWelcome," + " " + petName + "." + "Lets take good care of him");

            // Game start here
            while (true)
            {
                // To display Pet status
                Console.WriteLine("\nPet's status -Hunger:" + hunger + " " + "Happiness:" + happiness + " " + "Health:" + health);

                // Pet Care Actions
                Console.WriteLine("\nChoose an action: 1.Feed 2.Play 3.Rest 4.Exit");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    //Feed
                    hunger -= 2;
                    if(hunger < 0)
                    {
                        hunger = 0;
                    }
                    health += 1;
                    if(health > 10)
                    {
                        health = 10;
   
                    }

                    Console.WriteLine(petName + " has been fed.");
                }
            }
        }
    }
}
