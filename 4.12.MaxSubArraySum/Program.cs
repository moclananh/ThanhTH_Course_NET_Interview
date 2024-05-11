using System;

class Program
{
    static int MaxSubArraySum(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }

    static void Main(string[] args)
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int maxSum = MaxSubArraySum(nums);
        Console.WriteLine("Tổng lớn nhất của chuỗi con trong mảng là: " + maxSum);
    }
}
