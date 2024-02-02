namespace Aluguel_Moto
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtUser.Text);
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
    }
}
