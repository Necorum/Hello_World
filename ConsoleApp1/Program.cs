using System;

namespace Hello_World
{
    class Program
    {
        private static string inPut;
        private static bool trueFalse = false;
        private static int count;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Type Hello World");
                inPut = Console.ReadLine();

                if (inPut == "Hello World")
                {
                    trueFalse = true;
                    if (trueFalse == true)
                    {
                        Console.WriteLine("You can follow instructions");
                        Console.WriteLine("Press any key to quit");
                        Console.ReadLine();
                    }
                }
                else
                {
                    count++;
                    if (count == 5)
                    {
                        trueFalse = true;
                        Console.WriteLine("I give up");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadLine();
                    }
                }
            }
            while (trueFalse == false);
        }

        

        private void World()
        {
            
        }
    }
}
