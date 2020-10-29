using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;

namespace HOANGTUYEN_LAND
{
    public class DatabaseConnection
    {
        // string conn_str = "Data Source=ADMIN;Initial Catalog=HOANGTUYEN MILKTEE;Integrated Security=True;Connect Timeout=30";
        public string conn_str = System.Configuration.ConfigurationManager.ConnectionStrings["csdl"].ConnectionString; // lấy chuỗi kết nối từ file Web.config
        public SqlConnection conn = new SqlConnection();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public SqlCommand cm = new SqlCommand();

        public void Create_connect()
        {
            try
            {
                conn = new SqlConnection(conn_str);
                conn.Open();
            }
            catch (Exception E)
            {
                
            }
        }


        public void Disconnect()
        {
            cm.Dispose();
            conn.Dispose();
            conn.Close();
        }
        public DataSet Get_data(string query)// lấy dữ liệu về dataset
        {
            Create_connect(); // tạo kết nối csdl
            DataSet ds = new DataSet();// tạo dataset lưu dữ liệu
            da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            Disconnect(); // đóng kết nối
            return ds; // trả về
        }
        public void ExeCuteNonQuery(string sql) // thực thi các câu lệnh thêm, xóa, sửa
        {
            Create_connect();
            cm.Connection = conn;
            cm.Connection = conn;
            cm.CommandText = sql;
            cm.ExecuteNonQuery();
            Disconnect();

        }
        public int Register(string username, string password, 
            string hoten, string sdt, string email)
        {
            Create_connect();
            cm.Connection = conn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "Register"; 
            cm.Parameters.AddWithValue("@Username", username);
            cm.Parameters.AddWithValue("@Password", password);
            cm.Parameters.AddWithValue("@Hoten", hoten);           
            cm.Parameters.AddWithValue("@Email", email);
            cm.Parameters.AddWithValue("@SDT", sdt);
            try
            {
                int a = (int)cm.ExecuteScalar();
                Disconnect();
                return a;
            }
            catch(Exception E)
            {
                Disconnect();
            }
            return -1;
        }
        public bool Login(string username, string password)
        {
            Create_connect();
            cm.Connection = conn; // biến connection
            cm.CommandType = CommandType.StoredProcedure;// loại cm là StoredProcedure
            cm.CommandText = "Login"; // tên StoredProcedure bên Sqlsever
            cm.Parameters.AddWithValue("@Username", username);//truyền username vào StoredProcedure
            cm.Parameters.AddWithValue("@Password", password);//truyền password vào StoredProcedure

            SqlDataReader dr = cm.ExecuteReader(); // thực hiện StoredProcedure  Login
            if (dr.Read()) // 
            {
                Disconnect();
                return true;
            }
            else
            {
                Disconnect();
                return false; // sai thông tin đăng nhập
            }
        }

        public bool Login_For_Admin(string username, string password)
        {
            Create_connect();
            cm.Connection = conn; // biến connection
            cm.CommandType = CommandType.StoredProcedure;// loại cm là StoredProcedure
            cm.CommandText = "Login_For_Admin"; // tên StoredProcedure bên Sqlsever
            cm.Parameters.AddWithValue("@Username", username);//truyền username vào StoredProcedure
            cm.Parameters.AddWithValue("@Password", password);//truyền password vào StoredProcedure

            SqlDataReader dr = cm.ExecuteReader(); // thực hiện StoredProcedure  Login
            if (dr.Read()) // 
            {
                Disconnect();
                return true;
            }
            else
            {
                Disconnect();
                return false; // sai thông tin đăng nhập
            }
        }
        public bool IsAdmin(string username)
        {
            Create_connect();
            cm.Connection = conn; // biến connection
            cm.CommandType = CommandType.StoredProcedure;// loại cm là StoredProcedure
            cm.CommandText = "CheckAdmin"; // tên StoredProcedure bên Sqlsever
            cm.Parameters.AddWithValue("@Username", username);//truyền username vào StoredProcedure


            
            SqlDataReader dr1 = cm.ExecuteReader(); // thực hiện StoredProcedure Login
            if(dr1.Read()) // 
            {
                Disconnect();
                return true;
            }
            else
            {
                Disconnect();
                return false;
            }
        }

        public string MaHoaMatKhau(string password) // dang MD5 , SHA1
        {
            string pass_mahoa = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Trim(), "MD5").ToString();
            return pass_mahoa;
        }
    }
}