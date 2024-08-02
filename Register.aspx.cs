using System;
using System.Linq;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = ddlRole.SelectedValue;

            using (var context = new ApplicationDbContext())
            {
                
                var userExists = context.Users.Any(u => u.Username == username || u.Email == email);
                if (userExists)
                {
                    lblMessage.Text = "Username or email already exists.";
                }
                else
                {
                    
                    var user = new User
                    {
                        Username = username,
                        Email = email,
                        Password = password,
                        Role = role 
                        
                    };

                    
                    context.Users.Add(user);
                    context.SaveChanges();

                    
                    lblMessage.Text = "Registration successful!";

                    
                    Response.Redirect("Login.aspx"); 
                    ClearFormFields();
                }
            }
        }

        private void ClearFormFields()
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            ddlRole.SelectedIndex = 0; // Assuming the first item is default
        }
    }
}
