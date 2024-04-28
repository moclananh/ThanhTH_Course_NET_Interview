
namespace _2.TodoAppConsole
{
    public class TaskManagement
    {
        private static List<Tasks> tasks = new List<Tasks>();

        // Add a student to the list
        public static void Add()
        {
            Console.WriteLine("Enter task details:");
           
            Console.Write("Task Name: ");
            string name = Console.ReadLine();
            Console.Write("Task Descriptions: ");
            string des = Console.ReadLine();
            Console.Write("Priority: ");
            int prio = Convert.ToInt32(Console.ReadLine());

            Random generator = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomCode = new string(Enumerable.Repeat(chars, 14)
              .Select(s => s[generator.Next(s.Length)]).ToArray());

            Tasks task = new Tasks
            {
                Id = randomCode,
                TaskName = name,
                TaskDescription = des,
                Priority = prio
            };

            tasks.Add(task);
            SaveToFile();
            Console.WriteLine("Added successfully.");
        }

        // Display all students in the list
        public static void Display()
        {
            LoadFromFile();
            Console.WriteLine("List of task:");
            tasks = tasks.OrderByDescending(prio => prio.Priority).ToList();
            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }
        }

      
        private static void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("tasklog.txt"))
                {
                    foreach (var item in tasks)
                    {
                        writer.WriteLine($"{item.Id},{item.TaskName},{item.TaskDescription},{item.Priority}");
                    }
                }
                Console.WriteLine("Task data saved to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving student data to file: {ex.Message}");
            }
        }

        private static void LoadFromFile()
        {
            try
            {
                tasks.Clear(); // Clear existing data before loading from file

                using (StreamReader reader = new StreamReader("tasklog.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            Tasks task = new Tasks
                            {
                                Id = parts[0],
                                TaskName = parts[1],
                                TaskDescription = parts[2],
                                Priority = Int32.Parse(parts[3])
                            };
                            tasks.Add(task);
                        }
                    }
                }
                Console.WriteLine("Task data loaded from file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading student data from file: {ex.Message}");
            }
        }
    }
}
