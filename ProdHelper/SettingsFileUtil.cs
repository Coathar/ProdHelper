using System.IO;
using TallyLightShared.ConfigUtils;
using TallyLightShared.Utils;

namespace ProdHelper
{
    public class SettingsFileUtil
    {
        public static void Intitialize()
        {
            ConfigHelper<GlobalConfigOptions> config = new ConfigHelper<GlobalConfigOptions>("ProdHelperConfig.json");
            GlobalConfigOptions options = config.LoadedOptions;

            string settingsFallback = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Documents\\Overwatch\\Settings";
            string? settingsFolder = options.LastOverwatchConfigFolder;

            if (string.IsNullOrEmpty(settingsFolder))
            {
                settingsFolder = settingsFallback;
                options.LastOverwatchConfigFolder = settingsFolder;
                config.SaveConfig();
            }

            string[] templateFiles = new string[0];
            string selectedFile = "";

            bool validFolder = false;
            bool validTemplate = false;

            while (!validFolder)
            {
                Console.WriteLine($"Enter settings folder path (push enter for: {settingsFolder})");
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    settingsFolder = input;
                    options.LastOverwatchConfigFolder = settingsFolder;
                    config.SaveConfig();
                }

                if (!Directory.Exists(settingsFolder))
                {
                    Console.WriteLine("Invalid settings folder specified");
                    continue;
                }

                if (!Directory.Exists(settingsFolder + "\\Templates"))
                {
                    Console.WriteLine("No templates folder found, creating one now. After this, add in your template files to use.");
                    Directory.CreateDirectory(settingsFolder + "\\Templates");
                    return;
                }

                templateFiles = Directory.GetFiles(settingsFolder + "\\Templates");

                if (templateFiles.Length == 0)
                {
                    Console.WriteLine($"No template files found. Please add some to {settingsFolder}\\Templates");
                    return;
                }

                validFolder = true;
            }

            while (!validTemplate)
            {
                Console.WriteLine("Select a template file to use:");

                int index = 1;

                foreach (string s in templateFiles)
                {
                    Console.WriteLine($"{index++}. {Path.GetFileName(s)}");
                }

                string? indexInput = Console.ReadLine();

                if (int.TryParse(indexInput, out int selectedIndex))
                {
                    if (selectedIndex > templateFiles.Length)
                    {
                        Console.WriteLine("Invalid selection number.");
                        continue;
                    }

                    selectedFile = templateFiles[selectedIndex - 1];
                    break;
                }

                Console.WriteLine("Invalid selection number.");
            }

            while (true)
            {
                Console.WriteLine($"Would you like to move {Path.GetFileName(selectedFile)} to your settings folder? This will OVERRIDE your current settings file! (y/n)");

                string? key = Console.ReadLine();

                if (key != null)
                {
                    if (key.ToLower() == "y")
                    {
                        try
                        {
                            File.Copy(selectedFile, settingsFolder + "\\Settings_v0.ini", true);
                            Console.WriteLine($"Loaded settings file {Path.GetFileName(selectedFile)}! Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error writing file to folder, aborting.");
                            break;
                        }
                    }
                    else if (key.ToLower() == "n")
                    {
                        Console.WriteLine("Aborting settings loading.");
                        break;
                    }
                }
                
            }
        }
    }
}
