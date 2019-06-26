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
    public class KhachHangController : ApiController
    {
        // Xem nhân viên 
        [HttpGet]
        public DataTable BangKhachHang()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();

            SqlCommand thuchienlenh = new SqlCommand("SELECT * FROM dbo.KhachHang", ketnoi);
            SqlDataReader reader = thuchienlenh.ExecuteReader(); // Hiển thị dữ liệu ra màn hình 
            DataTable bangkhachhang = new DataTable(); // Lấy dữ liệu từ database
            bangkhachhang.Load(reader);
            return bangkhachhang;
        }

        // Xoa Nhan Vien
        [HttpDelete]
        public string XoaKhachHang()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                // thuc hien lenh tren nay
                string MaKhachHang = HttpContext.Current.Request.Form["MaKhachHang"];


                SqlCommand cmd = new SqlCommand("XoaKhachHang", ketnoi);
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
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

        //Cap nhat Nhan Vien
        [HttpPost]
        public string CapNhatKhachHang()
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
               


                SqlCommand cmd = new SqlCommand("CapNhatKhachHang", ketnoi);
                cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Email", Email);
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
