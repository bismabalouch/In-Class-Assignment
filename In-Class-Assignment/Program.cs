using System;

namespace In_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            try
            {
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name);
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Please enter your name correctly.");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }
        }
    }
}
