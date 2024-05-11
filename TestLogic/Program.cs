using System.Text;

class Program
{
    static string RemoveConsecutiveDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
        input = input.Trim();
        StringBuilder result = new StringBuilder();
       
        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
                result.Append(input[i]);
        }

        return result.ToString();
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string output = RemoveConsecutiveDuplicates(input);
        Console.WriteLine(output);
    }
}