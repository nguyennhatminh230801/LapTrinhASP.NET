<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KetquaCau2.aspx.cs"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table border="1">
        <tr>
            <td>
                <p>Mã Nhân Viên</p>
            </td>
            <td>
                <asp:Label ID="maNhanVien" runat="server" Text="0" Width="500" /></td>
        </tr>
        <tr>
            <td>
                <p>Bậc lương</p>
            </td>
            <td>
                <asp:Label ID="bacLuong" runat="server" Text="0" Width="500"/></td>
        </tr>
        <tr>
            <td>
                <p>Thực lĩnh</p>
            </td>
            <td>
                <asp:Label ID="ngayCong" runat="server" Text="0" Width="500"/></td>
        </tr>
    </table>
</asp:Content>
