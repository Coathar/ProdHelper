using TallyLightObs;

namespace ProdHelper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            bool endApp = false;

            Console.WriteLine("ProdHelper Utility");
            Console.WriteLine("Written by Coathar");
            Console.WriteLine("");
            ListOptions();

            while (!endApp)
            {
                string? key = Console.ReadLine();

                if (key != null)
                {
                    switch (key.ToLower())
                    {
                        case "1":
                            SettingsFileUtil.Intitialize();
                            break;
                        case "2":
                            Console.WriteLine("Opening Production Client");
                            new TallyLightProd.TallyLightProd().ShowDialog();
                            break;
                        case "3":
                            Console.WriteLine("Opening Observer Client");
                            new TallyLightObserver().ShowDialog();
                            break;
                        case "h":
                            ListOptions();
                            break;
                        case "x":
                            endApp = true;
                            continue;
                        default:
                            Console.WriteLine("Invalid option, enter 'H' for help.");
                            continue;
                    }

                    ListOptions();
                }
                
            }

            Console.WriteLine("Goodbye");
        }

        public static void ListOptions()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1: Settings Util");
            Console.WriteLine("2: Open OBS Tally Light Utility (Production/OBS Director)");
            Console.WriteLine("3: Open OBS Tally Light Utility (Observer)");
            Console.WriteLine("H: List this menu");
            Console.WriteLine("X: Close");
        }
    }
}