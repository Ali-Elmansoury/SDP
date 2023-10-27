﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class LV_Shirt : Shirt
    {
        public void Material()
        {
            Console.WriteLine("LV shirts are made from various materials. Choose an option:\n");
            Console.WriteLine("1. Cotton");
            Console.WriteLine("2. Silk");
            Console.WriteLine("3. Linen");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("LV shirts are made of cotton.");
                    break;
                case 2:
                    Console.WriteLine("LV shirts are made of silk.");
                    break;
                case 3:
                    Console.WriteLine("LV shirts are made of linen.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Style()
        {
            Console.WriteLine("LV shirts have a chiffon style.");
        }

        public void CollarType()
        {
            Console.WriteLine("LV shirts have different collar types. Choose an option:\n");
            Console.WriteLine("1. Spread collar");
            Console.WriteLine("2. Point collar");
            Console.WriteLine("3. Button-down collar");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("LV shirts have a spread collar.");
                    break;
                case 2:
                    Console.WriteLine("LV shirts have a point collar.");
                    break;
                case 3:
                    Console.WriteLine("LV shirts have a button-down collar.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

}
