using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aluguel_Moto
{
    public partial class form_user_int : Form
    {
        string? dl_num, dl_ctg, id_user;
        int days;

        private static NpgsqlConnection db_conn()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;Username=postgres;Password=1234;Database=RentalDB");
        }

        public form_user_int()
        {
            InitializeComponent();

            DateTime date = cldSevD.TodayDate;
            dtPreview.MinDate = date;
            dtPreview_ValueChanged(this, EventArgs.Empty);
        }

        internal void user_data(string user_dl, string dl_categ, string user_id)
        {
            dl_num = user_dl;
            dl_ctg = dl_categ;
            id_user = user_id;
        }

        private bool check_category()
        {
            if (dl_ctg!.Equals("A") || dl_ctg!.Equals("A + B"))
                return false;
            else
                return true;
        }

        private void btnRentVh_Click(object sender, EventArgs e)
        {
            btnRentVh.BackColor = Color.LightGray;
            btnRentalStatus.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;

            NpgsqlConnection conn = db_conn();
            conn.Open();

            try
            {
                string sqlQuery = $"SELECT * FROM vh_rental WHERE rtl_user = " + id_user;
                using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        btnRentalStatus.Visible = true;
                        btnRentalStatus_Click(sender, e);
                        MessageBox.Show("You already have an active rental!", "Rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Size = new Size(996, 450);

                        lblRentalPeriod.Text = "";
                        lblDaily.Text = "";
                        lblTotal.Text = "";

                        pnlRentalSol.Visible = false;
                        pnlSelectVh.Visible = false;
                        pnlRentVh.Visible = true;
                        CenterToScreen();

                        if (check_category())
                        {
                            pnlRentVh.Enabled = false;
                            MessageBox.Show("Sorry, but only delivery drivers qualified in category 'A' can make a rental.", "Warning", MessageBoxButtons.OK);
                        }
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

        private void dtPreview_ValueChanged(object sender, EventArgs e)
        {
            cldSevD.SelectionStart = dtPreview.Value.AddDays(1);
            cldSevD.SelectionEnd = dtPreview.Value.AddDays(7);

            cldFifD.SelectionStart = dtPreview.Value.AddDays(1);
            cldFifD.SelectionEnd = dtPreview.Value.AddDays(15);

            cldThiD.SelectionStart = dtPreview.Value.AddDays(1);
            cldThiD.SelectionEnd = dtPreview.Value.AddDays(30);
        }

        private void form_user_int_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = db_conn();
            conn.Open();

            try
            {
                string sqlQuery = $"SELECT * FROM vh_rental WHERE rtl_user = " + id_user;
                using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        btnRentalStatus.Visible = true;
                        btnRentalStatus_Click(sender, e);
                    }
                    else
                    {
                        if (check_category())
                        {
                            pnlRentVh.Enabled = false;
                            MessageBox.Show("Sorry, but only delivery drivers qualified in category 'A' can make a rental.", "Warning", MessageBoxButtons.OK);
                        }
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

        private void rentalPanelSetup(int dayCount, string daily, string total)
        {
            Size = new Size(630, 450);
            CenterToScreen();

            days = dayCount;
            lblRentalPeriod.Text = dayCount.ToString() + " Days";
            lblDaily.Text = "Daily: R$" + daily;
            lblTotal.Text = "Total: R$" + total;
            pnlRentalSol.Visible = true;
            pnlRentStat.Visible = false;
            pnlProfile.Visible = false;
            pnlRentVh.Visible = false;
        }

        private void pnlRentalSol_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlRentalSol.Visible)
            {
                dtSD.Value = dtPreview.Value;
                dtExpectedD.Value = dtSD.Value.AddDays(days);
                dtED.Value = dtSD.Value.AddDays(days);
                lblValueExpl.Text = "";
            }
        }

        private void valueChanged(object sender, EventArgs e)
        {
            dtExpectedD.Value = dtSD.Value.AddDays(days);
            cldRentalPreview.SelectionStart = dtSD.Value.AddDays(1);

            dtED.MinDate = dtSD.Value;
            dtED.Value = dtSD.Value.AddDays(days);
            cldRentalPreview.SelectionEnd = dtED.Value;
        }


        private void btnRentSd_Click(object sender, EventArgs e)
        {
            rentalPanelSetup(7, "30,00", "210,00");
        }

        private void btnRentFd_Click(object sender, EventArgs e)
        {
            rentalPanelSetup(15, "28,00", "420,00");
        }

        private void btnRentTd_Click(object sender, EventArgs e)
        {
            rentalPanelSetup(30, "22,00", "660,00");
        }

        private void dtED_ValueChanged(object sender, EventArgs e)
        {
            cldRentalPreview.SelectionStart = dtSD.Value.AddDays(1);
            cldRentalPreview.SelectionEnd = dtED.Value;

            var dateComp = DateTime.Compare(dtED.Value.Date, dtExpectedD.Value.Date);

            if (dateComp < 0)
            {
                if (lblRentalPeriod.Text.Equals("7 Days"))
                    lblTotal.Text = checkValue(7, "earlier") + "*";
                else if (lblRentalPeriod.Text.Equals("15 Days"))
                    lblTotal.Text = checkValue(15, "earlier") + "*";
                else
                    lblTotal.Text = checkValue(30, "earlier") + "*";
            }
            else if (dateComp > 0)
            {
                if (lblRentalPeriod.Text.Equals("7 Days"))
                    lblTotal.Text = checkValue(7, "later") + "*";
                else if (lblRentalPeriod.Text.Equals("15 Days"))
                    lblTotal.Text = checkValue(15, "later") + "*";
                else
                    lblTotal.Text = checkValue(30, "later") + "*";
            }
            else
            {
                if (lblRentalPeriod.Text.Equals("7 Days"))
                    lblTotal.Text = checkValue(7, "equal");
                else if (lblRentalPeriod.Text.Equals("15 Days"))
                    lblTotal.Text = checkValue(15, "equal");
                else
                    lblTotal.Text = checkValue(30, "equal");

                lblValueExpl.Text = "";
            }
        }

        private string checkValue(int daysTotal, string status)
        {
            TimeSpan daysLeft;
            int daysUsed;
            double dailyValue, fineValue, totalValue;

            daysLeft = dtExpectedD.Value.Date - dtED.Value.Date;

            if (status.Equals("earlier"))
            {

                if (daysTotal == 7)
                {
                    daysUsed = 7 - daysLeft.Days;
                    dailyValue = daysUsed * 30;
                    fineValue = (daysLeft.Days * 30) * 0.20;
                    totalValue = dailyValue + fineValue;
                    lblValueExpl.Text = "* Value includes a fine of \n 20% on the value for \n non-rented days.";
                }
                else if (daysTotal == 15)
                {
                    daysUsed = 15 - daysLeft.Days;
                    dailyValue = daysUsed * 28;
                    fineValue = (daysLeft.Days * 28) * 0.40;
                    totalValue = dailyValue + fineValue;
                    lblValueExpl.Text = "* Value includes a fine of \n 40% on the value for \n non-rented days.";
                }
                else
                {
                    daysUsed = 30 - daysLeft.Days;
                    dailyValue = daysUsed * 22;
                    fineValue = (daysLeft.Days * 22) * 0.60;
                    totalValue = dailyValue + fineValue;
                    lblValueExpl.Text = "* Value includes a fine of \n 60% on the value for \n non-rented days.";
                }
            }
            else if (status.Equals("later"))
            {
                daysLeft = dtED.Value.Date - dtExpectedD.Value.Date;

                if (daysTotal == 7)
                {
                    dailyValue = daysTotal * 30;
                }
                else if (daysTotal == 15)
                {
                    dailyValue = daysTotal * 28;
                }
                else
                {
                    dailyValue = daysTotal * 22;
                }

                daysUsed = daysLeft.Days;
                fineValue = daysUsed * 50;
                totalValue = dailyValue + fineValue;

                lblValueExpl.Text = "* Value includes a fine of \n R$50,00 on the value for \n each aditional day.";
            }
            else
            {
                if (daysTotal == 7)
                {
                    daysUsed = 7 - daysLeft.Days;
                    totalValue = daysUsed * 30;
                }
                else if (daysTotal == 15)
                {
                    daysUsed = 15 - daysLeft.Days;
                    totalValue = daysUsed * 28;
                }
                else
                {
                    daysUsed = 30 - daysLeft.Days;
                    totalValue = daysUsed * 22;
                }
            }

            return totalValue.ToString("N2");
        }

        private void btnCancelRent_Click(object sender, EventArgs e)
        {
            btnRentVh_Click(sender, e);
        }

        private void btnFinishRent_Click(object sender, EventArgs e)
        {
            pnlRentalSol.Visible = false;
            pnlSelectVh.Visible = true;

            NpgsqlConnection conn = db_conn();
            conn.Open();

            try
            {
                string sqlQuery = $"SELECT vh_id, vh_model AS \"Model\", vh_year AS \"Year\" FROM vh_reg WHERE vh_rented = false";
                using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dtgListVh.DataSource = dt;
                    }
                    else
                        dtgListVh.DataSource = "";

                    cmd.Dispose();

                    if (dtgListVh.RowCount > 0)
                        dtgListVh.Columns[0].Visible = false;
                    else
                    {
                        MessageBox.Show("Sorry, no vehicles available for rental!", "Rental", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSelectVh.Enabled = false;
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

        private void btnSelectVh_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = db_conn();
            conn.Open();

            try
            {
                string sqlQuery = $"INSERT INTO vh_rental (rtl_user, rtl_vh, rtl_sdate, rtl_edate, rtl_price) VALUES (@user_id, @vh_id, @s_date, @e_date, @price)";

                using var cmd = new NpgsqlCommand(sqlQuery, conn);
                {
                    string price;

                    if (lblTotal.Text.Contains('*'))
                        price = lblTotal.Text.Remove(lblTotal.Text.Length - 1);
                    else
                        price = lblTotal.Text;

                    price = price.Replace(',', '.');

                    cmd.Parameters.AddWithValue("user_id", int.Parse(id_user!));
                    cmd.Parameters.AddWithValue("vh_id", dtgListVh.SelectedCells[0].Value);
                    cmd.Parameters.AddWithValue("s_date", dtSD.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("e_date", dtED.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("price", price);
                    cmd.Prepare();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cmd.Dispose();
                        sqlQuery = $"UPDATE vh_reg SET vh_rented = 'true' WHERE vh_id = @vh_id";
                        var newCmd = new NpgsqlCommand(sqlQuery, conn);
                        newCmd.Parameters.AddWithValue("vh_id", dtgListVh.SelectedCells[0].Value);
                        newCmd.Prepare();

                        if (newCmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Rental complete sucessfully!");
                    }

                    btnRentalStatus.Visible = true;
                    btnRentalStatus_Click(sender, e);
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

        private void btnRentalStatus_Click(object sender, EventArgs e)
        {
            btnRentVh.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.Transparent;
            btnRentalStatus.BackColor = Color.LightGray;

            pnlRentVh.Visible = false;
            pnlSelectVh.Visible = false;
            pnlRentStat.Visible = true;

            if (pnlRentStat.Visible)
            {
                NpgsqlConnection conn = db_conn();
                conn.Open();

                try
                {
                    string sqlQuery = $"SELECT user_cnpj, user_dl_num, user_dl_categ, user_name, vh_plate, vh_model, vh_year, rtl_sdate, rtl_edate, rtl_price FROM vh_rental LEFT JOIN user_data on user_id = rtl_user LEFT JOIN vh_reg on vh_id = rtl_vh WHERE user_id = " + id_user;

                    using var cmd = new NpgsqlCommand(sqlQuery, conn);
                    {
                        NpgsqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            lblCnpj.Text = reader.GetValue(0).ToString();
                            lblDriverL.Text = reader.GetValue(1).ToString();
                            lblCateg.Text = reader.GetValue(2).ToString();
                            lblName.Text = reader.GetValue(3).ToString();
                            lblPlate.Text = reader.GetValue(4).ToString();
                            lblModel.Text = reader.GetValue(5).ToString();
                            lblYear.Text = reader.GetValue(6).ToString();
                            lblSD.Text = reader.GetValue(7).ToString();
                            lblED.Text = reader.GetValue(8).ToString();
                            lblFullPrice.Text = "R$" + reader.GetValue(9).ToString()!.Replace('.', ',');
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
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_login frm_login = new();
            frm_login.ShowDialog();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Size = new Size(630, 450);
            CenterToScreen();
            
            btnRentVh.BackColor = Color.Transparent;
            btnRentalStatus.BackColor = Color.Transparent;
            btnProfile.BackColor = Color.LightGray;

            pnlRentVh.Visible = false;
            pnlSelectVh.Visible = false;
            pnlRentStat.Visible = false;
            pnlRentalSol.Visible = false;
            pnlProfile.Visible = true;

            NpgsqlConnection conn = db_conn();
            conn.Open();

            try
            {
                string sqlQuery = $"SELECT * FROM user_data WHERE user_id = " + id_user;

                using var cmd = new NpgsqlCommand(sqlQuery, conn);
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string dir = @"C:\VehRental\";

                        lblProfCnpj.Text = reader.GetString(1);
                        lblProfName.Text = reader.GetString(2);
                        lblProfBirth.Text = reader.GetDateTime(3).ToShortDateString();
                        lblProfDL.Text = reader.GetString(4);
                        lblProfDLC.Text = reader.GetString(5);

                        if (Directory.Exists(dir))
                            imgDL.ImageLocation = dir + "dl_image.png";
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

        private void btnUpdateImg_Click(object sender, EventArgs e)
        {
            string dir = @"C:\VehRental\";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            imgDL.Image.Save(dir + "dl_image.png");

            MessageBox.Show("Image updated successfully!", "Update Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnUpdateImg.Enabled = false;
        }

        private void imgDL_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imgDialog = new OpenFileDialog();
                imgDialog.Filter = "Image Files (*.bmp;*.png)|*.BMP;*.PNG";

                if (imgDialog.ShowDialog() == DialogResult.OK)
                {
                    imgDL.ImageLocation = imgDialog.FileName;
                    btnUpdateImg.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
