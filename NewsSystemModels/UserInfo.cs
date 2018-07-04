using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystemModels
{
    /// <summary>
    /// 用户信息类
    /// </summary>
    public class UserInfo
    {
        //userId int identity(1,1) constraint PK_userInfo_userId primary key,   --用户编号,主键,自动增长
        //userName nvarchar(20) not null constraint UQ_userInfo_userName unique, --用户名,唯一约束
        //userPassword nvarchar(20) not null                                     --密码,登录密码
        /// <summary>
        /// 用户编号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string userPassword { get; set; }
    }
}
