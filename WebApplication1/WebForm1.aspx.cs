using ClassLibrary1;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tinhtien_Click(object sender, EventArgs e)
        {
            int send = 0;
            try
            {
                double gio_choi = double.Parse(gio.Text);
                send = 1;

                LoaiCo LoaiGay;
                if (vip.Checked)
                {
                    LoaiGay = LoaiCo.Vip;
                }
                else if (thuong.Checked)
                {
                    LoaiGay = LoaiCo.Thuong;
                }
                else
                {
                    throw new Exception("Chưa chọn loại máy!");
                }
                send = 2;

                bool doathem = doa.Checked;
                send = 3;

                double tongTien = Class1.TinhTongTien(LoaiGay, gio_choi, doathem);

                string ketqua = $"Tổng tiền: {tongTien} VND";
                phaitra.InnerHtml = $"{ketqua}";
            }
            catch (Exception ex)
            {
                switch (send)
                {
                    case 0:
                        phaitra.InnerHtml = "Có lỗi khi nhập số giờ";
                        break;
                    case 1:
                        phaitra.InnerHtml = "Có lỗi khi chọn loại máy";
                        break;
                    case 2:
                        phaitra.InnerHtml = "Có lỗi khi nhập thông tin điều hòa";
                        break;
                    default:
                        phaitra.InnerHtml = $"Có lỗi không xác định: {ex.Message}";
                        break;
                }
            }
        }
    }
}