<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="HOANGTUYENMILKTEE.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload" runat="server" />
            <asp:Button ID="btnGui" runat="server" Text="Gửi" OnClick="btnGui_Click" />
        </div>
    </form>
</body>
</html>
