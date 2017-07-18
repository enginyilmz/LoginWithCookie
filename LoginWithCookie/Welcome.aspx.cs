using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWithCookie
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.lbl_username.Text = Session["username"].ToString();
            }
        }
        protected void lb_logout_Click(object sender, EventArgs e)
        {
            //Remove Sessio
            Session.Remove("username");
            //Remove Cookies
            HttpCookie ckUsername = new HttpCookie("username");
            ckUsername.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(ckUsername);

            HttpCookie ckPassword = new HttpCookie("password");
            ckPassword.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(ckPassword);

            Response.Redirect("Login.aspx");
        }
    }
}