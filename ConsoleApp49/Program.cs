using System;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("skriv in ett namn");
                names[i] = Console.ReadLine();
               
            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(names[j]);
            }

        }
    }
}