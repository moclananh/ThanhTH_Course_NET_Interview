using System;
using System.Linq;

class Program
{
    static bool AreAnagrams(string str1, string str2)
    {
        // Nếu độ dài của hai chuỗi không bằng nhau, chúng không thể là anagram
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // Chuyển đổi chuỗi thành mảng ký tự để sắp xếp và so sánh
        return str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c));
    }

    static void Main(string[] args)
    {
        string str1 = "listen";
        string str2 = "silent";

        if (AreAnagrams(str1, str2))
        {
            Console.WriteLine(str1 + " và " + str2 + " là anagram của nhau.");
        }
        else
        {
            Console.WriteLine(str1 + " và " + str2 + " không phải là anagram của nhau.");
        }
    }
}
