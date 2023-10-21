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
        }
    }
}
