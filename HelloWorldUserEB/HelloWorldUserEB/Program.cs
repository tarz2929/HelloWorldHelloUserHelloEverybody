using System;

namespace HelloWorldUserEB
{
    public class Program
    {
        public static ConsoleKey keyPressed;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress the Enter key to end this program...");
                keyPressed = Console.ReadKey().Key;
            }


            }
        }
}
