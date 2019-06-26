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
    public class TaoMoiHoaDonController : ApiController
    {
        [HttpPost]
        public string TaoMoiHoaDon()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                string MaHoaDon = HttpContext.Current.Request.Form["MaHoaDon"];
                string MaKhachHang = HttpContext.Current.Request.Form["MaKhachHang"];
                string MaNhanVien = HttpContext.Current.Request.Form["MaNhanVien"];
                string MaHang = HttpContext.Current.Request.Form["MaHang"];
                string TenHang = HttpContext.Current.Request.Form["TenHang"];
                string DonGia = HttpContext.Current.Request.Form["DonGia"];
                string SoLuong = HttpContext.Current.Request.Form["SoLuong"];
                string NgayMua = HttpContext.Current.Request.Form["NgayMua"];
                string NgayVanChuyen = HttpContext.Current.Request.Form["NgayVanChuyen"];
                string NgayNhanHang = HttpContext.Current.Request.Form["NgayNhanHang"];
                string NoiNhanHang = HttpContext.Current.Request.Form["NoiNhanHang"];
                string MaThanhPho = HttpContext.Current.Request.Form["MaThanhPho"];


                SqlCommand cmd = new SqlCommand("TaoHoaDonMoi", ketnoi);
                cmd.Parameters.AddWithValue("@MaHoaDon", MaKhachHang);
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                cmd.Parameters.AddWithValue("@MaHang", MaHang);
                cmd.Parameters.AddWithValue("@TenHang", TenHang);
                cmd.Parameters.AddWithValue("@DonGia", (DonGia));
                cmd.Parameters.AddWithValue("@SoLuong", (SoLuong));
                cmd.Parameters.AddWithValue("@NoiNhanHang", (NoiNhanHang));
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
