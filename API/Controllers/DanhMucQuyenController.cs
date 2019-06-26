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
    public class DanhMucQuyenController : ApiController
    {
        [HttpGet] public DataTable MucQuyen()
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();

            try {
                string TenQuyen = HttpContext.Current.Request.Form["TenQuyen"];
                // string Ten = HttpContext.Current.Request.Form["Ten"];
                //có thể sử dung sqlcommand, hoặc sqldataadapter
                // ví dụ này sẽ sử dụng sqldataadapter
                // bên danhmuccontroller đá có ví dụ sử dụng sqlcommand
                SqlDataAdapter sda = new SqlDataAdapter("MucQuyen", ketnoi);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable bang = new DataTable();
                sda.Fill(bang);
                return bang;
                    
            }
            catch(Exception)
            {
                return null;
            }

        }
    }
}
