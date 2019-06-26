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
    public class TaoMoiNguoiDungController : ApiController
    {
        [HttpPost]
        public string TaoNguoiDungMoi()
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
               
             


                SqlCommand cmd = new SqlCommand("TaoNguoiDungMoi", ketnoi);
                cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@Email", Email);


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
