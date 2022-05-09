using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\KristinaMilistver\Kool\Samples\WishList2";
            string fileName = @"\\wishlist2.txt";

            string[] arrayfromfile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayfromfile.ToList<string>();

            bool loopActive = true;


           while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N: ");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
               {
                Console.WriteLine("Enter your wish:");
                string userwish = Console.ReadLine();
                myWishList.Add(userwish);
               }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            
            }

            Console.Clear();

            foreach(string wish in myWishList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);

        }
    }
}
