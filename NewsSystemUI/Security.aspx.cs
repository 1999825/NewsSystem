using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        HttpCookie cookie = new HttpCookie("code");
        protected void Page_Load(object sender, EventArgs e)
        {
            GetCheckCode(GetCodeStr());
        }
        public string GetCodeStr()
        {
            string Code = "qwertyupasdfghjkzxcvbnmQWERTYUPASDFGHJKLZXCVBNM0123456789";
            Random random = new Random();
            string codeStr = "";
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(0, Code.Length - 1);
                codeStr += Code.Substring(index, 1);
            }
            cookie.Value = codeStr;
            cookie.Expires = DateTime.Now.AddMinutes(2);
            Response.Cookies.Add(cookie);
            return codeStr;
        }
        public void GetCheckCode(string codeStr)
        {
            //string codeStr = "红尘往事";

            //创建一个100*50的空白位图
            using (Bitmap img = new Bitmap((int)Math.Ceiling(codeStr.Length * 16f), 25))
            {
                //创建Graphics绘图片 加载img
                using (Graphics g = Graphics.FromImage(img))
                {
                    Random random = new Random();
                    //将整个绘图面填充背景色
                    g.Clear(Color.White);

                    //两点确定一条直线
                    for (int i = 0; i < 5; i++)
                    {
                        int x1 = random.Next(img.Width);
                        int x2 = random.Next(img.Width);
                        int y1 = random.Next(img.Height);
                        int y2 = random.Next(img.Height);
                        //随机的画几条直线
                        g.DrawLine(new Pen(Color.Black), x1, x2, y1, y2);
                    }
                    //创建一个字体对象
                    Font font = new Font("楷书", 15, FontStyle.Italic);

                    //创建一个可以渐变的画刷
                    LinearGradientBrush brush = new LinearGradientBrush
                        (new Rectangle(0, 0, img.Width, img.Height), Color.Black, Color.Red, 1.2f, true);

                    //以指定的字体和画刷在指定的位置画指定字符串
                    g.DrawString(codeStr, font, brush, 2, 2);

                    //画一个矩形边框
                    g.DrawRectangle(new Pen(Color.Aqua), 0, 0, img.Width - 1, img.Height - 1);

                    //随机的出现噪点
                    for (int i = 0; i < 100; i++)
                    {
                        int x = random.Next(img.Width);
                        int y = random.Next(img.Height);
                        //设置img的指定位置的像素颜色
                        img.SetPixel(x, y, Color.FromArgb(random.Next()));
                    }

                    //创建一个流对象
                    MemoryStream ms = new MemoryStream();

                    //将img以gif的格式保存在流中
                    img.Save(ms, ImageFormat.Gif);
                    //清除缓存中流的输出类容
                    Response.ClearContent();
                    //以image/Gif的格式进行响应
                    Response.ContentType = "image/Gif";

                    //将二进制字符串写入http输出流
                    Response.BinaryWrite(ms.ToArray());
                }
            }
        }
    }
}