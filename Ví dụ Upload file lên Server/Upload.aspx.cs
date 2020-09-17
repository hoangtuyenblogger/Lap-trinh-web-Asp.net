using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOANGTUYENMILKTEE
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGui_Click(object sender, EventArgs e)
        {
            if(FileUpload.HasFile)//kiểm tra có tập tin nào được chọn không
            {
                //  tạo đường dẫn lưu tập tin
                string duong_dan = "/App_data/" + FileUpload.FileName;

                // lấy địa chỉ vật lý cho tập tin của ứng dụng
                string dcvl = Server.MapPath(duong_dan);

                // lưu tập tin vào địa chỉ vật lí
                FileUpload.SaveAs(dcvl);

                // thông báo đã lưu
                Response.Write("\n Đã upload file " + FileUpload.FileName);
                Response.Write("\n Đường dẫn của file là : "+dcvl);
            }
        }
    }
}