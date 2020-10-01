using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
            {
                message = "You won a Car!";
            }
            else if (userValue == "2")
            {
                message = "You won a Boat!";                
            }
            else if (userValue == "3")
            {
                message = "You won a new Cat!";
            }
            else
            {
                message = "Sorry I do not understand that command ";
                message += "You Lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
