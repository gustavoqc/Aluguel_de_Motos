using Npgsql;
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
                        MessageBox.Show("User connected!!");
                        //this.Hide();
                        //form_ form_ = new form_();
                        //form_.ShowDialog();
                        //this.Close();
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
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Mask = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 14)
                txtUser.Mask = "00,000,000/0000-00";
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
