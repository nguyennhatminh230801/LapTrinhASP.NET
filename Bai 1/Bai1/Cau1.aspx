<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cau1.aspx.cs" Inherits="Bai1.Cau1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main_content">
        <h2 class="header purple_header">Nhập hồ sơ cho cán bộ</h2>
        <h3 class="header second_header">Đào tạo bồi dưỡng chuyên môn nghiệp vụ</h3>
        <div class="big_category">
            <h3 class="big_category_content header">Thông tin cá nhân</h3>
        </div>
        <div class="table_content">
            <table style="width: 100%">
                <tr class="table_row">
                    <td style="width: 50%; float: right;">*Họ và tên:</td>
                    <td style="width: 50%;">
                        <input type="text" size="3000" /></td>
                </tr>
                <tr class="table_row">
                    <td style="width: 50%; float: right;">*Ngày Sinh:</td>
                    <td style="width: 50%;">
                        <input type="datetime" size="3000" /></td>
                </tr>
                <tr class="table_row">
                    <td style="width: 50%; float: right;">*Quê quán:</td>
                    <td style="width: 50%;">
                        <input type="text" size="3000" /></td>
                </tr>
            </table>
        </div>
        <div class="big_category">
            <h3 class="big_category_content header">Trình độ học vấn</h3>
        </div>
        <div class="inner_content">
            <div class="inner_content_row">
                <p class="title">*Trình độ văn hóa</p>
                <input type="text" size="300" />
                <p class="title">*Học vị</p>
                <select>
                    <option>Option 1</option>
                </select>
                <p class="title">*Học hàm</p>
                <select>
                    <option>Option 1</option>
                </select>
            </div>
            <div class="inner_content_row">
                <p class="title">*Lý luận chính trị</p>
                <input type="text" size="300" />
            </div>
            <div class="inner_content_row">
                <p class="title">*Ngoại ngữ</p>
                <input type="checkbox" />
                <p class="title">Anh</p>
                <input type="checkbox"/>
                <p class="title">Pháp</p>
                <input type="checkbox"/>
                <p class="title">Nga</p>
            </div>
        </div>
        <div class="big_category">
            <h3 class="big_category_content header">Tóm tắt quá trình công tác</h3>
        </div>
    </div>
</asp:Content>
