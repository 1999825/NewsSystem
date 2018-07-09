using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSystemBLL;
using NewsSystemModels;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null && Request.Cookies["password"] != null)
            {
                Response.Cookies["username"].Expires = System.DateTime.Now.AddSeconds(-1);//Expires过期时间
                Response.Cookies["password"].Expires = System.DateTime.Now.AddSeconds(-1);
            }
        }
        private void FindButton(Control c)
        {
           if (c.Controls != null)
           {
               foreach (Control x in c.Controls)
               {
                   if (x is System.Web.UI.WebControls.TextBox)
                   {
                       ((System.Web.UI.WebControls.TextBox) x).Text = "";
                   }
                   FindButton(x);
               }
           }
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {

            UserInfo us = new UserInfo();
            us.userName = txtname.Text.Trim();
            us.userPassword = txtpwd.Text.Trim();
            if (RegisterVerifyBll.RegisterOK(us))
            {
                if (CheckBox1.Checked)
                {
                    //创建Cookie对象，保存Cookie数据，设置Cookie保存时间
                    Response.Cookies["username"].Value = txtname.Text;
                    Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(10);
                    Response.Cookies["password"].Value = txtpwd.Text;
                    Response.Cookies["password"].Expires = DateTime.Now.AddSeconds(10);
                    
                }
         
            }
            else
            {
                Response.Write("<script>alert('你输入是账号密码不存在')</script>");
            }
        }
    }
}