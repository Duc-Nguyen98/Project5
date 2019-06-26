using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web;

namespace API.Controllers
{
    public class TaoMoiKhachHangController : ApiController
    {
        [HttpPost]
        public string TaoMoiKhachHang()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                string MaKhachHang = HttpContext.Current.Request.Form["MaKhachHang"];
                string TenKhachHang = HttpContext.Current.Request.Form["TenKhachHang"];
                string SoDienThoai = HttpContext.Current.Request.Form["SoDienThoai"];
                string GioiTinh = HttpContext.Current.Request.Form["GioiTinh"];
                string DiaChi = HttpContext.Current.Request.Form["DiaChi"];
                string Email = HttpContext.Current.Request.Form["Email"];
                string MaThanhPho = HttpContext.Current.Request.Form["MaThanhPho"];


                SqlCommand cmd = new SqlCommand("TaoKhachHangMoi", ketnoi);
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Email", (Email));
                cmd.Parameters.AddWithValue("@MaThanhPho", (MaThanhPho));


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                return "Đã Thêm Mới Thành Công";
            }
            catch (Exception ex)
            {
                return ex.ToString();
                throw;
            }
        }
    }
}
