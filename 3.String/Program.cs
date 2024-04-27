class Program
{
    static void Main()
    {
        // Nhập chuỗi từ người dùng
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        // Cắt bỏ hết các khoảng trắng dư ở đầu cuối chuỗi
        string trimmedString = input.Trim();

        // Chuyển đổi chữ cái đầu tiên của mỗi từ thành chữ in hoa
        string[] words = trimmedString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = UppercaseFirstLetter(words[i].ToLower());
        }

        // Ghép lại các từ thành chuỗi mới
        string result = string.Join(" ", words);

        // Hiển thị kết quả
        Console.WriteLine("Result:");
        Console.WriteLine(result);
    }

    static string UppercaseFirstLetter(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return string.Empty;
        }
        return char.ToUpper(word[0]) + word.Substring(1);
    }
}