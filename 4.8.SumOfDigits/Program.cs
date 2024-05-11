using System;

class Program
{
    static int SumOfDigits(int number)
    {
        int sum = 0;

        // Lặp qua từng chữ số của số nguyên và cộng vào tổng
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int number = 12345;
        int sum = SumOfDigits(number);
        Console.WriteLine("Tổng các chữ số trong " + number + " là: " + sum);
    }
}
