using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NewsSystemDAL;
using NewsSystemModels;
namespace NewsSystemBLL
{
    public class AddUserBll
    {
        public static DataTable GetTable()
        {
            string sql = "select * from userInfo";
            return SQLHelper.GetDataTable(sql, false);
        }
        public static bool AddUserOK(UserInfo info)
        {
            string sql = $"insert into userInfo values('{info.userName}','{info.userPassword}')";
            return SQLHelper.ExectueNonQuery(sql);
        }
        public static bool DeleteUserOK(UserInfo user)
        {
            string sql = $"delete from userInfo where userId={user.userId}";
            return SQLHelper.ExectueNonQuery(sql);
        }
        public static bool UpdateUserOK(UserInfo user)
        {
            string sql = $"update userInfo set userName='{user.userName}',userPassword='{user.userPassword}'where userId={user.userId}";
            return SQLHelper.ExectueNonQuery(sql);
        }
    }
}
