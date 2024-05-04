
Chiến lược (Strategy) là một mẫu thiết kế cho phép bạn xác định một tập hợp các thuật toán, đóng gói mỗi thuật toán và làm cho chúng có thể thay đổi. Chiến lược cho phép thuật toán có thể chuyển đổi độc lập với client sử dụng nó.
Điều này làm cho client có thể chọn thuật toán cần thiết một cách linh hoạt và dễ dàng.

Mục tiêu là cho phép thuật toán có thể chuyển đổi độc lập với client sử dụng nó. Một class sử dụng Strategy có thể thay đổi thuật toán mà nó sử dụng một cách linh hoạt.
Sử dụng một interface hoặc abstract class để định nghĩa chiến lược, và mỗi chiến lược cụ thể được triển khai trong các lớp riêng biệt.

### Ưu điểm:
1. **Tính linh hoạt (Flexibility)**: Mẫu Strategy cho phép bạn chọn lựa giữa các thuật toán khác nhau một cách linh hoạt và độc lập với client sử dụng nó. Bạn có thể thay đổi thuật toán mà không cần sửa đổi code của client.

2. **Tách biệt quyết định (Decouples Decisions)**: Strategy tách biệt quyết định về cách thức thực hiện từ client. Client chỉ cần biết về interface Strategy và không cần quan tâm đến cách thức cụ thể để thực hiện một thuật toán.

3. **Tính tái sử dụng (Reusability)**: Bạn có thể sử dụng các chiến lược khác nhau trong nhiều ngữ cảnh khác nhau mà không cần phải viết lại code.

### Nhược điểm:
1. **Số lượng class tăng lên**: Mỗi chiến lược cụ thể đều phải có một class riêng, điều này có thể dẫn đến việc tăng số lượng class trong ứng dụng của bạn.

2. **Khả năng phức tạp hóa (Complexity)**: Nếu số lượng chiến lược quá lớn, quản lý các chiến lược và quản lý việc ánh xạ chúng với các tình huống có thể trở nên phức tạp.

### Trường hợp sử dụng:
1. **Khi bạn muốn có thể thay đổi thuật toán một cách linh hoạt**: Strategy là lựa chọn tốt khi bạn cần thay đổi cách thức thực hiện một nhiệm vụ nào đó tùy thuộc vào điều kiện hoặc yêu cầu của người dùng.

2. **Khi bạn muốn tách biệt quyết định về cách thức thực hiện**: Nếu bạn muốn tách biệt quyết định về cách thức thực hiện một nhiệm vụ ra khỏi client, Strategy là một lựa chọn tốt để giữ cho code của bạn linh hoạt và dễ bảo trì.

3. **Khi bạn muốn tái sử dụng code**: Strategy cho phép bạn tái sử dụng các chiến lược khác nhau trong nhiều ngữ cảnh khác nhau, giúp giảm lặp lại code và tăng hiệu suất phát triển.