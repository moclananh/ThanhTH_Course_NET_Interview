using System;

class Program
{
    // Tính UCLN sử dụng thuật toán Euclid
    static int UCLN(int a, int b)
    {
        // Chia cho 0 nếu cả hai số đều là 0
        if (a == 0 && b == 0)
        {
            throw new ArgumentException("Không xác định UCLN của hai số bằng 0.");
        }

        // Sử dụng thuật toán Euclid để tính UCLN
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return Math.Abs(a); // Trả về giá trị tuyệt đối của UCLN
    }

    // Tính BCNN sử dụng công thức BCNN(a, b) = (a * b) / UCLN(a, b)
    static int BCNN(int a, int b)
    {
        // Trả về 0 nếu cả hai số đều là 0
        if (a == 0 && b == 0)
        {
            return 0;
        }

        // Tính BCNN
        return Math.Abs(a * b) / UCLN(a, b);
    }

    static void Main(string[] args)
    {
        int a = 24;
        int b = 36;

        // Tính và in ra UCLN và BCNN của hai số
        Console.WriteLine("UCLN của " + a + " và " + b + " là: " + UCLN(a, b));
        Console.WriteLine("BCNN của " + a + " và " + b + " là: " + BCNN(a, b));
    }
}
