<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsHome.aspx.cs" Inherits="NewsSystemUI.NewsHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>首页</title>
    <style>
        body{
            margin:0;
            padding:0;
            font-size:12px;
        }
        ul{
            margin:0;
            padding:0;
            list-style:none;
        }
        .nature-a{
            color:black;
            text-decoration:none;
        }
        .float-left{
            float:left;
        }
        .float-right{
            float:right;
        }
        #home-main{
            width:100%;
            min-width:1200px;
        }
            #home-main #main-search{
                width:100%;
                min-width:1200px;
                height:50px;
            }
            #home-main #main-search>div{
                margin-top:17px;
                margin-right: 10px;
            }
                #home-main #main-search span{
                    margin-left:10px;
                }
                #home-main #main-search span>a{
                    color:black;
                    text-decoration:none;
                }
            #home-main #main-content{
                width:100%;
                min-width:1200px;
                height:500px;
            }
                #home-main #main-content .main-content-left{
                    width:50%;
                    height:500px;
                }
                 #home-main #main-content .main-content-right{
                    width:50%;
                    height:500px;
                }
        .main-content-li{
            margin-left:12px;
        }
           .content-head-title{
                background-color: #519ff1;
                height: 30px;
                width: 635px;
                color:black;
                padding: 5px 10px 5px 10px;
                border-radius: 5px 5px;
           }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--首页主体--%>
            <div id="home-main">
                <%--搜索栏--%>
                <div id="main-search">
                    <div class="float-left">
                        <span>
                            <a href="#">加入收藏</a>
                        </span>
                        <span>
                            <a href="#">设为主页</a>
                        </span>
                        <span>
                            <a href="Login.aspx">后台管理</a>
                        </span>
                    </div>
                    <div class="float-right">
                        <span>
                            输入关键字：
                            <asp:TextBox ID="TxtSearch" runat="server" />
                            <asp:DropDownList ID="DropNewsList" runat="server"></asp:DropDownList>
                            <asp:Button ID="BtnHomeSearch" Text="搜索" runat="server" />
                        </span>
                    </div>
                </div>
                <%--搜索栏--%>
                <%--主体内容--%>
                <div id="main-content">
                    <div class="float-left main-content-left">
                        <ul>
                            <li class="main-content-li">
                                <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">环球经济</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="#">更多</a>
                                </div>
                                <div>
                                    <asp:GridView ID="GridViewHqjj" runat="server"></asp:GridView>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="float-right main-content-right">
                        <ul>
                            <li>
                                <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">军事世界</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="#">更多</a>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <%--主体内容--%>
            </div>
            <%--首页主体--%>
        </div>
    </form>
</body>
</html>
