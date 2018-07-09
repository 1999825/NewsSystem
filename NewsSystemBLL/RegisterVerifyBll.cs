using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSystemModels;
using NewsSystemDAL;
using System.Data.SqlClient;
namespace NewsSystemBLL
{
    public class RegisterVerifyBll
    {
        public static bool RegisterOK(UserInfo us)
        {
            string sql = $"select*from userInfo where userName='{us.userName}'and userPassword='{us.userPassword}'";
            return RegisterVerifyDal.shanh(sql);
        }
    }
}
  