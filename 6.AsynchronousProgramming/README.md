https://www.youtube.com/watch?v=OZLCVcCB5Gg

Trong C#, lập trình bất đồng bộ (asynchronous programming)
là một kỹ thuật cho phép bạn thực hiện các hoạt động mà không cần chờ đợi kết quả 
trả về trước khi tiếp tục thực thi các công việc khác

Trong C#, lập trình bất đồng bộ thường được thực hiện bằng cách sử dụng từ khóa async và await,
cùng với các phương thức được đánh dấu là async. Dưới đây là một số điểm quan trọng về lập trình bất đồng bộ trong C#:

Từ khóa async và await:
- async: Đánh dấu một phương thức là bất đồng bộ, cho phép nó thực hiện các hoạt động không đồng bộ.
- await: Chờ đợi một tác vụ (task) hoặc một tác vụ được quyền thực hiện bất đồng bộ,
cho phép tiếp tục thực thi các công việc khác trong khi tác vụ đang chờ đợi.

Tác vụ (Task):
- Trong lập trình bất đồng bộ, tác vụ (Task) là một loại đối tượng được sử dụng để thực hiện một công việc không đồng bộ.
- Tác vụ có thể được trả về từ các phương thức đã đánh dấu là async, và bạn có thể sử dụng từ khóa await để chờ đợi kết quả của chúng.

Cơ chế hoạt động:
- Khi gặp từ khóa await, luồng (thread) không bị chặn (blocked) và có thể thực hiện các công việc khác trong khi tác vụ đang chờ đợi.
- Khi tác vụ hoàn thành, luồng sẽ tiếp tục thực hiện các câu lệnh sau từ khóa await.

Các ứng dụng:
- Lập trình bất đồng bộ thường được sử dụng trong các ứng dụng desktop, web và di động để tăng hiệu suất và khả năng phản hồi của ứng dụng.
- Các hoạt động I/O như đọc/ghi tệp tin, truy vấn cơ sở dữ liệu, gửi và nhận dữ liệu qua mạng thường được thực hiện bất đồng bộ.