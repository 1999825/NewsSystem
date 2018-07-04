using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSystemModels;
using NewsSystemDAL;
using System.Data;
using System.Data.SqlClient;

namespace NewsSystemBLL
{
    public class NewsInfoCRUD
    {
        public static List<NewsInfo> GetNewsInfo(int pageNumber, int typeId)
        {
            string sql = $"exec proc_newsInfo_Data {pageNumber},5,{typeId}";
            SqlDataReader reader = SQLHelper.ExectueReader(sql, false);
            List<NewsInfo> table = new List<NewsInfo>();
            NewsInfo news;
            while (reader.Read())
            {
                news = new NewsInfo();
                news.nwesId = (int)reader["newsId"];
                news.newsTitle = reader["newsTitle"].ToString();
                news.newsTime = (DateTime)reader["newsTime"];
                table.Add(news);
            }
            return table;
        }
    }
}
