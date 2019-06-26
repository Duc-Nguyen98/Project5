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
    public class HangHoaController : ApiController
    {
        [HttpGet]
        public DataTable BangHoangHoa()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();

            SqlCommand thuchienlenh = new SqlCommand("SELECT * FROM dbo.HangHoa", ketnoi);
            SqlDataReader reader = thuchienlenh.ExecuteReader(); // Hiển thị dữ liệu ra màn hình 
            DataTable banghanghoa = new DataTable(); // Lấy dữ liệu từ database
            banghanghoa.Load(reader);
            return banghanghoa;
        }

        // Xoa Nhan Vien
        [HttpDelete]
        public string XoaHangHoa()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                // thuc hien lenh tren nay
                string MaHang = HttpContext.Current.Request.Form["MaHang"];


                SqlCommand cmd = new SqlCommand("XoaHangHoa", ketnoi);
                cmd.Parameters.AddWithValue("@MaHang", MaHang);
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
        public string CapNhatHangHoa()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            try
            {
                string MaHang = HttpContext.Current.Request.Form["MaHang"];
                string TenHang = HttpContext.Current.Request.Form["TenHang"];
                string DonGia = HttpContext.Current.Request.Form["DonGia"];
                string SoLuong = HttpContext.Current.Request.Form["SoLuong"];
                string MaPhanLoai = HttpContext.Current.Request.Form["MaPhanLoai"];




                SqlCommand cmd = new SqlCommand("CapNhatHangHoa", ketnoi);
                cmd.Parameters.AddWithValue("@MaHang", MaHang);
                cmd.Parameters.AddWithValue("@TenHang", TenHang);
                cmd.Parameters.AddWithValue("@DonGia", DonGia);
                cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                cmd.Parameters.AddWithValue("@MaPhanLoai", MaPhanLoai);



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
