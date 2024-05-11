using System;
using System.Collections.Generic;

class Program
{
    static int[] RemoveDuplicates(int[] array)
    {
        HashSet<int> set = new HashSet<int>(); // Sử dụng HashSet để lưu trữ các phần tử không trùng lặp
        List<int> resultList = new List<int>(); // Sử dụng List để lưu trữ kết quả cuối cùng

        foreach (int num in array)
        {
            if (!set.Contains(num))
            {
                set.Add(num);
                resultList.Add(num);
            }
        }

        return resultList.ToArray();
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 3, 2, 5, 6, 1 };
        int[] result = RemoveDuplicates(array);

        Console.WriteLine("Mảng sau khi loại bỏ các phần tử trùng lặp:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
