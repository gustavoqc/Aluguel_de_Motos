using Npgsql;
using RabbitMQ.Client;
using System;
using System.Collections;
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
        int order_id;

        private static NpgsqlConnection db_conn()
        {
            return new NpgsqlConnection(@"Server=silly.db.elephantsql.com;Username=vrbndbuv;Password=nwFLYEvX5yvnIK-BZAqDKdSD9JTkdDLD;Database=vrbndbuv");
        }

        readonly NpgsqlConnection conn = db_conn();

        public form_admin_int()
        {
            InitializeComponent();
            Listvehicles("default");
        }

        private void Listvehicles(string query)
        {
            conn.Open();
            string sqlQuery = $"SELECT vh_id, vh_plate AS \"License Plate\", vh_model AS \"Model\", vh_year AS \"Year\", CASE vh_rented WHEN 'false' THEN 'Not Rented' WHEN 'true' THEN 'Rented' END \"Rent Status\" FROM vh_reg ";

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
                    dtgListVh.Columns[0].Visible = false;
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

        private void List_Orders()
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT order_id, order_label AS \"Label\", order_desc AS \"Description\", order_value AS \"Value\", order_cdate AS \"Creation date\", order_status AS \"Status\" FROM order_reg ORDER BY order_status='Delivered', order_cdate DESC";
                using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dtgOrders.DataSource = dt;
                    }
                    else
                        dtgOrders.DataSource = "";

                    cmd.Dispose();
                    dtgOrders.Columns[0].Visible = false;
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

        private void List_Drivers(string driver_order_id)
        {
            try
            {
                conn.Open();

                string sqlQuery = $"SELECT order_label AS \"Order Label\", user_cnpj AS \"CNPJ\", user_name AS \"Name\", EXTRACT(YEAR FROM CURRENT_DATE) - EXTRACT(YEAR FROM user_birth) AS \"Age\", user_dl_categ AS \"DL Categ.\" FROM mss_rcv LEFT JOIN user_data ON user_id = mss_user LEFT JOIN order_reg ON order_id = mss_order WHERE mss_order = " + int.Parse(driver_order_id) + "ORDER BY user_name";
                using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dtgOrders.DataSource = dt;
                        dtgOrders.Columns[0].Visible = false;
                    }
                    else
                    {
                        dtgOrders.DataSource = "";
                        MessageBox.Show("No Delivery Drivers have received this order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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

        private void btnNewVh_Click(object sender, EventArgs e)
        {
            btnCheckOrder.BackColor = Color.Transparent;
            btnNewOrder.BackColor = Color.Transparent;
            btnCheckVh.BackColor = Color.Transparent;
            btnNewVh.BackColor = Color.LightGray;

            pnlCheckOrder.Visible = false;
            pnlNewOrder.Visible = false;
            pnlCheckVh.Visible = false;
            pnlNewVh.Visible = true;

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
            btnNewOrder.BackColor = Color.Transparent;
            btnCheckOrder.BackColor = Color.Transparent;
            btnCheckVh.BackColor = Color.LightGray;
            pnlCheckVh.Visible = true;
            pnlNewVh.Visible = false;
            pnlNewOrder.Visible = false;
            pnlCheckOrder.Visible = false;
            Listvehicles("default");
        }

        private void btnRegVh_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (btnRegVh.Text.Equals("Registrate Vehicle"))
                {
                    if (txtYear.Text.Length == 4 && txtYear.Text != "" && txtModel.Text != "" && txtPlate.Text != "" && txtPlate.Text.Length == 7)
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
                    else
                    {
                        MessageBox.Show("Fill all the informations properly!");
                    }
                }
                else if (btnRegVh.Text.Equals("Update Vehicle"))
                {
                    string sqlQuery = $"UPDATE vh_reg SET vh_plate = '" + txtPlate.Text.ToUpper().ToString() + "' WHERE vh_id = '" + dtgListVh.SelectedCells[0].Value.ToString() + "' ";
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
                            MessageBox.Show("There was an error while proccessing your requisition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dtgListVh.SelectedCells[4].Value.Equals("Not Rented"))
            {
                var message_response = MessageBox.Show("Are you sure you want delete the vehicle with plate \"" + dtgListVh.SelectedCells[1].Value.ToString() + "\"?", "Data Exclusion", MessageBoxButtons.YesNo);

                if (message_response == DialogResult.Yes)
                {
                    conn.Open();

                    try
                    {
                        string sqlQuery = $"DELETE FROM vh_reg WHERE vh_id = '" + dtgListVh.SelectedCells[0].Value.ToString() + "'";
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
                    Listvehicles("default");
                }
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("You can't delete a vehicle with active rentals!", "Exclusion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dtgListVh.SelectedCells[4].Value.Equals("Not Rented"))
            {
                btnNewVh_Click(sender, e);

                txtPlate.Text = dtgListVh.SelectedCells[1].Value.ToString();
                txtModel.Text = dtgListVh.SelectedCells[2].Value.ToString();
                txtYear.Text = dtgListVh.SelectedCells[3].Value.ToString();

                txtModel.Enabled = false;
                txtYear.Enabled = false;

                txtPlate.Focus();
                btnRegVh.Text = "Update Vehicle";
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("You can't update a vehicle with active rentals!", "Update Failed");
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            txtModel.Text = "";
            txtYear.Text = "";
            txtPlate.Text = "";

            btnCheckVh_Click(sender, e);
        }

        private void dtgListVh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgListVh.ClearSelection();
            dtgListVh.CurrentCell = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_login frm_login = new();
            frm_login.ShowDialog();
            this.Close();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            btnCheckOrder.BackColor = Color.Transparent;
            btnCheckVh.BackColor = Color.Transparent;
            btnNewVh.BackColor = Color.Transparent;
            btnNewOrder.BackColor = Color.LightGray;

            pnlNewOrder.Visible = true;
            pnlCheckOrder.Visible = false;
            pnlCheckVh.Visible = false;
            pnlNewVh.Visible = false;
            btnCreateOrder.Text = "Create New Order";
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (btnCreateOrder.Text.Equals("Create New Order"))
                {
                    string sqlQuery = $"INSERT INTO order_reg (order_cdate, order_value, order_label, order_desc) VALUES (@cdate, @value, @label, @desc) RETURNING order_id";
                    using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("cdate", dtCreationD.Value);
                        cmd.Parameters.AddWithValue("value", double.Parse(txtOrderValue.Text));
                        cmd.Parameters.AddWithValue("label", txtLabel.Text.ToString());
                        cmd.Parameters.AddWithValue("desc", txtDesc.Text.ToString());
                        cmd.Prepare();

                        order_id = (int)cmd.ExecuteScalar()!;

                        MessageBox.Show("Order registered successfully!");
                        txtOrderValue.Text = "";
                        txtLabel.Text = "";
                        txtDesc.Text = "";
                        publish_message();
                    }
                }
                else if (btnCreateOrder.Text.Equals("Update Order"))
                {
                    string sqlQuery = $"UPDATE order_reg SET order_label = '" + txtLabel.Text.ToString() + "', order_desc = '" + txtDesc.Text.ToString() + "', order_value = '" + txtOrderValue.Text.ToString().Replace(',', '.') + "' WHERE order_id = " + dtgOrders.SelectedCells[0].Value.ToString();
                    using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Order updated successfully!");
                            txtLabel.Text = "";
                            txtDesc.Text = "";
                            txtOrderValue.Text = "";

                            conn.Close();
                            btnCheckOrder_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("There was an error while proccessing your requisition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            btnNewVh.BackColor = Color.Transparent;
            btnNewOrder.BackColor = Color.Transparent;
            btnCheckVh.BackColor = Color.Transparent;
            btnCheckOrder.BackColor = Color.LightGray;
            btnCheckDrivers.Enabled = false;
            btnBackOrders.Visible = false;
            btnDeleteOrder.Visible = true; 
            btnEditOrder.Visible = true;


            pnlCheckOrder.Visible = true;
            pnlNewOrder.Visible = false;
            pnlCheckVh.Visible = false;
            pnlNewVh.Visible = false;
            List_Orders();
        }

        private void dtgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditOrder.Enabled = true;
            btnDeleteOrder.Enabled = true;
            btnCheckDrivers.Enabled = true;
        }

        private void dtgOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgOrders.ClearSelection();
            dtgOrders.CurrentCell = null;
            btnEditOrder.Enabled = false;
            btnDeleteOrder.Enabled = false;
        }

        private void btnEditOrder_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEditOrder.Enabled)
            {
                btnEditOrder.BackColor = Color.FromArgb(255, 255, 192);
                btnEditOrder.FlatAppearance.BorderColor = Color.Orange;
            }
            else
            {
                btnEditOrder.BackColor = Color.LightGray;
                btnEditOrder.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void btnDeleteOrder_EnabledChanged(object sender, EventArgs e)
        {
            if (btnDeleteOrder.Enabled)
            {
                btnDeleteOrder.BackColor = Color.FromArgb(255, 192, 192);
                btnDeleteOrder.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                btnDeleteOrder.BackColor = Color.LightGray;
                btnDeleteOrder.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dtgOrders.SelectedCells[5].Value.Equals("Available"))
            {
                btnNewOrder_Click(sender, e);

                txtLabel.Text = dtgOrders.SelectedCells[1].Value.ToString();
                txtDesc.Text = dtgOrders.SelectedCells[2].Value.ToString();
                txtOrderValue.Text = dtgOrders.SelectedCells[3].Value.ToString();

                txtLabel.Focus();
                btnCreateOrder.Text = "Update Order";
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("You can only edit orders with \"Available\" status!", "Update Failed");
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            txtLabel.Text = "";
            txtDesc.Text = "";
            txtOrderValue.Text = "";

            btnCheckOrder_Click(sender, e);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dtgOrders.SelectedCells[5].Value.Equals("Available"))
            {
                var message_response = MessageBox.Show("Are you sure you want delete this order?", "Data Exclusion", MessageBoxButtons.YesNo);

                if (message_response == DialogResult.Yes)
                {
                    conn.Open();

                    try
                    {
                        string sqlQuery = $"DELETE FROM mss_rcv WHERE mss_order = '" + dtgOrders.SelectedCells[0].Value.ToString() + "'";
                        using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        sqlQuery = $"DELETE FROM order_reg WHERE order_id = '" + dtgOrders.SelectedCells[0].Value.ToString() + "'";
                        using (var cmd = new NpgsqlCommand(sqlQuery, conn))
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Order deleted successfully!");

                                conn.Close();
                                List_Orders();
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
                    List_Orders();
                }
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("You can only delete an order with \"Available\" status!", "Exclusion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCheckDrivers_EnabledChanged(object sender, EventArgs e)
        {
            if (btnCheckDrivers.Enabled)
            {
                btnCheckDrivers.BackColor = Color.FromArgb(220, 255, 220);
                btnCheckDrivers.FlatAppearance.BorderColor = Color.Green;
            }
            else
            {
                btnCheckDrivers.BackColor = Color.LightGray;
                btnCheckDrivers.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void btnCheckDrivers_Click(object sender, EventArgs e)
        {
            btnCheckDrivers.Enabled = false;
            btnDeleteOrder.Visible = false;
            btnEditOrder.Visible = false;
            btnBackOrders.Visible = true;

            List_Drivers(dtgOrders.SelectedCells[0].Value.ToString()!);
        }

        private void publish_message()
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqps://ypxyhvgw:AC8vtAVO-bi0kb79QFJYIum3UzAYDH3J@jackal.rmq.cloudamqp.com/ypxyhvgw")
            };

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            channel.ExchangeDeclare(exchange: "newOrderAvailable", type: ExchangeType.Direct);

            string message = order_id.ToString();

            var messageBody = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish("newOrderAvailable", "ActiveRental", null, messageBody);
        }

        private void btnBackOrders_Click(object sender, EventArgs e)
        {
            btnCheckDrivers.Enabled = false;
            btnBackOrders.Visible = false;
            btnCheckOrder_Click(sender, e);
        }
    }
}
