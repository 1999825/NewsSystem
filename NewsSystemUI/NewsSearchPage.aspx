<%@ Page Title="" Language="C#" MasterPageFile="~/Indexpage.Master" AutoEventWireup="true" CodeBehind="NewsSearchPage.aspx.cs" Inherits="NewsSystemUI.NewsSearchPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="index" runat="server">
        <style>
            body {
                margin: 0;
                padding: 0;
                font-size: 12px;
            }

            ul {
                margin: 0;
                padding: 0;
                list-style: none;
            }

            table {
                margin-top: 5px;
            }

            .nature-a {
                color: black;
                text-decoration: none;
            }

            .float-left {
                float: left;
            }

            .float-right {
                float: right;
            }

            #main {
                width: 100%;
                min-width: 1200px;
            }

                #main #main-search {
                    width: 100%;
                    min-width: 1200px;
                    height: 50px;
                }

                    #main #main-search > div {
                        margin-top: 17px;
                        margin-right: 10px;
                    }

                #main .main-search-show {
                    width: 400px;
                    min-width: 1200px;
                    height: auto;
                    display: block;
                    margin: 0 auto;
                    padding-top: 40px;
                    padding-left: 70px;
                }

                #main #main-search span {
                    margin-left: 10px;
                }

                    #main #main-search span > a {
                        color: black;
                        text-decoration: none;
                    }

                #main #main-content {
                    width: 100%;
                    min-width: 1200px;
                    height: 500px;
                }

                    #main #main-content .main-content-left {
                        width: 50%;
                        height: 500px;
                    }

                    #main #main-content .main-content-right {
                        width: 50%;
                        height: 500px;
                    }

            .content-li {
                margin-left: 12px;
                margin-top: 10px;
            }

            .content-head-title {
                background-color: #519ff1;
                height: 30px;
                width: 635px;
                color: black;
                padding: 5px 10px 5px 10px;
                border-radius: 5px 5px;
            }

            .search-head-title {
                background-color: #519ff1;
                height: 30px;
                width: 635px;
                color: black;
                padding: 5px 10px 5px 10px;
                border-radius: 5px 5px;
            }

            .main-search-show .returnHome {
                margin-left: 400px;
            }
    </style>
    <script src="JavaScript/jquery-3.2.1.js"></script>
    <div id="main">
        <%--搜索栏--%>
        <div id="main-search">
            <div class="float-left">
                <span>
                    <a href="#" class="nature-a">加入收藏</a>
                </span>
                <span>
                    <a href="#" class="nature-a">设为主页</a>
                </span>
                <span>
                    <a href="Login.aspx" class="nature-a">后台管理</a>
                </span>
            </div>
            <div class="float-right">
                <span>
                    输入关键字：
                    <asp:TextBox ID="TxtSearch" runat="server" />
                </span>
                <asp:DropDownList ID="DropNewsList" runat="server"></asp:DropDownList>
                <asp:Button ID="BtnHomeSearch" OnClick="BtnHomeSearch_Click" Text="搜索" runat="server" />
            </div>
        </div>
        <%--搜索栏--%>
        <%--搜索显示--%>
        <div class="main-search-show">
            <div class="search-head-title" style="margin-left: 150px;">
                <span class="float-left" style="margin-top: 6px; font-size: 14px;">
                    <asp:Label Text="" ID="TextSearchTitle" runat="server" />
                </span>
            </div>
            <div style="margin-top: 5px; margin-left: 150px;">
                <asp:DataList ID="DataLiStsearch" runat="server">
                    <ItemTemplate>
                        <table style="width: 655px; border: 1px solid #666; border-radius: 5px 5px;">
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
            <br />
            <br />
            <a href="NewsHomePage.aspx" class="nature-a returnHome">返回首页</a>
        </div>
        <%--搜索显示--%>
    </div>
</asp:Content>
