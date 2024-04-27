class Program
{
    static void Main()
    {
        // Khởi tạo mảng
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Truy cập phần tử của mảng và hiển thị
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Phần tử thứ {i + 1}: {numbers[i]}");
        }

        // Sử dụng foreach để duyệt mảng
        Console.WriteLine("\nDuyệt mảng bằng foreach:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Sắp xếp mảng
        Array.Sort(numbers);

        // Hiển thị mảng sau khi sắp xếp
        Console.WriteLine("\nMảng sau khi sắp xếp:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}