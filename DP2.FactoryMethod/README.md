 Mẫu này cho phép bạn định nghĩa một giao diện để tạo ra một đối tượng, nhưng để các lớp con quyết định lớp cụ thể nào sẽ được tạo ra.
 Điều này cho phép một lớp chính sử dụng một phương thức tạo mà không cần biết đối tượng cụ thể nào sẽ được tạo.

### Ưu điểm:
Tính linh hoạt (Flexibility): Factory Method cho phép bạn mở rộng và cấu hình một cách linh hoạt các lớp cụ thể được tạo ra mà không cần thay đổi mã trong lớp factory.
Tách biệt quyết định tạo đối tượng (Decouples Object Creation): Mẫu này tách biệt quyết định tạo đối tượng ra khỏi client code. Client chỉ cần biết interface chung mà không cần quan tâm về việc tạo ra đối tượng cụ thể.
Khả năng tái sử dụng (Reusability): Các lớp factory có thể được sử dụng để tạo ra các đối tượng ở nhiều nơi khác nhau trong ứng dụng.

### Nhược điểm:
Tăng độ phức tạp (Increased Complexity): Factory Method có thể tạo ra một số lớp factory và lớp con, điều này có thể làm tăng độ phức tạp của mã.
Cần phải tạo factory mỗi khi có lớp mới (Creation of Factory for Each New Class): Mỗi khi bạn thêm một lớp mới, bạn cần tạo một factory mới tương ứng.

### Trường hợp sử dụng:
Khi bạn muốn trì hoãn việc quyết định tạo đối tượng cho các lớp con (When you want to defer object creation to subclasses): Factory Method cho phép các lớp con quyết định lớp cụ thể nào sẽ được tạo ra.
Khi bạn muốn tạo các đối tượng mà không cần phải xác định lớp cụ thể (When you want to create objects without specifying the exact class): Factory Method là lựa chọn tốt khi bạn chỉ muốn tạo đối tượng thông qua một giao diện chung.
Khi bạn muốn tạo đối tượng dựa trên một số điều kiện (When you want to create objects based on some conditions): Factory Method cho phép bạn thực hiện các logic phức tạp để quyết định loại đối tượng nào sẽ được tạo ra.