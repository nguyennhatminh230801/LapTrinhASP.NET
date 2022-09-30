<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cau2.aspx.cs" Inherits="Bai1.Cau2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table_content" border="1">
        <tr>
            <td>
                <p>Mã Nhân Viên</p>
            </td>
            <td>
                <asp:TextBox ID="maNhanVien" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <p>Bậc lương</p>
            </td>
            <td>
                <asp:TextBox ID="bacLuong" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <p>Ngày công</p>
            </td>
            <td>
                <asp:TextBox ID="ngayCong" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <p>Chức vụ</p>
            </td>
            <td>
                <asp:DropDownList ID="chucVu" runat="server">
                    <asp:ListItem Value="truong phong">Trưởng Phòng</asp:ListItem>
                    <asp:ListItem Value="pho truong phong">Phó Trưởng Phòng</asp:ListItem>
                    <asp:ListItem Value="nhan vien"> Trưởng Phòng</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <p>Giới tính</p>
            </td>
            <td>
                <asp:RadioButtonList ID="gioiTinh" runat="server">
                    <asp:ListItem Value="nam">Nam</asp:ListItem>
                    <asp:ListItem Value="nu">Nữ</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td><p>Ngoại ngữ</p></td>
            <td>
                <asp:CheckBoxList ID="checkBoxNgoaiNgu" runat="server">
                    <asp:ListItem Value="tieng Anh">Anh</asp:ListItem>
                    <asp:ListItem Value="tieng Phap">Pháp</asp:ListItem>
                    <asp:ListItem Value="tieng Nga">Nga</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td><p>Tiền Lĩnh</p></td>
            <td><asp:Label ID="lbKetQua" runat="server" Text="0"/></td>
        </tr>
        <tr>
            <td colspan="2" style="align-items: center; justify-content: center;">
                <asp:Button ID="btnKetQua" runat="server" Text="Kết quả" PostBackUrl="~/KetquaCau2.aspx"/>
            </td>
        </tr>
    </table>
</asp:Content>
