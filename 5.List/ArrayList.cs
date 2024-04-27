using System;
using System.Collections;

class ArrayList
{
    static void Main()
    {
        // Khởi tạo một ArrayList
        System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

        // Thêm các phần tử vào ArrayList
        arrayList.Add("apple");
        arrayList.Add(123);
        arrayList.Add(true);
        arrayList.Add(3.14);

        // Hiển thị các phần tử của ArrayList
        Console.WriteLine("Các phần tử của ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Xóa một phần tử khỏi ArrayList
        arrayList.Remove(123);

        // Hiển thị lại các phần tử của ArrayList sau khi xóa
        Console.WriteLine("\nCác phần tử của ArrayList sau khi xóa:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}
