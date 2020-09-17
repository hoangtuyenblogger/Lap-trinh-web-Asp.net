### Khi lập trình web bằng `ASP.NET` hoặc `Asp.net MVC`, một thành phần rất quan trọng trong việc đảm bảo an toàn cho website là file **web.config**. Đây là file chứa các cấu hình cơ bản của website
- khai báo sessicon timeout: `<sessionState timeout="30" ></sessionState>`
- khai báo cấu hình lỗi: `<customErrors mode="On" defaultRedirect="erro.aspx"/>`
- chống tấn công Cross Site Scripting: `<add name="X-XSS-Protection" value="1; mode=block" />`
- Ẩn đi thông tin cấu hình server đang sử dụng, giúp hạn chế một số thành phần xấu muốn tấn công: 
    - ```<remove name="X-Powered-By" />
      <remove name="X-AspNet-Version" />
      <remove name="X-AspNetMvc-Version" />
      <remove name="X-Powered-By-Plesk" />
      <remove name="Server" /> ```
- Cấu hình X-XSS-Protection chống tấn công Cross Site Scripting: `<add name="X-XSS-Protection" value="1; mode=block" />`
- khai báo chuỗi kết nối cơ sở dữ liệu: `<add name="Tên CSDL" connectionString="Chuỗi kết nối cơ sở dữ liệu"/>`