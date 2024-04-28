using _2.TodoAppConsole;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Todo App Menu:");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Display Todos");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TaskManagement.Add();
                        TaskManagement.Display();
                        break;
                    case "2":
                        TaskManagement.Display();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
