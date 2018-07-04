using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystemModels
{
    /// <summary>
    /// 新闻信息类
    /// </summary>
    public class NewsInfo
    {
        //newsId int identity(1,1) constraint PK_newsInfo_newsId primary key,         --新闻编号,主键,自动增长
        //typeId int not null references newsTypeInfo(typeId),                         --新闻类型,外键,引用newsTypeInfo表的主键
        //sortId int not null references newsSortInfo(sortId),                         --新闻类别,外键,引用newsSortInfo表的主键
        //newsTitle nvarchar(50) not null,                                             --新闻标题,非空
        //newsContent text not null,                                                  --新闻内容,非空
        //newsTime datetime default getdate(),                       --新闻发布时间,
        /// <summary>
        /// 新闻编号
        /// </summary>
        public int nwesId { get; set; }
        /// <summary>
        /// 新闻类型
        /// </summary>
        public int typeId { get; set; }
        /// <summary>
        /// 新闻类别
        /// </summary>
        public int sortId { get; set; }
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string newsTitle { get; set; }
        /// <summary>
        /// 新闻内容
        /// </summary>
        public string newsContent { get; set; }
        /// <summary>
        /// 新闻发布时间
        /// </summary>
        public DateTime newsTime { get; set; }
    }
}
