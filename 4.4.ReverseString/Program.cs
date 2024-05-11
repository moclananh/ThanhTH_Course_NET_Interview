using System.Text;
class Program
{
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main(string[] args)
    {
        string str = "hello everyone";
        var result = ReverseString(str);
        Console.WriteLine(result);
    }
}