using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Aluguel_Moto
{
    public partial class form_signup : Form
    {
        private static NpgsqlConnection db_conn()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;Username=postgres;Password=1234;Database=RentalDB");
        }

        public form_signup()
        {
            InitializeComponent();
        }

        private void numDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCNPJ_Enter(object sender, EventArgs e)
        {
            txtCNPJ.Mask = "";
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.Length == 14)
                txtCNPJ.Mask = "00,000,000/0000-00";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        { 
            if (txtCNPJ.Text != "" && txtName.Text != "" && dtBirth.Value.ToString() != "" && numDL.Text != "" && txtDL.Text != "" && txtPsw.Text != "")
            {
                if (txtDL.Text.Equals("A") || txtDL.Text.Equals("B") || txtDL.Text.Equals("A + B")) 
                {
                    txtCNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (txtCNPJ.Text.Length == 14)
                    {
                        if (numDL.Text.Length == 12)
                        {
                            txtCNPJ.TextMaskFormat = MaskFormat.IncludeLiterals;

                            NpgsqlConnection conn = db_conn();
                            conn.Open();
                            try
                            {
                                string dir = @"C:\VehRental\";
                                string sqlQuery = $"INSERT INTO user_data (user_cnpj, user_name, user_birth, user_dl_num, user_dl_categ, user_psw) VALUES (@cnpj, @name, @birth, @dlNum, @dlCateg, MD5(@password))";
                            
                                using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("cnpj", txtCNPJ.Text.ToString());
                                    cmd.Parameters.AddWithValue("name", txtName.Text.ToString());
                                    cmd.Parameters.AddWithValue("birth", dtBirth.Value);
                                    cmd.Parameters.AddWithValue("dlNum", numDL.Text.ToString());
                                    cmd.Parameters.AddWithValue("dlCateg", txtDL.Text.ToString());
                                    cmd.Parameters.AddWithValue("password", txtPsw.Text.ToString());
                                    cmd.Prepare();

                                    cmd.ExecuteNonQuery();

                                    if (!Directory.Exists(dir))
                                        Directory.CreateDirectory(dir);

                                    imgDL.Image.Save(dir + "dl_image.png");

                                    MessageBox.Show("User added sucessfully!");

                                    this.Hide();
                                    form_login form_l = new form_login();
                                    form_l.ShowDialog();
                                    this.Close();

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
                        else
                            MessageBox.Show("Driver's License Number should have 12 digits!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("CNPJ should have 14 digits!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Select a valid category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Complete all the fields correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_login form_l = new form_login();
            form_l.ShowDialog();
            this.Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imgDialog= new OpenFileDialog();
                imgDialog.Filter = "Image Files (*.bmp;*.png)|*.BMP;*.PNG";

                if (imgDialog.ShowDialog() == DialogResult.OK)
                {
                    imgDL.ImageLocation = imgDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
