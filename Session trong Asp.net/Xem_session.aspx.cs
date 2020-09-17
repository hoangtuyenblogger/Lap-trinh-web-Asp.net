using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOANGTUYENMILKTEE
{
    public partial class Xem_session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (Session["Hoten"] == null)
            {
                lbl_Xem_session.Text = "Session đã hết hạn!";
            }
            else
            {
                string Xem_session = Session["Hoten"].ToString();
                lbl_Xem_session.Text = Xem_session;
            }

        }
    }
}