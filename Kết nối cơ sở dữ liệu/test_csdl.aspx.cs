using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HOANGTUYEN_LAND
{
    public partial class test_csdl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btn_connect_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            try
            {
                db.Create_connect();
                Response.Write("Conected success!");

                DataSet ds = new DataSet();
                ds = db.Get_data("Select * from NGUOIDUNG");
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            catch(Exception E)
            {
                Response.Write("Conected fail!");
            }
        }

       
    }
}