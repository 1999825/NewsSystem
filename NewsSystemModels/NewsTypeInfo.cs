using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystemModels
{
    /// <summary>
    /// 新闻类型类
    /// </summary>
    public class NewsTypeInfo
    {
        //typeId int identity(1,1) constraint PK_newsTypeInfo_typeId primary key,     --类型编号,主键,自动增长
        //typeName nvarchar(20) not null constraint UQ_newsTypeInfo_typeName unique,   --类型名称,唯一约束
        //remark nvarchar(50)                                                          --类型备注
        /// <summary>
        /// 类型编号
        /// </summary>
        public int typeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string typeName { get; set; }
        /// <summary>
        /// 类型备注
        /// </summary>
        public string remark { get; set; }
    }
}
