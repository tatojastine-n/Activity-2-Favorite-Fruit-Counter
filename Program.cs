using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Fruit_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];
            int appleCount = 0;

            Console.WriteLine("Enter your 5 favorite fruits (one at a time):");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write($"Fruit {i + 1}: ");
                string input = Console.ReadLine()?.Trim();

                fruits[i] = input?.ToLower();

                if (fruits[i] == "apple")
                {
                    appleCount++;
                }
            }
            Console.WriteLine("\nList of your favorite fruits:");
            
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine($"\nNumber of times 'apple' was entered: {appleCount}");
        }
    }
}
