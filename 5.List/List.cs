using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Khởi tạo một List kiểu int
        List<int> numbers = new List<int>();

        // Thêm các phần tử vào List
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Hiển thị các phần tử của List
        Console.WriteLine("Các phần tử của List:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
