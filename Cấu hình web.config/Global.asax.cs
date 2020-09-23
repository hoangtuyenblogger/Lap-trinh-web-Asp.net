﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace HOANGTUYENMILKTEE
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Khai báo đếm số người truy cập    

            Application["So_luot_truy_cap"] = 0;

            Application["So_nguoi_online"] = 0;
        }
        void Application_End(object sender, EventArgs e)
        {

            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {

            // Code that runs when an unhandled error occurs
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Tăng giá trị biến Application

            Application["So_luot_truy_cap"] = (int)Application["So_luot_truy_cap"] + 1;

            Application["So_nguoi_online"] = (int)Application["So_nguoi_online"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {

            // Giảm giá trị biến Application

            Application["So_nguoi_online"] = (int)Application["So_nguoi_online"] - 1;

        }
    }
}