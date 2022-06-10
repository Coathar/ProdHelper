namespace ProdHelper
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
                        case "h":
                            ListOptions();
                            break;
                        case "x":
                            endApp = true;
                            break;
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
            Console.WriteLine("H: List this menu");
            Console.WriteLine("X: Close");
        }
    }
}