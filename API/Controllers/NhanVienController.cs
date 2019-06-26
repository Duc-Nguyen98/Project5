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
    public class NhanVienController : ApiController
    {
        // Xem nhân viên 
        [HttpGet]
        public DataTable Bangnhanvien()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();

            SqlCommand thuchienlenh = new SqlCommand("SELECT * FROM dbo.NhanVien", ketnoi);
            SqlDataReader reader = thuchienlenh.ExecuteReader(); // Hiển thị dữ liệu ra màn hình 
            DataTable bangnhanvien = new DataTable(); // Lấy dữ liệu từ database
            bangnhanvien.Load(reader);
            return bangnhanvien;
        }

        // Xoa Nhan Vien
        [HttpDelete]
        public string XoaNhanVien()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                // thuc hien lenh tren nay
                string MaNhanVien = HttpContext.Current.Request.Form["MaNhanVien"];


                SqlCommand cmd = new SqlCommand("XoaNhanVien", ketnoi);
                cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
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
        public string CapNhatNhanVien()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                string MaNhanVien = HttpContext.Current.Request.Form["MaNhanVien"];
                string TenNhanVien = HttpContext.Current.Request.Form["TenNhanVien"];
                string GioiTinh = HttpContext.Current.Request.Form["GioiTinh"];
                string SoDienThoai = HttpContext.Current.Request.Form["SoDienThoai"];
                string Email = HttpContext.Current.Request.Form["Email"];
                string MaQuyen = HttpContext.Current.Request.Form["MaQuyen"];
                string TienLuong = HttpContext.Current.Request.Form["TienLuong"];
           

                SqlCommand cmd = new SqlCommand("CapNhatNhanVien", ketnoi);
                cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVien);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
                cmd.Parameters.AddWithValue("@TienLuong", TienLuong);
           
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
