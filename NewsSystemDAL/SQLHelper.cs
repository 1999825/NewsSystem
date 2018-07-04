using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSystemModels;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NewsSystemDAL
{
    public class SQLHelper
    {
        //从配置文件中读取连接字符串
        private static string connStr =
            ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 通用的获取SqlCommand对象
        /// </summary>
        /// <param name="sql">SQL语句 或 存储过程名字</param>
        /// <param name="isProc">是否为存储过程</param>
        /// <param name="paras">sql语句的参数或存储过程的参数</param>
        /// <returns></returns>
        private static SqlCommand GetSqlCommand(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (isProc)
            {
                //如果是存储过程，将cmd.CommandType属性改为System.Data.CommandType.StoredProcedure;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }
            if (paras.Length > 0)
            {
                //如果参数长度大于0 向cmd的Parameters 中添加
                cmd.Parameters.AddRange(paras);
            }
            cmd.Connection.Open();
            return cmd;
        }

        /// <summary>
        /// 返回增、删、改是否执行成功
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static bool ExectueNonQuery(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            using (SqlCommand cmd = GetSqlCommand(sql, isProc, paras))
            {
                try
                {
                    return cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 返回多行多列的结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExectueReader(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            SqlCommand cmd = GetSqlCommand(sql, isProc, paras);
            try
            {
                return cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 返回第一行第一列的结果
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExectueScalar(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            using (SqlCommand cmd = GetSqlCommand(sql, isProc, paras))
            {
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// 返回一张datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, bool isProc, params SqlParameter[] paras)
        {
            using (SqlCommand cmd = GetSqlCommand(sql, isProc, paras))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
        }
    }
}
