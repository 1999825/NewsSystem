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
    public partial class NewsSearchPage : System.Web.UI.Page
    {
        List<NewsTypeInfo> _newsType;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageBind();
            }
        }
        public static int PageNumber = 1;
        public void PageBind()
        {
            _newsType = NewsInfoCRUD.GetNewsType();
            this.DropNewsList.Items.Clear();
            foreach (var item in _newsType)
            {
                this.DropNewsList.Items.Add(item.typeName);
                this.DropNewsList.DataValueField = item.typeId.ToString();
                this.DropNewsList.DataTextField = item.typeName;
                this.DropNewsList.SelectedIndex = 0;
                this.DropNewsList.DataBind();
            }
            if (Request["TypeId"] != null && Request["NewsTitle"] != null && Request["TypeName"] != null)
            {
                int TypeId = int.Parse(Request["TypeId"]);
                string NewsTitle = Request.Params["NewsTitle"].ToString();
                this.TextSearchTitle.Text = Request["TypeName"].ToString();
                DataLiStsearch.DataSource = NewsInfoCRUD.GetNewsParticular(PageNumber, TypeId, NewsTitle);
                DataLiStsearch.DataBind();
            }
            else
            {
                Response.Write("<script language='javasript'>");
                Response.Write("alert(请输入关键字或者选择类型)");
                Response.Write("<script>");
            }
        }
        protected void BtnHomeSearch_Click(object sender, EventArgs e)
        {
            SearchBind();
        }
        public void SearchBind()
        {
            _newsType = NewsInfoCRUD.GetNewsType();
            int TypeId = 0;
            string TypeName = "";
            foreach (var item in _newsType)
            {
                if (this.DropNewsList.SelectedItem.Text == item.typeName)
                {
                    TypeId = item.typeId;
                    TypeName = item.typeName;
                }
            }
            string NewsTitle = this.TxtSearch.Text.Trim();
            Response.Redirect("NewsSearchPage.aspx?TypeId=" + TypeId + "&TypeName=" + TypeName + "&NewsTitle=" + NewsTitle);
        }
    }
}