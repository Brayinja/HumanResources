using System;
using System.Windows.Forms;

namespace HumanResources
{
    public partial class Login : Form
    {

        private Controller.Controller system = new Controller.Controller();

        public Login()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void TxtPassword_Enter_1(object sender, EventArgs e)
        {
            txtOops.Visible = false;
            lblPassword.Visible = false;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            ResetTextField(txtPassword, lblPassword);
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            txtOops.Visible = false;
            lblUsername.Visible = false;
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            ResetTextField(txtUsername, lblUsername);
            
        }

        private void PasswordEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessLogin();
            }
        }

        private void ProcessLogin()
        {
            var loginUsername = txtUsername.Text;
            var loginPassword = txtPassword.Text;

            if (system.Login(loginUsername, loginPassword))
            {
                this.Hide();
                new RandyOrton().Show();
            }
            else
            {
                txtPassword.Text = "";
                txtPassword.Focus();
                txtOops.Visible = true;
            }
        }

        private void LoginButton(object sender, EventArgs e)
        {

            ProcessLogin();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_DoubleClick(object sender, EventArgs e)
        {
            int locationX = this.Location.X;
            int locationY = this.Location.Y;

            this.SetBounds(locationX, locationY, 284, 257);
        }

        private void ResetTextField(TextBox textField, Label lblRelation)
        {
            if (textField.Text == "")
            {
                lblRelation.Visible = true;
            }
        }
    }
}
