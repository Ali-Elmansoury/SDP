using System;

namespace SDP_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get an instance of the ConfigManager
            ConfigManager configManager = ConfigManager.get_instance();

            // Set configurations
            configManager.set_config(1, "API_KEY_1");
            configManager.set_config(2, "API_KEY_2");

            // Get configurations
            string apiKey1 = configManager.get_config(1);
            string apiKey2 = configManager.get_config(2);
            string apiKey3 = configManager.get_config(3);

            Console.WriteLine("API Key 1: " + apiKey1);
            Console.WriteLine("API Key 2: " + apiKey2);
            Console.WriteLine("API Key 3: " + apiKey3); // This will be null
            Console.WriteLine("\n");

            // Example of updating an existing configuration
            configManager.set_config(1, "Updated_API_KEY_1");
            string updatedApiKey1 = configManager.get_config(1);
            Console.WriteLine("Updated API Key 1: " + updatedApiKey1);
            Console.WriteLine("\n");
            configManager.get_all_keys();
            Console.WriteLine("\n\n");


            // Get a second instance of the ConfigManager
            ConfigManager configManager1 = ConfigManager.get_instance();

            // Set configurations
            configManager1.set_config(4, "API_KEY_4");
            configManager1.set_config(5, "API_KEY_5");

            // Get configurations
            string apiKey4 = configManager1.get_config(4);
            string apiKey5 = configManager1.get_config(5);
            string apiKey6 = configManager1.get_config(6);

            Console.WriteLine("API Key 4: " + apiKey4);
            Console.WriteLine("API Key 5: " + apiKey4);
            Console.WriteLine("API Key 6: " + apiKey6); // This will be null
            Console.WriteLine("\n");

            // Example of updating an existing configuration
            configManager1.set_config(4, "Updated_API_KEY_4");
            string updatedApiKey4 = configManager1.get_config(4);
            Console.WriteLine("Updated API Key 4: " + updatedApiKey4);
            Console.WriteLine("\n");
            configManager1.get_all_keys();
            Console.WriteLine("\n");
        }
    }
}
