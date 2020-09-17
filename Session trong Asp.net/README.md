### Session là một khái niệm phổ biến được dùng trong lập trình các website có kết nối với cơ sở dữ liệu database. Đặc biệt các chức năng như đăng nhập, đăng xuất người dùng sẽ khó có thể thực hiện được nếu không sử dụng session web
#### Một session được hiểu như một phiên làm việc giữa client và server, bắt đầu khi có request từ client, kết thúc khi người dùng đóng ứng dụng hoặc khi session hết thời gian timeout. Cũng giống như Cookie, Session được dùng để lưu trữ thông tin liên quan đến người dùng, nhưng thay vì được lưu trên máy client, các biến session được lưu trên máy server.
- **SESSION TIMEOUT**
  - Là khoảng thời gian lớn nhất có thể giữa hai lần user request lên server mà session của user chưa bị hủy.
  - Khai báo **Session timeout** trong file **web.config** : `<sessionState timeout="30"></sessionState>`
  - Cách khai báo biến Session: `Session["Tên Biến"] = Giá trị;`
  - Cách lấy giá trị biến Session: `<Biến> = Session["Tên Biến"];`
