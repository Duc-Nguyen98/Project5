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
    public class HoaDonController : ApiController
    {
        [HttpGet]
        public DataTable BangHoaDon()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();

            SqlCommand thuchienlenh = new SqlCommand("SELECT HoaDon.MaHoaDon,MaKhachHang,MaNhanVien,dbo.HoaDon.MaHang,dbo.HoaDon.TenHang,DonGia,dbo.ChiTietHoaDon.SoLuong,CONVERT(VARCHAR(10),NgayMua,103) AS NgayMua ,CONVERT(VARCHAR(10),NgayVanChuyen,103)AS NgayVanChuyen,CONVERT(VARCHAR(10),NgayNhanHang,103) AS NgayNhanHang,NoiNhanHang,MaThanhPho FROM dbo.HoaDon INNER JOIN dbo.ChiTietHoaDon ON ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon", ketnoi);
            SqlDataReader reader = thuchienlenh.ExecuteReader(); // Hiển thị dữ liệu ra màn hình 
            DataTable BangHoaDon = new DataTable(); // Lấy dữ liệu từ database
            BangHoaDon.Load(reader);
            return BangHoaDon;
        }

        // Xoa HoaDon
        [HttpDelete]
        public string XoaHoaDon()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                // thuc hien lenh tren nay
                string MaHoaDon = HttpContext.Current.Request.Form["MaHoaDon"];


                SqlCommand cmd = new SqlCommand("XoaHoaDon", ketnoi);
                cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                return "OK";
            }
            catch (Exception)
            {
                return "deo ok";
                throw;
            }
        }

        [HttpPost]
        public string CapNhatHoaDon()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                string MaHoaDon = HttpContext.Current.Request.Form["MaHoaDon"];
                string DonGia = HttpContext.Current.Request.Form["DonGia"];
                string SoLuong = HttpContext.Current.Request.Form["SoLuong"];
                string NgayMua = HttpContext.Current.Request.Form["NgayMua"];
                string NgayVanChuyen = HttpContext.Current.Request.Form["NgayVanChuyen"];
                string NgayNhanHang = HttpContext.Current.Request.Form["NgayNhanHang"];
                string NoiNhanHang = HttpContext.Current.Request.Form["NoiNhanHang"];
                string MaThanhPho = HttpContext.Current.Request.Form["MaThanhPho"];

                DateTime abc = DateTime.ParseExact(NgayMua, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-US"));

                SqlCommand cmd = new SqlCommand("CapNhatHoaDon", ketnoi);
                cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
                cmd.Parameters.AddWithValue("@DonGia", DonGia);
                cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                //cmd.Parameters.AddWithValue("@NgayMua", Convert.ToDateTime(NgayMua, new System.Globalization.DateTimeFormatInfo {ShortDatePattern= "dd-MM-yyyy HH:mm" ,DateSeparator="-"} ));
                cmd.Parameters.AddWithValue("@NgayMua", DateTime.ParseExact(NgayVanChuyen, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-US")));
                cmd.Parameters.AddWithValue("@NgayVanChuyen", DateTime.ParseExact(NgayVanChuyen, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-US")));
                cmd.Parameters.AddWithValue("@NgayNhanHang", DateTime.ParseExact(NgayNhanHang, "dd/MM/yyyy", new System.Globalization.CultureInfo("en-US")));
                cmd.Parameters.AddWithValue("@NoiNhanHang", NoiNhanHang);
                cmd.Parameters.AddWithValue("@MaThanhPho", MaThanhPho);



                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                return "Đã Update";
            }
            catch (Exception ex)
            {
                return ex.ToString();
                throw;
            }
        }
    }
}
