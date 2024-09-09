<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính tiền bàn BI-A</title>
</head>
<body>
    <form id="form1" runat="server" class="form-container">
        <div class="content-wrapper">
            <h2 class="title">Tính tiền bàn Bi-a</h2>
            
            <div class="input-group">
                <label >Số giờ chơi:</label>
                <asp:TextBox ID="gio" runat="server" CssClass="input-box" ></asp:TextBox>
            </div>

            <div class="input-group">
                <label>Loại gậy:</label>
               <div class="checkbox-group">
                    <asp:RadioButton ID="thuong" runat="server" CssClass="checkbox" Text="Gậy thường (30.000đ/giờ)" GroupName="LoaiGay" />
                    <asp:RadioButton ID="vip" runat="server" CssClass="checkbox" Text="Gậy VIP (50.000đ/giờ)" GroupName="LoaiGay" />
                </div>

            </div>

            <div class="input-group">
                <label>Sử dụng thêm doa:</label>
                <asp:CheckBox ID="doa" runat="server" CssClass="checkbox" Text="Thêm doa (10.000đ/giờ)" />
            </div>

            <div class="input-group">
                <asp:Button ID="tinhtien" runat="server" CssClass="btn-calculate" Text="Tính tiền" OnClick="tinhtien_Click" />
            </div>
            <div id="phaitra" runat="server"></div>
        </div>
    </form>
</body>
</html>
