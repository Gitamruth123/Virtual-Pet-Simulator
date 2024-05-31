using System;

namespace VirtualPet
{
    class Pet
    {
        static void Main(string[] args)
        { // Variable declaration
            string petType = " ";
            string petName = " ";
            int hunger =8;
            int happiness = 4;
            int health = 1;

            // Pet Creation
            Console.WriteLine("Please choose a pet type: ");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            petType = Console.ReadLine();
            if (petType == "1")
            {
                Console.WriteLine("You have choosen a Cat, what would you like to name your pet?");
            }else if (petType == "2") { Console.WriteLine("You have choosen a Dog, what would you like to name your pet?"); }
            else if (petType == "3") { Console.WriteLine("You have choosen a Rabbit, what would you like to name your pet?"); }
            else
            {
                Console.WriteLine("Invalid option Selected");
            }
            petName = Console.ReadLine();

            Console.WriteLine("\nWelcome," + " " + petName + "." + "Lets take good care of him");

            // Game start here
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("             Pet's status               ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("              Hunger:" + hunger );
                Console.WriteLine("           Happiness:" + happiness);
                Console.WriteLine("              Health:" + health);
                Console.WriteLine("\n");
              
                // Pet Care Actions
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("              Main Menu                 ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("           1.Feed "+ petName);
                Console.WriteLine("           2.Play with "+petName);
                Console.WriteLine("           3.Let "+petName+" Rest");
                Console.WriteLine("           4.Exit");
                Console.WriteLine("----------------------------------------");
                string action = Console.ReadLine();

                
                if (action == "1")
                {
                    if (hunger > 0)
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
                    else
                    {
                        Console.WriteLine(petName + " is full. he cant eat food ");
                    }
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
                        if (health != 0)
                        {
                            Console.WriteLine(petName + " is playing happily. Increases happiness,slightly increases hunger ");
                        }
                   
                    
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

                if (health == 0)
                {
                    Console.WriteLine(petName + " has died due to poor health.End of the game.");
                    break;
                }
                else
                {
                    if (happiness == 10)
                    {
                        Console.WriteLine(petName + " is very happy. End of the game.");
                        break;
                    }
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
                        Console.WriteLine(petName + " is very unhappy! ");
                    }
                }
                

               

            }
        }
    }
}
