<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="searchCtgr.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/style.css" rel="stylesheet" />
</head>
<body>
    <form id="frmContainer" runat="server">
        <div>
            <h1>Welcome!</h1>
            <asp:Label ID="lblCtgr" runat="server" Text="Category Name"></asp:Label>
            <asp:TextBox ID="txtCtgr" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:GridView ID="grdTable" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" runat="server"></asp:GridView>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
