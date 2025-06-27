using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivingSystemUserDesigned
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblStatus.Text = "Please fill in all fields.";
                return;
            }
            if (password != confirmPassword)
            {
                lblStatus.Text = "Passwords do not match.";
                return;
            }

            using (var conn = new Database().GetConnection())
            {
                conn.Open();
                using (var check = new MySqlCommand("SELECT COUNT(*) FROM users WHERE username=@username", conn))
                {
                    check.Parameters.AddWithValue("@username", username);
                    if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                    {
                        lblStatus.Text = "Username already exists.";
                        return;
                    }
                }
                using (var cmd = new MySqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    lblStatus.Text = "Account created. You can now login.";
                }
            }

          
        }
    }
}
