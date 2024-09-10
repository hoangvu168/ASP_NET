using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ClassLibrary1;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                bool themdoa;
                try
                {
                    string jsonString = new System.IO.StreamReader(Request.InputStream).ReadToEnd();

                    var data = JsonConvert.DeserializeObject<Dictionary<string, double>>(jsonString);

                    double gay = data["gay"];
                    double gio = data["gio"];
                    double doa = data["doa"];
                    LoaiCo laoigay = (gay == 1) ? LoaiCo.Vip : LoaiCo.Thuong;
                    if (doa == 1)
                    {
                        themdoa = true;
                    }
                    else
                    {
                        themdoa= false;
                    }
                    double result = Class1.TinhTongTien(laoigay, gio, themdoa);
                    Response.ContentType = "application/json";
                    Response.Write(JsonConvert.SerializeObject(result));
                }
                catch (Exception ex)
                {
                    Response.Write("Lỗi: " + ex.Message);
                }
            }
        }
    }
}