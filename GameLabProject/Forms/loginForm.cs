using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GameLabProject.Forms;

namespace GameLabProject
{
    public partial class loginForm : DevExpress.XtraEditors.XtraForm
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void smplBtnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\mfghq\source\repos\NtpProjects\GameLabProject\GameLabProject\GameLabDB.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Users WHERE Username=@user AND Password=@pass";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user", txtUserName.Text);
                    command.Parameters.AddWithValue("@pass", txtPassword.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        string userName = reader["Name"].ToString();

                        string steamId = reader["SteamId"] != DBNull.Value ? reader["SteamId"].ToString() : "";

                        MessageBox.Show($"Hoşgeldiniz, {userName}!","Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        MainForm mainForm = new MainForm();

                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz şifre ya da kullanıcı adı ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error: " + ex.Message);
                }
            }
        }

        private void smplBtnCreate_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}