using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork10042020_Cokkies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("My localhost cookie");
            string str = Name.Text+Year.Text;
            
            cookie["Language"] = str;
            
            Response.Cookies.Add(cookie);
            cookie.Expires = DateTime.Now.AddDays(1);
                
        }

        protected void cmdRestore_Click(object sender, EventArgs e)
        {
            HttpCookie cookieReq = Request.Cookies["My localhost cookie"];
            string language;            

            if (cookieReq != null)
            {
                language = cookieReq["Language"];                
                lbShow.Text = language;               
            }
        }
    }
}