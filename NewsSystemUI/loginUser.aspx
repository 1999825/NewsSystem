<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginUser.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/StyleSheet1.css" rel="stylesheet" />
    <script src="JavaScript/jquery-3.2.1.js"></script>
    <script src="JavaScript/jquery.cookie.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="Register_one">
                <div class="divbiaoti">
                    <h1 class="h1tou">新闻发布系统</h1>
                </div>
                <div class="divhtr">
                    <label>用户名</label>
                    <asp:TextBox CssClass="txtname1" ID="txtname" runat="server"></asp:TextBox><br />
                    <label>密&nbsp;&nbsp;&nbsp;码</label>
                    <asp:TextBox ID="txtpwd" CssClass="txtname1" TextMode="Password" runat="server"></asp:TextBox><br />
                    <asp:TextBox CssClass="txtnam" ID="txtCode" runat="server" />
                    <asp:Image CssClass="img1" ID="imgCode" ImageUrl="Security.aspx" runat="server" /><br />
                    <asp:CheckBox CssClass="ckcone" ID="CheckBox1" runat="server" />记住用户名和密码<br />
                    <asp:Button CssClass="btn1" OnClick="btnRegister_Click" ID="btnRegister" runat="server" Text="确定" />
                    <asp:Button CssClass="btn2" ID="btnCancel" runat="server" Text="取消" />
                </div>
            </div>
        </div>
    </form>
    <script>
        $(function () {
            $("#imgCode").click(function () {
                $("#imgCode").attr("src", "Security.aspx?id=" + Math.random());
            })
            $(".btn1").click(function (e) {
                var clientCode = $("#txtCode").val();
                var code = $.cookie("code");
                if (clientCode.toUpperCase() != code.toUpperCase()) {
                    alert("验证码错误");
                    return false;
                    //e.preventDefault();
                }
                //alert(code);
            })
        })
    </script>
</body>
</html>
