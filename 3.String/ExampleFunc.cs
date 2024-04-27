using System;
using System.Linq;

class ExampleFunc
{
    static void Main()
    {
        Console.WriteLine("Chương trình xử lý chuỗi");
        Console.WriteLine("-------------------------");

        // Kiểm tra độ dài của chuỗi
        Console.Write("Nhập chuỗi: ");
        string inputString = Console.ReadLine();
        Console.WriteLine($"Độ dài của chuỗi là: {GetStringLength(inputString)}");

        // Chuyển đổi chữ hoa thành chữ thường và ngược lại
        Console.WriteLine("Chữ hoa thành chữ thường và ngược lại:");
        Console.WriteLine($"Chữ hoa: {ConvertToUpperCase(inputString)}");
        Console.WriteLine($"Chữ thường: {ConvertToLowerCase(inputString)}");

        // Đảo ngược chuỗi
        Console.WriteLine("Đảo ngược chuỗi:");
        Console.WriteLine($"Chuỗi đảo ngược: {ReverseString(inputString)}");

        // Đếm số lần xuất hiện của một ký tự trong chuỗi
        Console.Write("Nhập ký tự để đếm: ");
        char charToCount = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine($"Số lần xuất hiện của '{charToCount}' trong chuỗi: {CountOccurrences(inputString, charToCount)}");

        // Loại bỏ các ký tự trùng lặp trong chuỗi
        Console.WriteLine("Loại bỏ các ký tự trùng lặp trong chuỗi:");
        Console.WriteLine($"Chuỗi sau khi loại bỏ: {RemoveDuplicates(inputString)}");

        // Kiểm tra chuỗi đối xứng
        Console.WriteLine($"Chuỗi '{inputString}' {(IsPalindrome(inputString) ? "là chuỗi đối xứng." : "không phải là chuỗi đối xứng.")}");
    }

    static int GetStringLength(string str)
    {
        return str.Length;
    }

    static string ConvertToUpperCase(string str)
    {
        return str.ToUpper();
    }

    static string ConvertToLowerCase(string str)
    {
        return str.ToLower();
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int CountOccurrences(string str, char character)
    {
        return str.Count(c => c == character);
    }

    static string RemoveDuplicates(string str)
    {
        return new string(str.Distinct().ToArray());
    }

    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
