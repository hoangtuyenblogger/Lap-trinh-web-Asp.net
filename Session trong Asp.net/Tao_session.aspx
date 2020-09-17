<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tao_session.aspx.cs" Inherits="HOANGTUYENMILKTEE.Tao_session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_Hoten" runat="server" Text="Họ tên:"></asp:Label>
            <br />
            <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnTao_session" runat="server" Text="Tạo sesion" OnClick="btnTao_session_Click" />
        </div>
    </form>
</body>
</html>
