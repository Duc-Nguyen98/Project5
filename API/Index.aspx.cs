using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace API
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("~/Index.aspx");
            }


        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = "Server=DESKTOP-KUOIKQA\\SQLEXPRESS;Integrated Security=True;Database=QuanLyBanHang"; // chuỗi để kết nối tới sql 
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi); // thực thi kết nối
            ketnoi.Open();
            string query = "SELECT COUNT(*) FROM Quantri WHERE TenDangNhap = '" + txtusername.Text + "' And MatKhau= '" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            string output = cmd.ExecuteScalar().ToString();

            if(output=="1")
            {
                Session["User"] = txtusername.Text;
                Response.Redirect("~/welcome.aspx");
            }

            else
            {
                Response.Write("You User Name And Password is Wrong !");
            }
        }
    }
}