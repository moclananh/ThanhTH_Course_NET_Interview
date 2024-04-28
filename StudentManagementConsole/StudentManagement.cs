

namespace StudentManagementConsole
{
    public class StudentManagement
    {
        private static List<Students> students = new List<Students>();

        // Add a student to the list
        public static void AddStudent()
        {
            Console.WriteLine("Enter student details:");
            Console.Write("Student ID: ");
            string id = Console.ReadLine();
            Console.Write("Student Name: ");
            string name = Console.ReadLine();
            Console.Write("DOB: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Students student = new Students
            {
                StudentId = id,
                StudentName = name,
                DateOfBirth = dob,
                GPA = gpa
            };

            students.Add(student);
            SaveStudentsToFile();
            Console.WriteLine("Student added successfully.");
        }

        // Display all students in the list
        public static void DisplayStudents()
        {
            LoadStudentsFromFile();
            Console.WriteLine("List of students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Sort students by name
        public static void SortStudentsByName()
        {
            students = students.OrderBy(s => s.StudentName).ToList();
            Console.WriteLine("Students sorted by Name.");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Sort students by date of birth
        public static void SortStudentsByDateOfBirth()
        {
            students = students.OrderBy(s => s.DateOfBirth).ToList();
            Console.WriteLine("Students sorted by Date of Birth.");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Sort students by GPA
        public static void SortStudentsByGPA()
        {
            students = students.OrderByDescending(s => s.GPA).ToList();
            Console.WriteLine("Students sorted by GPA.");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Display top 10 students by GPA
        public static void DisplayTop10StudentsByGPA()
        {
            var top10Students = students.OrderByDescending(s => s.GPA).Take(10);
            Console.WriteLine("Top 10 students by GPA:");
            foreach (var student in top10Students)
            {
                Console.WriteLine(student);
            }
        }
        private static void SaveStudentsToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("students.txt"))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine($"{student.StudentId},{student.StudentName},{student.DateOfBirth},{student.GPA}");
                    }
                }
                Console.WriteLine("Student data saved to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving student data to file: {ex.Message}");
            }
        }

        private static void LoadStudentsFromFile()
        {
            try
            {
                students.Clear(); // Clear existing data before loading from file

                using (StreamReader reader = new StreamReader("students.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            Students student = new Students
                            {
                                StudentId = parts[0],
                                StudentName = parts[1],
                                DateOfBirth = DateTime.Parse(parts[2]),
                                GPA = double.Parse(parts[3])
                            };
                            students.Add(student);
                        }
                    }
                }
                Console.WriteLine("Student data loaded from file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading student data from file: {ex.Message}");
            }
        }

    }
}
