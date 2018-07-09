using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace NewsSystemDAL
{
    public class RegisterVerifyDal
    {
        
        public static bool shanh(string sql)
        {
          
            if (SQLHelper.ExectueScalar(sql, false) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
