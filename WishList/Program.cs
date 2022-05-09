﻿using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("Coffee machine");
            myWishList.Add("New pair of socks");
            myWishList.Add("Box of chocolate");
            myWishList.Add("New pillow");

            Console.WriteLine(myWishList.Count);

            foreach (string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
