using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\KristinaMilistver\Kool\Samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayfromfile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayfromfile.ToList<string>();

            bool loopActive = true;


            while (loopActive)
            {
                Console.WriteLine("Would you like to add an item to your shopping list? Y/N: ");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string useritem = Console.ReadLine();
                    myShoppingList.Add(useritem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Good shopping!");
                }


            }

            Console.Clear();

            foreach (string item in myShoppingList)
            {
                Console.WriteLine($"Your item: {item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
