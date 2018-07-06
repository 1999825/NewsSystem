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
    public partial class NewsParticularPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageBind();
            }
        }
        List<NewsInfo> _news;
        List<NewsTypeInfo> _newsType;
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
            if (Request["newsId"] != null)
            {
                int newsId = int.Parse(Request["newsId"]);
                _news = NewsInfoCRUD.GetNewsSingleInfo(newsId);
                TxtTitle.Text = null;
                TxtTime.Text = null;
                TxtContent.Text = null;
                foreach (var item in _news)
                {
                    TxtTitle.Text = item.newsTitle;
                    TxtTime.Text = item.newsTime.ToString();
                    TxtContent.Text = item.newsContent;
                }
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