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

namespace API.appjs
{
    public class QuanTriController : ApiController
    {
        [HttpGet]
        public DataTable BangQuanTri()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();

            SqlCommand thuchienlenh = new SqlCommand("SELECT * FROM dbo.Quantri ORDER BY MaQuyen ASC ", ketnoi);
            SqlDataReader reader = thuchienlenh.ExecuteReader(); // Hiển thị dữ liệu ra màn hình 
            DataTable BangQuanTri = new DataTable(); // Lấy dữ liệu từ database
            BangQuanTri.Load(reader);
            return BangQuanTri;
        }

        [HttpDelete]
        public string XoaQuanTri()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                // thuc hien lenh tren nay
                string TenDangNhap = HttpContext.Current.Request.Form["TenDangNhap"];


                SqlCommand cmd = new SqlCommand("XoaQuanTri", ketnoi);
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
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
        public string CapNhatQuanTri()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                string MaQuyen = HttpContext.Current.Request.Form["MaQuyen"];
                string TenDangNhap = HttpContext.Current.Request.Form["TenDangNhap"];
                string MatKhau = HttpContext.Current.Request.Form["MatKhau"];
                string HoTen = HttpContext.Current.Request.Form["HoTen"];
                string Email = HttpContext.Current.Request.Form["Email"];
             


                SqlCommand cmd = new SqlCommand("CapNhatQuanTri", ketnoi);
                cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@Email", Email);
       

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
