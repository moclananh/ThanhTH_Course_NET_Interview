using System;

public class Employee
{
    private string name;
    private double salary;
    
    // Phương thức getter cho thuộc tính name
    public string GetName()
    {
        return name;
    }

    // Phương thức setter cho thuộc tính name
    public void SetName(string newName)
    {
        if (!string.IsNullOrEmpty(newName))
        {
            name = newName;
        }
    }

    // Phương thức getter cho thuộc tính salary
    public double GetSalary()
    {
        return salary;
    }

    // Phương thức setter cho thuộc tính salary
    public void SetSalary(double newSalary)
    {
        if (newSalary >= 0)
        {
            salary = newSalary;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo một đối tượng nhân viên
        Employee emp = new Employee();
       
        // Sét và lấy thông tin về tên và lương
        emp.SetName("John Doe");
        emp.SetSalary(50000);

        // In thông tin nhân viên
        Console.WriteLine("Employee Name: " + emp.GetName());
        Console.WriteLine("Employee Salary: " + emp.GetSalary());
    }
}
