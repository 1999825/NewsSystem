using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSystemModels;
using NewsSystemBLL;

namespace NewsSystemUI
{
    public partial class NewsHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }
        public static int PageNumber = 1;
        public static int TypeId = 0;
        public void Bind()
        {
            TypeId = 1;
            this.GridViewHqjj.Columns.Clear();
            this.GridViewHqjj.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, TypeId);
            this.GridViewHqjj.DataBind();
        }
    }
}