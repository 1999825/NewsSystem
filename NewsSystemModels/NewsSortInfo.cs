using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystemModels
{
    public class NewsSortInfo
    {
        //sortId int identity(1,1) constraint PK_newsSortInfo_sortId primary key,--类别编号,主键,自动增长
        //sortName nvarchar(20) not null constraint UQ_newsSortInfo_sortName unique,   --类别名称,唯一约束
        /// <summary>
        /// 类别编号
        /// </summary>
        public int sortId { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string sortName { get; set; }
    }
}
