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

namespace Aluguel_Moto
{
    public partial class form_admin_int : Form
    {
        private static NpgsqlConnection db_conn()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;Username=postgres;Password=1234;Database=RentalDB");
        }

        readonly NpgsqlConnection conn = db_conn();

        private void Listvehicles(string query)
        {
            conn.Open();
            string sqlQuery = $"SELECT vh_plate AS \"License Plate\", vh_model AS \"Model\", vh_year AS \"Year\", CASE vh_rented WHEN 'false' THEN 'Not Rented' WHEN 'true' THEN 'Rented' END \"Rent Status\" FROM vh_reg ";

            if (query != "default")
            {
                sqlQuery += query;
            }
            else
            {
                sqlQuery += "ORDER BY vh_rented, vh_year DESC";
            }

            try
            {
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

        public form_admin_int()
        {
            InitializeComponent();
            Listvehicles("default");
        }

        private void btnNewVh_Click(object sender, EventArgs e)
        {
            btnNewVh.BackColor = Color.LightGray;
            btnCheckVh.BackColor = Color.Transparent;
            pnlCheckVh.Hide();
            pnlNewVh.Show();

            txtModel.Text = "";
            txtPlate.Text = "";
            txtYear.Text = "";
            txtModel.Enabled = true;
            txtYear.Enabled = true;
            btnRegVh.Text = "Registrate Vehicle";
        }

        private void btnCheckVh_Click(object sender, EventArgs e)
        {
            btnNewVh.BackColor = Color.Transparent;
            btnCheckVh.BackColor = Color.LightGray;
            pnlCheckVh.Show();
            Listvehicles("default");
        }

        private void btnRegVh_Click(object sender, EventArgs e)
        {
            if (btnRegVh.Text.Equals("Registrate Vehicle"))
            {
                if (txtYear.Text.Length == 4 && txtYear.Text != "" && txtModel.Text != "" && txtPlate.Text != "" && txtPlate.Text.Length == 7)
                {
                    conn.Open();

                    try
                    {
                        string sqlQuery = $"INSERT INTO vh_reg (vh_plate, vh_model, vh_year) VALUES (@plate, @model, @year)";
                        using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("plate", txtPlate.Text.ToUpper().ToString());
                            cmd.Parameters.AddWithValue("model", txtModel.Text.ToString());
                            cmd.Parameters.AddWithValue("year", txtYear.Text.ToString());
                            cmd.Prepare();

                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Motorcycle registered successfully!");
                                txtModel.Text = "";
                                txtPlate.Text = "";
                                txtYear.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("There was an error while proccessing your requisition.");
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
                else
                {
                    MessageBox.Show("Fill all the informations properly!");
                }
            }
            else if (btnRegVh.Text.Equals("Update Vehicle"))
            {
                conn.Open();

                try
                {
                    string sqlQuery = $"UPDATE vh_reg SET vh_plate = '" + txtPlate.Text.ToUpper().ToString() + "' WHERE vh_plate = '" + dtgListVh.SelectedCells[0].Value.ToString() + "' ";
                    using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("License Plate updated successfully!");
                            txtModel.Text = "";
                            txtPlate.Text = "";
                            txtYear.Text = "";
                            txtModel.Enabled = true;
                            txtYear.Enabled = true;

                            conn.Close();
                            btnCheckVh_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("There was an error while proccessing your requisition.");
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

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearchPlate_KeyUp(object sender, KeyEventArgs e)
        {
            var query = "WHERE vh_plate LIKE '%" + txtSearchPlate.Text.ToUpper() + "%' ORDER BY vh_rented, vh_year DESC";
            Listvehicles(query);
        }

        private void dtgListVh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure you want delete the vehicle with plate \"" + dtgListVh.SelectedCells[0].Value.ToString() + "\"?", "Data Exclusion", MessageBoxButtons.YesNo);

            if (message == DialogResult.Yes)
            {
                if (dtgListVh.SelectedCells[3].Value.Equals("Not Rented"))
                {
                    conn.Open();

                    try
                    {
                        string sqlQuery = $"DELETE FROM vh_reg WHERE vh_plate = '" + dtgListVh.SelectedCells[0].Value.ToString() + "'";
                        using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Motorcycle deleted successfully!");

                                conn.Close();
                                Listvehicles("default");
                            }
                            else
                            {
                                MessageBox.Show("There was an error while proccessing your requisition.");
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
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    MessageBox.Show("You can't delete a vehicle with active rentals!", "Exclusion Failed");
                }
            }
            else
            {
                Listvehicles("default");
            }
        }

        private void btnDelete_EnabledChanged(object sender, EventArgs e)
        {
            if (btnDelete.Enabled)
            {
                btnDelete.BackColor = Color.FromArgb(255, 192, 192);
                btnDelete.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                btnDelete.BackColor = Color.LightGray;
                btnDelete.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void btnEdit_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEdit.Enabled)
            {
                btnEdit.BackColor = Color.FromArgb(255, 255, 192);
                btnEdit.FlatAppearance.BorderColor = Color.Orange;
            }
            else
            {
                btnEdit.BackColor = Color.LightGray;
                btnEdit.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNewVh_Click(sender, e);

            txtPlate.Text = dtgListVh.SelectedCells[0].Value.ToString();
            txtModel.Text = dtgListVh.SelectedCells[1].Value.ToString();
            txtYear.Text = dtgListVh.SelectedCells[2].Value.ToString();

            txtModel.Enabled = false;
            txtYear.Enabled = false;

            txtPlate.Focus();
            btnRegVh.Text = "Update Vehicle";
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            btnCheckVh_Click(sender, e);
        }

        private void dtgListVh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgListVh.ClearSelection();
            dtgListVh.CurrentCell = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
