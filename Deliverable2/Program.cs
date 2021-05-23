using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hello = 0;
            int sup = 0;
            int helloThere = 0;
           

            bool isValid;
            do
            {
                Console.WriteLine("What would you like to say to the bot?");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "hello")
                {
                    hello++;
                    if (hello > 1)
                    {
                        Console.WriteLine("I'm sorry but you have already said that.");
                    }
                    else
                    {
                        Console.WriteLine("Hi good to see you");
                    }
                }
                else if (userInput == "sup")
                {
                    sup++;
                    if (sup > 1)
                    {
                        Console.WriteLine("I'm sorry but you have already said that.");
                    }
                    else
                    {
                        Console.WriteLine("I am good");
                    }
                }
                else if (userInput == "hello there")
                {
                    helloThere++;
                    if (helloThere > 1)
                    {
                        Console.WriteLine("I'm sorry but you have already said that.");
                    }
                    else
                    {
                        Console.WriteLine("General Kenobi");
                    }
                }

                isValid = userInput == "bye";

            } while (!isValid);

            Console.WriteLine("Good bye");
        }
    }
}
