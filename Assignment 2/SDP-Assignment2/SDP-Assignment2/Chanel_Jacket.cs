using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class Chanel_Jacket : Jacket
    {
        public void Material()
        {
            Console.WriteLine("Chanel jackets are made from tailored materials.");
        }

        public void Size()
        {
            Console.WriteLine("Chanel jackets come in different sizes. Choose an option:\n");
            Console.WriteLine("1. Small");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Large");
            Console.WriteLine("4. XL");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You've chosen Small size.");
                    break;
                case 2:
                    Console.WriteLine("You've chosen Medium size.");
                    break;
                case 3:
                    Console.WriteLine("You've chosen Large size.");
                    break;
                case 4:
                    Console.WriteLine("You've chosen XL size.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Gender()
        {
            Console.WriteLine("Chanel jackets are designed for different genders. Choose an option:\n");
            Console.WriteLine("1. Men");
            Console.WriteLine("2. Women");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chanel jackets are available for men.");
                    break;
                case 2:
                    Console.WriteLine("Chanel jackets are available for women.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

}
