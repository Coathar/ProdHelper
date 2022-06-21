using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallyLightShared.Models;

namespace TallyLightShared.ConfigUtils
{
    public class ConfigHelper<T>
    {
        public static readonly string CONFIG_DATA_FOLDER = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/ProdHelper";

        private string _filePath;
        private string _configName;

        private T? _configurationOptions;
        public T LoadedOptions
        {
            get
            {
                if (_configurationOptions == null)
                {
                    LoadConfig();
                }

                return _configurationOptions;
            }
        }

        public ConfigHelper(string filePath, string configName)
        {
            _filePath = filePath;
            _configName = configName;
        }

        public ConfigHelper()
        {
            _filePath = CONFIG_DATA_FOLDER;
        }

        private void LoadConfig()
        {
            if (!Directory.Exists($"{CONFIG_DATA_FOLDER}"))
            {
                Directory.CreateDirectory($"{CONFIG_DATA_FOLDER}");
            }

            if (!File.Exists($"{CONFIG_DATA_FOLDER}/{_configName}"))
            {
                SaveConfig();
            }

            string options = string.Empty;

            using (FileStream configStream = File.OpenRead($"{CONFIG_DATA_FOLDER}/{_configName}"))
            {
                using (TextReader reader = new StreamReader(configStream))
                {
                    options = reader.ReadToEnd();
                }
            }

            _configurationOptions = JsonConvert.DeserializeObject<T>(options);

            if (_configurationOptions == null)
            {
                _configurationOptions = default;
            }
        }
        
        public void SaveConfig()
        {
            string? jsonOptions = JsonConvert.SerializeObject(_configurationOptions, Formatting.Indented);

            using (FileStream configStream = File.Create($"{CONFIG_DATA_FOLDER}/{_configName}"))
            {
                using (TextWriter writer = new StreamWriter(configStream))
                {
                    writer.WriteLine(jsonOptions);
                }
            }
        }
    }
}
