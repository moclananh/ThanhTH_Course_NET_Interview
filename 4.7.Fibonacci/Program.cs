using System;

class Program
{
    // Tạo dãy Fibonacci với số lượng phần tử cho trước
    static void GenerateFibonacci(int n)
    {
        int a = 0, b = 1;

        Console.WriteLine("Dãy Fibonacci với " + n + " phần tử là:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int temp = a;
            a = b;
            b = temp + b;
        }
    }

    static void Main(string[] args)
    {
        int count = 10; // Số lượng phần tử trong dãy Fibonacci
        GenerateFibonacci(count);
    }
}