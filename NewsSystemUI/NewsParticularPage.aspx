<%@ Page Title="" Language="C#" MasterPageFile="~/Indexpage.Master" AutoEventWireup="true" CodeBehind="NewsParticularPage.aspx.cs" Inherits="NewsSystemUI.NewsParticularPage" %>
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
                    width: 100%;
                    min-width: 1200px;
                    height: 300px;
                    display: block;
                    padding: 10px 10px 10px 12%;
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
                    text-align:center;
                    height: auto;
                }

                #main-content .content-title{
                    font-size:30px;
                    color:black;
                }
                #main-content .content-time{
                    color:#808080;
                    font-size:12px;
                }
                #main-content .content-text{
                    font-size:14px;
                    color:#808080;
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
        <%--详细信息--%>
        <div id="main-content">
            <asp:Label Text="" ID="TxtTitle" CssClass="content-title" runat="server" />
            <br />
            <br />
            <asp:Label Text="" ID="TxtTime" CssClass="content-time" runat="server" />
            <br />
            <br />
            <asp:Label Text="" ID="TxtContent" CssClass="content-text" runat="server" />
            <br />
            <br />
            <a href="NewsHomePage.aspx" class="nature-a returnHome">返回首页</a>
        </div>
        <%--详细信息--%>
    </div>
</asp:Content>
