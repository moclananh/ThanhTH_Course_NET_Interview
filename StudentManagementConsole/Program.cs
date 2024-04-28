using StudentManagementConsole;
class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Menu();
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentManagement.AddStudent();
                    break;
                case 2:
                    StudentManagement.DisplayStudents();
                    break;
                case 3:
                    StudentManagement.SortStudentsByName();
                    break;
                case 4:
                    StudentManagement.SortStudentsByDateOfBirth();
                    break;
                case 5:
                    StudentManagement.SortStudentsByGPA();
                    break;
                case 6:
                    StudentManagement.DisplayTop10StudentsByGPA();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        static void Menu()
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Sort Students by Name");
            Console.WriteLine("4. Sort Students by Date of Birth");
            Console.WriteLine("5. Sort Students by GPA");
            Console.WriteLine("6. Display Top 10 Students by GPA");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
        }
    }  
}