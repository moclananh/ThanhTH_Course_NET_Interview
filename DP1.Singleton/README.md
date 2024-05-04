 Mẫu Singleton được sử dụng khi chúng ta chỉ muốn một đối tượng duy nhất của một lớp được tạo ra và chia sẻ trong toàn bộ ứng dụng.
 Đây là một cách để đảm bảo rằng không có ai có thể tạo ra nhiều phiên bản của đối tượng đó.

### Ưu điểm:
Đảm bảo chỉ có một thể hiện: Singleton đảm bảo rằng chỉ có một thể hiện duy nhất của lớp được tạo ra, giúp tiết kiệm tài nguyên và đảm bảo tính nhất quán trong toàn bộ ứng dụng.
Dễ dàng truy cập: Thể hiện Singleton có thể truy cập từ mọi nơi trong ứng dụng thông qua phương thức static getInstance().
Lazy initialization: Thể hiện của Singleton được tạo ra chỉ khi cần thiết (lazy initialization), giúp tiết kiệm tài nguyên trong trường hợp không sử dụng đến.

### Nhược điểm:
Khó kiểm soát trong môi trường đa luồng: Trong một môi trường đa luồng, có thể xảy ra vấn đề khi nhiều luồng cùng truy cập vào phương thức getInstance() cùng một lúc, dẫn đến việc tạo ra nhiều thể hiện của Singleton. Để khắc phục vấn đề này, bạn cần sử dụng các phương pháp đồng bộ hóa như double-checked locking hoặc sử dụng khởi tạo độc lập với luồng (lazy initialization holder class idiom).
Khó kiểm soát trong môi trường phân tán: Trong một môi trường phân tán, việc duy trì Singleton qua các nút có thể gặp khó khăn và cần phải cân nhắc về tính nhất quán.

### Trường hợp sử dụng:
Cơ sở dữ liệu: Khi ứng dụng của bạn cần truy cập vào một cơ sở dữ liệu, Singleton có thể được sử dụng để duy trì kết nối cơ sở dữ liệu duy nhất trong toàn bộ ứng dụng.
Ghi log (Logging): Singleton có thể được sử dụng để ghi log trong ứng dụng, đảm bảo rằng chỉ có một điểm truy cập vào hệ thống log.
Cài đặt cấu hình (Configuration): Singleton có thể được sử dụng để lưu trữ các cài đặt cấu hình chung cho toàn bộ ứng dụng.
Caching: Singleton có thể được sử dụng để lưu trữ dữ liệu cache và cung cấp truy cập đồng nhất cho các thành phần khác của ứng dụng.
Quản lý tài nguyên hệ thống: Singleton có thể được sử dụng để quản lý truy cập vào các tài nguyên hệ thống như hệ thống tệp, socket, và tài nguyên phần cứng.