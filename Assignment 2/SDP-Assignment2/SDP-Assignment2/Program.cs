using System;

namespace SDP_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Online Clothing Store!");
            Console.WriteLine("Please select a brand to shop from: ");
            Console.WriteLine("1. AE");
            Console.WriteLine("2. Dior");
            Console.WriteLine("3. Chanel");
            Console.WriteLine("4. LV");

            int brandChoice = int.Parse(Console.ReadLine());

            ClothesFactory selectedBrand = null;

            // Select the appropriate factory based on user input
            switch (brandChoice)
            {
                case 1:
                    selectedBrand = OnlineStore_client.GetBrand("AE");
                    break;
                case 2:
                    selectedBrand = OnlineStore_client.GetBrand("Dior");
                    break;
                case 3:
                    selectedBrand = OnlineStore_client.GetBrand("Chanel");
                    break;
                case 4:
                    selectedBrand = OnlineStore_client.GetBrand("LV");
                    break;
                default:
                    Console.WriteLine("Invalid brand choice.");
                    return;
            }

            Pants pants = selectedBrand.createPants();
            Jacket jacket = selectedBrand.createJacket();
            Shirt shirt = selectedBrand.createShirt();

            // Call functions for each item
            Console.WriteLine("Pants:");
            pants.Material();
            pants.Color();
            pants.HasZipper();
            pants.HasPockets();
            pants.Size();
            Console.WriteLine("\n");

            Console.WriteLine("Jacket:");
            jacket.Material();
            jacket.Size();
            jacket.Gender();
            Console.WriteLine("\n");

            Console.WriteLine("Shirt:");
            shirt.Material();
            shirt.Style();
            shirt.CollarType();
        }
    }


}
