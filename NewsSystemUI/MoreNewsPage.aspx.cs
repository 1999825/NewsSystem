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
    public partial class MoreNewsPage : System.Web.UI.Page
    {
        List<NewsTypeInfo> _newsType;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageBind();
            }
        }
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
            if (Request["typeId"] !=null && Request["name"] != null)
            {
                int typeId = int.Parse(Request["typeId"]);
                this.TextSearchTitle.Text = Request["name"];
                this.DataLiStsearch.DataSource = NewsInfoCRUD.GetNewsMoreInfo(typeId);
                this.DataLiStsearch.DataBind();
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