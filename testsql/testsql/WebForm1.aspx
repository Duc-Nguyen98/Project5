<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="testsql.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <label>
        <br />
        Mã Quyền
        <br />
        </label>
        <asp:TextBox ID="txtxMaQuyen" runat="server"></asp:TextBox>
        <br />
        Tên Đăng Nhập 
        <br />
        <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
        <label>
        <br />
        Mật Khẩu
        <br />
        </label><asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
            <label>
        <br />
        Họ và Tên
        <br />
        </label><asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
        <p>
        <asp:Button ID="btnThem" runat="server" Text="Thêm 
            " OnClick="btnThem_Click" Width="164px" />
        </p>

        <asp:Button ID="btnSua" runat="server" Text="Sửa" 
            OnClick="btnSua_Click" Width="164px" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Xóa" Width="164px" OnClick="Button1_Click"/>
    </form>

    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</body>
</html>
