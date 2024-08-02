using System;
using System.Linq;
using WebApplication4.Data;
using WebApplication4.Models; 

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    Session["UserID"] = user.ID;
                    Session["UserRole"] = user.Role;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid username or password.";
                }
            }
        }
    }
}
