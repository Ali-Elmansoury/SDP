using System;
using System.Collections.Generic;

namespace SDP_Assignment1
{
    class ConfigManager
    {
        private static ConfigManager instance;

        private Dictionary<int, String> configs;

        private ConfigManager()
        {
            configs = new Dictionary<int, string>();
        }

        public static ConfigManager get_instance()
        {
            if (instance == null)
            {
                instance = new ConfigManager();
            }
            return instance;
        }

        public void set_config(int ID, String API_key)
        {
            if (configs.ContainsKey(ID))
            {
                configs[ID] = API_key;
                Console.WriteLine($"API Key of ID({ID}) updated successfuly\n");
            }
            else
            {
                configs.Add(ID, API_key);
                Console.WriteLine($"Config with ID: ({ID}) and API Key: ({API_key}) added successfuly\n");
            }
        }

        public string get_config(int ID)
        {
            if (configs.ContainsKey(ID))
            {
                return configs[ID];
            }
            else
            {
                return null;
            }
        }
    }
}
