using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOANGTUYENMILKTEE
{
    public partial class Tao_session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTao_session_Click(object sender, EventArgs e)
        {
            Session["Hoten"] = txtHoTen.Text; // khởi tạo session HoTen
            Response.Redirect("Xem_session.aspx");

        }
    }
}