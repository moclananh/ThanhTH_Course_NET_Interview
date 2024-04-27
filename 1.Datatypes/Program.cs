class Program
{
    public static void Main(string[] args)
    {
        bool check = false;
        while (!check)
        {
            try
            {
                Menu();
                Console.Write("Choose the feature: ");
                
                int optionValue;
                string option = Console.ReadLine();
                Int32.TryParse(option, out optionValue);

                switch (optionValue)
                {
                    case 0:
                        Console.WriteLine("Thanks for using!");
                        check = true;
                        break;
                    case 1:
                        Console.WriteLine("Feature 1: CastingFloatToInt");
                        CastingFloatToInt();
                        break;
                    case 2:
                        Console.WriteLine("Feature 2");
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }
            }
            catch (Exception)
            {

                throw new Exception("Again pls!!: ");
            }
        }
    }

    static void Menu()
    {
        Console.WriteLine("----------MENU----------");
        Console.WriteLine("1. Convert float to int");
        Console.WriteLine("0. Exit");
    }
    static void CastingFloatToInt()
    {
        float floatValue;
        int intValue;

        Console.Write("Enter a float to convert to integer: ");
        string input = Console.ReadLine();

        try
        {
            if (float.TryParse(input, out floatValue))
            {
                intValue = (int)floatValue; // Casting float to int
                Console.WriteLine($"Integer value: {intValue}");
            }
            else throw new Exception();
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter a valid float.");
        }
    }

}