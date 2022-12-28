using System;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize player health
            int health = 100;

            // Main game loop
            while (health > 0)
            {
                // Display game state
                Console.WriteLine("Health: " + health);
                Console.WriteLine("You are standing in a dark forest. There is a path leading north and south.");

                // Prompt the player for a choice
                Console.Write("Do you want to go north or south? ");
                string choice = Console.ReadLine();

                // Process the player's choice
                if (choice.ToLower() == "north")
                {
                    Console.WriteLine("You decide to go north.");
                    Console.WriteLine("As you walk along the path, you see a clearing up ahead.");
                    Console.WriteLine("In the clearing, you see a beautiful waterfall.");
                    Console.WriteLine("You decide to take a break and rest by the waterfall.");
                    health += 20;
                }
                else if (choice.ToLower() == "south")
                {
                    Console.WriteLine("You decide to go south.");
                    Console.WriteLine("As you walk along the path, you see a clearing up ahead.");
                    Console.WriteLine("In the clearing, you see a fierce-looking bear.");
                    Console.WriteLine("The bear attacks you and you lose 20 health.");
                    health -= 20;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            // Game over
            Console.WriteLine("Game over. Your health has reached 0.");
        }
    }
}

