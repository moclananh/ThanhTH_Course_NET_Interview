public class Singleton
{
    // Biến instance chứa thể hiện duy nhất của lớp Singleton
    private static Singleton instance;

    // Phương thức private constructor để ngăn chặn việc tạo mới đối tượng từ bên ngoài
    private Singleton()
    {
    }

    // Phương thức static để lấy thể hiện duy nhất của lớp Singleton
    public static Singleton getInstance()
    {
        // Kiểm tra nếu instance chưa được khởi tạo, thì khởi tạo nó.
        if (instance == null)
        {
            instance = new Singleton();
        }
        // Trả về thể hiện duy nhất của lớp Singleton
        return instance;
    }
}
