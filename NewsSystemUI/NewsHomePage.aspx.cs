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
    public partial class NewsHomePage : System.Web.UI.Page
    {
        List<NewsTypeInfo> _newsType;
        public static bool IsFirst = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HomeBind();
            }
            else
            {
                IsFirst = false;
            }
        }
        public static int PageNumber = 1;
        public static int NewsTypeId = 0;
        public void HomeBind()
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

            //环球经济
            NewsTypeId = 1;
            this.DetaListHqjj.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, NewsTypeId);
            this.DetaListHqjj.DataBind();
            //环球经济

            //军事世界
            NewsTypeId = 2;
            this.DataListJssj.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, NewsTypeId);
            this.DataListJssj.DataBind();
            //军事世界

            //科学技术
            NewsTypeId = 3;
            this.DataListKxjs.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, NewsTypeId);
            this.DataListKxjs.DataBind();
            //科学技术

            //生活理财
            NewsTypeId = 4;
            this.DataListShlc.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, NewsTypeId);
            this.DataListShlc.DataBind();
            //生活理财

            //社会百态
            NewsTypeId = 5;
            this.DataListShbt.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, NewsTypeId);
            this.DataListShbt.DataBind();
            //社会百态

            //世界体育
            NewsTypeId = 6;
            this.DataListSjty.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, NewsTypeId);
            this.DataListSjty.DataBind();
            //世界体育

            //娱乐综艺
            NewsTypeId = 7;
            this.DataListYlzy.DataSource = NewsInfoCRUD.GetNewsInfo(PageNumber, NewsTypeId);
            this.DataListYlzy.DataBind();
            //娱乐综艺
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