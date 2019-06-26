using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace testsql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối

            try
            {
                ketnoi.Open();
                Label1.Text = "";
            }
            catch
            {
                Label1.Text = "kết nối thất bại";
            }
                SqlCommand thuchienlenh = new SqlCommand("SELECT * FROM dbo.NguoiDung2", ketnoi);
                SqlDataReader reader = thuchienlenh.ExecuteReader(); // Hiển thị dữ liệu ra màn hình 
                DataTable bang = new DataTable(); // Lấy dữ liệu từ database
                bang.Load(reader);
                GridView1.DataSource = bang;
                GridView1.DataBind();
            
        }
// Nút thêm 
        protected void btnThem_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            try
            {
                SqlCommand nutthem = new SqlCommand("INSERT INTO dbo.NguoiDung2(MaQuyen,TenDangNhap,MatKhau,HoTen)VALUES( '" + txtxMaQuyen.Text + "'  , '" + txtTenDangNhap.Text + "' , '" + txtMatKhau.Text + "' , '" + txtHoTen.Text + "')", ketnoi);
                Label2.Text = "Thêm Thành Công !! Hãy Loading lại trang Website của Bạn !";
                ketnoi.Open();
                nutthem.ExecuteNonQuery();
                ketnoi.Close();

            }
            catch
            {
                Label2.Text = "Thêm thất bại !! Hãy Loading lại trang Website của Bạn !";
            }
          
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            try
            {
                SqlCommand nutsua = new SqlCommand("UPDATE dbo.NguoiDung2 SET TenDangNhap = '" +  txtTenDangNhap.Text + "', MatKhau = '" + txtMatKhau.Text + "' , HoTen = '" + txtHoTen.Text + "'   WHERE MaQuyen = '" + txtxMaQuyen.Text + "'", ketnoi);
                Label2.Text = "Sửa thành công !! Hãy Loading lại trang Website của Bạn !";
                ketnoi.Open();
                nutsua.ExecuteNonQuery();
                ketnoi.Close();
            }
            catch
            {
                Label2.Text = "Sửa thất bại !! Hãy Loading lại trang Website của Bạn !";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối

            SqlCommand cmd = new SqlCommand("DELETE dbo.NguoiDung2 WHERE HoTen= @HoTen", ketnoi); // 1. Tạo một đối tượng SqlCommand sử dụng Parameter
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@HoTen";
            param.Value = txtHoTen;
        }

   
    }
}