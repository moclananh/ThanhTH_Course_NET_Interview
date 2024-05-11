using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Algo
{
    static int FindSecondLargest(int[] arr)
    {
        if (arr.Length < 2)
        {
            Console.WriteLine("Không đủ phần tử trong mảng.");
            return -1; // hoặc ném một ngoại lệ tùy vào yêu cầu cụ thể.
        }

        int max1 = arr[0];
        int max2 = arr[1];

        if (max1 < max2)
        {
            int temp = max1;
            max1 = max2;
            max2 = temp;
        }

        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];
            }
            else if (arr[i] > max2 && arr[i] != max1)
            {
                max2 = arr[i];
            }
        }

        return max2;
    }

    static void Main(string[] args)
    {
        int[] arr = { 3, 7, 1, 9, 5, 6, 8, 2, 4 };

        int secondLargest = FindSecondLargest(arr);
        Console.WriteLine("Giá trị lớn thứ hai trong mảng là: " + secondLargest);
    }
}