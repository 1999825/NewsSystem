using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSystemModels;
using NewsSystemBLL;
using System.Data;
namespace NewsSystemUI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                DataTable table = new DataTable();
                table = AddUserBll.GetTable();
                UserInfo user = new UserInfo();
                user.userName = txtName.Text.Trim();
                foreach (DataRow item in table.Rows)
                {
                    if (item["userName"].ToString() == user.userName)
                    {
                        Response.Write("<script>alert('已存在此用户')</script>");
                        return;
                    }
                }
                user.userPassword = txtPwd.Text.Trim();
                if (AddUserBll.AddUserOK(user))
                {
                    Response.Write("<script>alert('注册成功')</script>");
                }

            }
        }
    }
}