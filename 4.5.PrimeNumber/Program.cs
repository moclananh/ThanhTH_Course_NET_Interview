using System.Text;
class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        // Kiểm tra từ 2 đến căn bậc hai của number
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; // Nếu số chia hết cho một số khác 1 và chính nó, không phải là số nguyên tố
            }
        }

        return true; // Nếu không có số nào chia hết, đó là số nguyên tố
    }

    static void PrintPrimeNumbers(int[] array)
    {
        Console.WriteLine("Các số nguyên tố trong mảng là:");
        foreach (int number in array)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); // In một dòng mới sau khi in xong dãy số nguyên tố
    }

    static void Main(string[] args)
    {
        int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        PrintPrimeNumbers(array);
    }
}