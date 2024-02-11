using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace Aluguel_Moto
{
    public partial class form_login : Form
    {
        private static NpgsqlConnection db_conn()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;Username=postgres;Password=1234;Database=RentalDB");
        }

        public form_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = db_conn();
            conn.Open();
            
            try
            {
                string sqlQuery = $"SELECT * FROM user_data WHERE user_cnpj = @cnpj AND user_psw = MD5(@password)";
                using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("cnpj", txtUser.Text.ToString());
                    cmd.Parameters.AddWithValue("password", txtPassword.Text.ToString());

                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.GetValue(2).ToString()!.Equals("Admin"))
                        {
                            this.Hide();
                            form_admin_int form_admin = new form_admin_int();
                            form_admin.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            //this.Hide();
                            //form_user_int form_user = new form_user_int();
                            //form_user.ShowDialog();
                            //this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User and/or Password are Incorrect!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_signup form_su = new form_signup();
            form_su.ShowDialog();
            this.Close();
        }
    }
}
