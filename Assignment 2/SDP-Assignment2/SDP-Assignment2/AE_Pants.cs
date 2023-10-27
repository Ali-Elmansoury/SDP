using System;
using System.Collections.Generic;
using System.Text;

namespace SDP_Assignment2
{
    class AE_Pants : Pants
    {
        public void Color()
        {
            Console.WriteLine("AE pants are available in different colors. Choose an option:\n");
            Console.WriteLine("1. Blue");
            Console.WriteLine("2. Black");
            Console.WriteLine("3. Khaki");
            Console.WriteLine("4. Gray");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("AE pants are available in blue.");
                    break;
                case 2:
                    Console.WriteLine("AE pants are available in black.");
                    break;
                case 3:
                    Console.WriteLine("AE pants are available in khaki.");
                    break;
                case 4:
                    Console.WriteLine("AE pants are available in gray.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void HasZipper()
        {
            Console.WriteLine("\nAE pants all have zippers and a top button\n");
        }

        public void HasPockets()
        {
            Console.WriteLine("AE pants have pockets. Choose an option:\n");
            Console.WriteLine("1. Front pockets");
            Console.WriteLine("2. Back pockets");
            Console.WriteLine("3. Front and back pockets");
            Console.WriteLine("4. No pockets");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("AE pants have front pockets.");
                    break;
                case 2:
                    Console.WriteLine("AE pants have back pockets.");
                    break;
                case 3:
                    Console.WriteLine("AE pants have both front and back pockets.");
                    break;
                case 4:
                    Console.WriteLine("AE pants have no pockets.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void Size()
        {
            Console.WriteLine("AE pants come in different sizes. Choose an option:\n");
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

        public void Material()
        {
            Console.WriteLine("\nAE pants are all made of Jeans\n");
        }
    }
}
