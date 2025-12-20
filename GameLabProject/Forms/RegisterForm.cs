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

namespace GameLabProject.Forms
{
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void smplebtnSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\mfghq\source\repos\NtpProjects\GameLabProject\GameLabProject\GameLabDB.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Users(Name, Surname, Username, Password) VALUES (@name, @surname, @user, @pass)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@surname", txtSurname.Text);
                    command.Parameters.AddWithValue("@user", txtUserNameR.Text);
                    command.Parameters.AddWithValue("@pass", txtPasswordR.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Hesap Başarıyla oluşturuldu", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    loginForm loginForm = new loginForm();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata! " + ex.Message);
                }

            }
        }
    }
        }    