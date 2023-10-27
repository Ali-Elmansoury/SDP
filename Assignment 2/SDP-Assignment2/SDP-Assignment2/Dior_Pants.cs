using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class Dior_Pants : Pants
    {
        public void Material()
        {
            Console.WriteLine("Dior pants are made from dressy materials.");
        }

        public void Color()
        {
            Console.WriteLine("Dior pants come in different colors. Choose an option:\n");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. Navy");
            Console.WriteLine("3. Gray");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You've chosen Black color.");
                    break;
                case 2:
                    Console.WriteLine("You've chosen Navy color.");
                    break;
                case 3:
                    Console.WriteLine("You've chosen Gray color.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void HasZipper()
        {
            Console.WriteLine("Dior pants all have zippers and a top button.");
        }

        public void HasPockets()
        {
            Console.WriteLine("Dior pants have pockets. Choose an option:\n");
            Console.WriteLine("1. Front pockets");
            Console.WriteLine("2. Back pockets");
            Console.WriteLine("3. Front and back pockets");
            Console.WriteLine("4. No pockets");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Dior pants have front pockets.");
                    break;
                case 2:
                    Console.WriteLine("Dior pants have back pockets.");
                    break;
                case 3:
                    Console.WriteLine("Dior pants have both front and back pockets.");
                    break;
                case 4:
                    Console.WriteLine("Dior pants have no pockets.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Size()
        {
            Console.WriteLine("Dior pants come in different sizes. Choose an option:\n");
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
    }

}
