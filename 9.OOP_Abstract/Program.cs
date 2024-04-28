using System;

// Lớp cơ sở đại diện cho các hình học chung
public abstract class HinhHoc
{
    // Phương thức trừu tượng tính diện tích
    public abstract double TinhDienTich();

    // Phương thức trừu tượng tính chu vi
    public abstract double TinhChuVi();

    // Phương thức in thông tin hình học
    public void HienThongTin()
    {
        Console.WriteLine("Diện tích: " + TinhDienTich());
        Console.WriteLine("Chu vi: " + TinhChuVi());
    }
}

// Lớp con - Hình tròn
public class HinhTron : HinhHoc
{
    public double BanKinh { get; set; }

    // Triển khai phương thức tính diện tích
    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }

    // Triển khai phương thức tính chu vi
    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }
}

// Lớp con - Hình vuông
public class HinhVuong : HinhHoc
{
    public double Canh { get; set; }

    // Triển khai phương thức tính diện tích
    public override double TinhDienTich()
    {
        return Canh * Canh;
    }

    // Triển khai phương thức tính chu vi
    public override double TinhChuVi()
    {
        return 4 * Canh;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo một hình tròn
        HinhTron hinhTron = new HinhTron();
        hinhTron.BanKinh = 5;

        Console.WriteLine("Thông tin hình tròn:");
        hinhTron.HienThongTin(); // Gọi phương thức hiển thị thông tin

        // Tạo một hình vuông
        HinhVuong hinhVuong = new HinhVuong();
        hinhVuong.Canh = 4;

        Console.WriteLine("\nThông tin hình vuông:");
        hinhVuong.HienThongTin(); // Gọi phương thức hiển thị thông tin
    }
}
