using System;

namespace VirtualPet
{
    class Pet
    {
        static void Main(string[] args)
        { // Variable declaration
            string petType = " ";
            string petName = " ";
            int hunger = 5;
            int happiness = 6;
            int health = 7;

            // Pet Creation
            Console.WriteLine("Please choose a pet type: ");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            petType = Console.ReadLine();

            Console.WriteLine("You have choosen a" + " " + petType + "." + " " + "what would you like to name your pet?");
            petName = Console.ReadLine();

            Console.WriteLine("\nWelcome," + " " + petName + "." + "Lets take good care of him");

            // Game start here
            while (true)
            {
                // To display Pet status
                Console.WriteLine("\nPet's status - Hunger:" + hunger + " " + "Happiness:" + happiness + " " + "Health:" + health);

                // Pet Care Actions
                
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Exit");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    //Feed
                    hunger -= 2;
                    if (hunger < 0)
                    {
                        hunger = 0;
                    }
                    health += 1;
                    if (health > 10)
                    {
                        health = 10;

                    }

                    Console.WriteLine(petName + " has been fed. Decreases hunger,slightly increases health ");
                }
                //Play

                else if (action == "2")
                {
                    happiness += 2;
                    if (happiness > 10)
                    {
                        happiness = 10;
                    }
                    hunger += 1;
                    if (hunger > 10)
                    {
                        hunger = 10;
                    }
                    Console.WriteLine(petName + " is playing happily. Increases happiness,slightly increases hunger ");
                }
                // Rest
                else if (action == "3")
                {
                    health += 2;
                    if (health > 10)
                    {
                        health = 10;
                    }
                    happiness -= 1;
                    if (happiness < 0)
                    {
                        happiness = 0;
                    }
                    Console.WriteLine(petName + " is resting. Improves health,decreases happiness slightly ");
                } 
                // Exit

                else if (action == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.Please choose again.");
                }
                // Time based changes
                /*hunger += 1;
                if (hunger > 10)
                {
                    hunger = 10;
                }
                //Action play

                happiness -= 1;
                if(happiness < 0)
                {
                    happiness = 0;
                }*/
                //Status checking

                if (hunger == 10)
                {
                    health -= 1;
                    if (health < 0)
                    {
                        health = 0;
                    }
                    Console.WriteLine(petName + " is very hungry! Health is decreasing.");
                }
                if (happiness == 0)
                {
                    health -= 1;
                    if (health < 0)
                    {
                        health = 0;
                    }
                    Console.WriteLine(petName + " is very unhappy! Health is decreasing.");
                }
                //Warning

                if (health == 0)
                {
                    Console.WriteLine(petName + " has died due to poor health.End of the game.");
                    break;
                }

            }
        }
    }
}
