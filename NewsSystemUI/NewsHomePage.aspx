<%@ Page Title="" Language="C#" MasterPageFile="~/Indexpage.Master" AutoEventWireup="true" CodeBehind="NewsHomePage.aspx.cs" Inherits="NewsSystemUI.NewsHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="index" runat="server">
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
        table{
            margin-top:5px;
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
            margin-top: 10px;
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
    <script src="JavaScript/jquery-3.2.1.js"></script>
    <script>
        
    </script>
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
                        </span>
                        <asp:DropDownList ID="DropNewsList" runat="server"></asp:DropDownList>
                        <asp:Button ID="BtnHomeSearch" CssClass="HomeSearch" OnClick="BtnHomeSearch_Click" Text="搜索" runat="server" />
                    </div>
                </div>
                <%--搜索栏--%>
                <%--主体内容--%>
                <div id="main-content">
                    <div class="float-left main-content-left">
                        <ul>
                            <%--环球经济--%>
                           <li class="main-content-li">
                               <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">环球经济</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="MoreNewsPage.aspx?typeId=1&name=环球经济">更多</a>
                                </div>
                                <div style="margin-top:5px;">
                                    <asp:DataList ID="DetaListHqjj" runat="server">
                                        <ItemTemplate>
                                            <table style="width:655px;border:1px solid #666;border-radius: 5px 5px;">
                                                <tr>
                                                    <td class="float-left">
                                                        <a href="NewsParticularPage.aspx?NewsId=<%#Eval("newsId") %>" class="nature-a"><%#Eval("newsTitle") %></a>
                                                    </td>
                                                    <td class="float-right"><%#Eval("newsTime") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </li>
                            <%--环球经济--%>
                            <%--科学技术--%>
                            <li class="main-content-li">
                               <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">科学技术</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="MoreNewsPage.aspx?typeId=3&name=科学技术">更多</a>
                                </div>
                                <div style="margin-top:5px;">
                                    <asp:DataList ID="DataListKxjs" runat="server">
                                        <ItemTemplate>
                                            <table style="width:655px;border:1px solid #666;border-radius: 5px 5px;">
                                                <tr>
                                                    <td class="float-left">
                                                        <a href="NewsParticularPage.aspx?NewsId=<%#Eval("newsId") %>" class="nature-a"><%#Eval("newsTitle") %></a>
                                                    </td>
                                                    <td class="float-right"><%#Eval("newsTime") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </li>
                            <%--科学技术--%>
                            <%--社会百态--%>
                            <li class="main-content-li">
                               <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">社会百态</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="MoreNewsPage.aspx?typeId=5&name=社会百态">更多</a>
                                </div>
                                <div style="margin-top:5px;">
                                    <asp:DataList ID="DataListShbt" runat="server">
                                        <ItemTemplate>
                                            <table style="width:655px;border:1px solid #666;border-radius: 5px 5px;">
                                                <tr>
                                                    <td class="float-left">
                                                        <a href="NewsParticularPage.aspx?NewsId=<%#Eval("newsId") %>" class="nature-a"><%#Eval("newsTitle") %></a>
                                                    </td>
                                                    <td class="float-right"><%#Eval("newsTime") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </li>
                            <%--社会百态--%>
                            <%--娱乐综艺--%>
                            <li class="main-content-li">
                               <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">娱乐综艺</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="MoreNewsPage.aspx?typeId=7&name=娱乐综艺">更多</a>
                                </div>
                                <div style="margin-top:5px;">
                                    <asp:DataList ID="DataListYlzy" runat="server">
                                        <ItemTemplate>
                                            <table style="width:655px;border:1px solid #666;border-radius: 5px 5px;">
                                                <tr>
                                                    <td class="float-left">
                                                        <a href="NewsParticularPage.aspx?NewsId=<%#Eval("newsId") %>" class="nature-a"><%#Eval("newsTitle") %></a>
                                                    </td>
                                                    <td class="float-right"><%#Eval("newsTime") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </li>
                            <%--娱乐综艺--%>
                        </ul>
                    </div>
                    <div class="float-right main-content-right">
                        <ul>
                            <%--军事世界--%>
                            <li class="main-content-li">
                               <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">军事世界</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="MoreNewsPage.aspx?typeId=2&name=军事世界">更多</a>
                                </div>
                                <div style="margin-top:5px;">
                                    <asp:DataList ID="DataListJssj" runat="server">
                                        <ItemTemplate>
                                            <table style="width:655px;border:1px solid #666;border-radius: 5px 5px;">
                                                <tr>
                                                    <td class="float-left">
                                                        <a href="NewsParticularPage.aspx?NewsId=<%#Eval("newsId") %>" class="nature-a"><%#Eval("newsTitle") %></a>
                                                    </td>
                                                    <td class="float-right"><%#Eval("newsTime") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </li>
                            <%--军事世界--%>
                            <%--生活理财--%>
                            <li class="main-content-li">
                               <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">生活理财</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="MoreNewsPage.aspx?typeId=4&name=生活理财">更多</a>
                                </div>
                                <div style="margin-top:5px;">
                                    <asp:DataList ID="DataListShlc" runat="server">
                                        <ItemTemplate>
                                            <table style="width:655px;border:1px solid #666;border-radius: 5px 5px;">
                                                <tr>
                                                    <td class="float-left">
                                                        <a href="NewsParticularPage.aspx?NewsId=<%#Eval("newsId") %>" class="nature-a"><%#Eval("newsTitle") %></a>
                                                    </td>
                                                    <td class="float-right"><%#Eval("newsTime") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </li>
                            <%--生活理财--%>
                            <%--世界体育--%>
                            <li class="main-content-li">
                               <div class="content-head-title">
                                    <span class="float-left" style="margin-top:6px;font-size:14px;">世界体育</span>
                                    <a class="float-right nature-a" style="margin-top:8px;" href="MoreNewsPage.aspx?typeId=6&name=世界体育">更多</a>
                                </div>
                                <div style="margin-top:5px;">
                                    <asp:DataList ID="DataListSjty" runat="server">
                                        <ItemTemplate>
                                            <table style="width:655px;border:1px solid #666;border-radius: 5px 5px;">
                                                <tr>
                                                    <td class="float-left">
                                                        <a href="NewsParticularPage.aspx?NewsId=<%#Eval("newsId") %>" class="nature-a"><%#Eval("newsTitle") %></a>
                                                    </td>
                                                    <td class="float-right"><%#Eval("newsTime") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </div>
                            </li>
                            <%--世界体育--%>
                        </ul>
                    </div>
                </div>
                <%--主体内容--%>
            </div>
            <%--首页主体--%>
</asp:Content>
