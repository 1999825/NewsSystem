using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSystemBLL;
using NewsSystemModels;
namespace NewsSystemUI
{
    public partial class UserManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bin();
            }
        }
        public void bin()
        {
            this.GridView1.DataSource = AddUserBll.GetTable();

            this.GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bin();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);
            UserInfo user = new UserInfo();
            user.userId = id;
            if (AddUserBll.DeleteUserOK(user))
            {
                Response.Write("<script>alert('ok')</script>");
                bin();
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = int.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);
            Control control = GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox textBox = (TextBox)control;
            string str = textBox.Text;
            Control control2 = GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox textBox2 = (TextBox)control;
            string str1 = textBox.Text;
            UserInfo user = new UserInfo();
            user.userName = str;
            user.userPassword = str1;
            user.userId = id;
            if (AddUserBll.UpdateUserOK(user))
            {
                Response.Write("<script>alert('ok')</script>");
                bin();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.GridView1.EditIndex = -1;
            bin();
        }
    }
}