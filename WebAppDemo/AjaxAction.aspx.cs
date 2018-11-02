using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo
{
    public partial class AjaxAction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            var name = Request.Form["taskname"];
            var family = Request.Form["family"];

            using (StreamWriter sw = new StreamWriter(Server.MapPath("~/SubmittedData/Users.txt"), true))
            {
                sw.WriteLine($"{name},{family}");
            }

            Thread.Sleep(2000);
           
            Response.Write("اطلاعات با موفقیت ثبت شد");
            

        }
    }
}