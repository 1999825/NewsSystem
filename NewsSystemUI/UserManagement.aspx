<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="NewsSystemUI.UserManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Navigation" runat="server">
    <style>
        .Bigdiv{
            margin:0 auto;
            width:500px;
        }
        
    </style>
    <div class="Bigdiv">
        <asp:GridView AutoGenerateColumns="false" ID="GridView1" runat="server" AutoGenerateRows="False" OnRowCommand="GridView1_RowCommand" Height="116px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="472px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
            <Columns>
                <asp:BoundField DataField="userId" HeaderText="编号" ReadOnly="True" InsertVisible="False" SortExpression="userId" />
                <asp:BoundField DataField="userName" HeaderText="用户名" SortExpression="userName" />
                <asp:BoundField DataField="userPassword" HeaderText="密码" SortExpression="userPassword" />
                <asp:TemplateField HeaderText="操作">
                    <ItemTemplate>
                        <asp:Button CommandName="delete" Text="删除" CommandArgument='<%#Eval("userId")%>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="编辑">
                    <ItemTemplate>
                        <asp:Button Text="编辑" CommandName="edit" CommandArgument='<%#Eval("userId")%>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Button CommandName="update" Text="更新" CommandArgument='<%#Eval("userId")%>' runat="server" />
                        <asp:Button CommandName="cancel" Text="返回" runat="server" />
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF"></EditRowStyle>

            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

            <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

            <RowStyle BackColor="#EFF3FB"></RowStyle>

            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

            <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

            <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

            <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

            <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
        </asp:GridView>
    </div>
</asp:Content>
