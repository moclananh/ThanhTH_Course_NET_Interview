using System.Text;

class Program
{
    static int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Mảng không hợp lệ.");
        }

        int max = array[0]; // Giả sử phần tử đầu tiên là số lớn nhất

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i]; // Cập nhật số lớn nhất nếu tìm thấy số lớn hơn
            }
        }

        return max;
    }

    static void Main(string[] args)
    {
        int[] array = { 10, 5, 7, 8, 3, 15, 2 };
        int max = FindMax(array);
        Console.WriteLine("Số lớn nhất trong mảng là: " + max);
    }
}