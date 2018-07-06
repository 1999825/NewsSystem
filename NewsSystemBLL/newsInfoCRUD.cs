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
        public static DataTable GetNewsInfo(int pageNumber, int typeId)
        {
            string sql = $"exec proc_newsInfo_Data {pageNumber},5,{typeId}";
            DataTable table = SQLHelper.GetDataTable(sql, false);
            return table;
        }

        public static List<NewsTypeInfo> GetNewsType()
        {
            string sql = "select * from newsTypeInfo";
            SqlDataReader reader = SQLHelper.ExectueReader(sql,false);
            List<NewsTypeInfo> list = new List<NewsTypeInfo>();
            while (reader.Read())
            {
                NewsTypeInfo type = new NewsTypeInfo();
                type.typeId = (int)reader["typeId"];
                type.typeName = reader["typeName"].ToString();
                list.Add(type);
            }
            return list;
        }

        public static List<NewsInfo> GetNewsSingleInfo(int newsId)
        {
            string sql = $"select * from newsInfo where newsId={newsId}";
            SqlDataReader reader = SQLHelper.ExectueReader(sql, false);
            List<NewsInfo> list = new List<NewsInfo>();
            while (reader.Read())
            {
                NewsInfo news = new NewsInfo();
                news.nwesId = (int)reader["newsId"];
                news.newsTitle = reader["newsTitle"].ToString();
                news.newsTime = (DateTime)reader["newsTime"];
                news.newsContent = reader["newsContent"].ToString();
                list.Add(news);
            }
            return list;
        }

        public static DataTable GetNewsMoreInfo(int typeId)
        {
            string sql = $"select * from newsInfo where typeId={typeId}";
            DataTable table = SQLHelper.GetDataTable(sql, false);
            return table;
        }

        public static DataTable GetNewsParticular(int pageNumber, int typeId, string newsTitle)
        {
            string sql = $"exec proc_newsInfo_News {pageNumber},5,'{newsTitle}',{typeId}";
            DataTable table = SQLHelper.GetDataTable(sql, false);
            return table;
        }
    }
}
