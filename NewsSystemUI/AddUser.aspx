<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="NewsSystemUI.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
   
<asp:Content ID="Content2" ContentPlaceHolderID="Navigation" runat="server">
         <style>
            /** {
    padding: 0;
    margin: 0;
}
body {
    width: 100%;
    height: 100%;
    font-family: 'Open Sans',sans-serif;
    margin: 0;
    background-color: #4A374A;
}*/  
#AddUser{
   width:300px;
   height:600px;
   margin:0 auto;

}
#Headline{
    width:300px;
    height:140px;
    text-align:center;
}
#BodyContent{
    width:300px;
    height:400px;
}
#Headline h1 {
    color: #0094ff;
    text-shadow: 0 0 10px;
    letter-spacing: 1px;
    text-align: center;
}
.addbiao {
    
    font-size: 2em;
    margin: 0.67em 0;
}
.btn1 {
    width: 100px;
    min-height: 15px;
    display: block;
    background-color: #4a77d4;
    border: 1px solid #3762bc;
    color: #fff;
    padding: 2px 10px;
    font-size: 15px;
    line-height: normal;
    border-radius: 5px;
    margin-top: 10px;
 
}
.btnright{
    float:right;
}
.btnleft{
    float:left;
}
.txtyiyang{
    width: 278px;   
    height: 18px;   
    margin-bottom: 10px;   
    outline: none;   
    padding: 10px;   
    font-size: 13px;   
    color: #fff;   
    text-shadow:1px 1px 1px;   
    border-top: 1px solid #312E3D;   
    border-left: 1px solid #312E3D;   
    border-right: 1px solid #312E3D;   
    border-bottom: 1px solid #56536A;   
    border-radius: 4px;   
    background-color: #2D2D3F; 
}
.yangshi {
    font-family: FZShuTi;
    font-size:21px;
    color:#ff006e;
}
</style>     
            <div id="AddUser">
                <div id="Headline"><h1 class="addbiao">添加用户</h1></div>
                <div id="BodyContent">
                    <asp:TextBox CssClass="txtyiyang" placeholder="用户名" ID="txtName"  runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator CssClass="yangshi" EnableClientScript="false" ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ControlToValidate="txtName" ErrorMessage="账号不能为空"></asp:RequiredFieldValidator><br />
                    <asp:TextBox CssClass="txtyiyang" placeholder="密码" ID="txtPwd"  runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator CssClass="yangshi" EnableClientScript="false" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator><br />
                    <asp:TextBox CssClass="txtyiyang" placeholder="确认密码" ID="txtRepetPwd" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator CssClass="yangshi" EnableClientScript="false" ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRepetPwd" ErrorMessage="重复密码不能为空"></asp:RequiredFieldValidator>
                    <asp:CompareValidator CssClass="yangshi" EnableClientScript="false" ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtRepetPwd" ErrorMessage="两次密码不一致"></asp:CompareValidator><br />
                    <asp:Button CssClass="btn1 btnleft" OnClick="Button1_Click"  ID="Button1" Causevalidate="false"  runat="server" Text="确定" />
                    <asp:Button CssClass="btn1 btnright" ID="Button2" runat="server" Text="取消" />
                </div>
            </div>
</asp:Content>
