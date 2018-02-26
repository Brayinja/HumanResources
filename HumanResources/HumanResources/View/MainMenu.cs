using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources.View
{
    public partial class MainMenu : Form
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private Controller.Controller system = new Controller.Controller();

        public MainMenu()
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


        private void txtEmployees_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictEmpEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictExitPay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitVac_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitSet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictSetEmp_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPayAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictEmpSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictPaySet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void pictVacSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void pictAdminSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void pictSetSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                barEmpEmp.BackColor = Color.FromArgb(42,162,255);
                lblEmpEmp.ForeColor = Color.White;
                lblEmpEmp.BackColor = Color.FromArgb(42, 162, 255);
                pictEmpEmp.BackColor = Color.FromArgb(42, 162, 255);
                pictEmpEmp.Image = Image.FromFile(path + "/Resources/Employee White.png");
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                barPaySet.BackColor = Color.FromArgb(42, 162, 255);
                lblPaySet.ForeColor = Color.White;
                lblPaySet.BackColor = Color.FromArgb(42, 162, 255);
                pictPaySet.BackColor = Color.FromArgb(42, 162, 255);
                pictPaySet.Image = Image.FromFile(path + "/Resources/Dollar White.png");
            }

            if (tabControl.SelectedIndex == 2)
            {
                barVacAdmin.BackColor = Color.FromArgb(42, 162, 255);
                lblVacAdmin.ForeColor = Color.White;
                lblVacAdmin.BackColor = Color.FromArgb(42, 162, 255);
                pictVacAdmin.BackColor = Color.FromArgb(42, 162, 255);
                pictVacAdmin.Image = Image.FromFile(path + "/Resources/Vac White.png");
            }

            if (tabControl.SelectedIndex == 3)
            {
            
            }

            if (tabControl.SelectedIndex == 4)
            {
           
            }

        }

        private void lblEmpEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void barEmpEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPayEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void llblAdminEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void barSetEmp_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitEmp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitEmp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEmpPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void barEmpPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblPayPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayPay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblVacPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetPay_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitPay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitPay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEmpVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void barEmpVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblPayVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayVac_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblVacVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void barSetVac_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitVac_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitVac_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barEmpAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblEmpAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPayAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPayAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barSetAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblSetAdmin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barEmpSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblEmpSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void lblPaySet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void barPaySet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void lblVacSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void barVacSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void lblAdminSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void barAdminSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void lblSetSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void barSetSet_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void lblExitSet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barExitSet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an easter egg");
        }

        private void iconEmp_Click(object sender, EventArgs e)
        {

        }

        private void tabEmployees_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeSearch_Enter(object sender, EventArgs e)
        {
            lblEmployeeSearch.Visible = false;
        }

        private void txtEmployeeSearch_Leave(object sender, EventArgs e)
        {
            if (txtEmployeeSearch.Text == "")
            {
                lblEmployeeSearch.Visible = true;
            }
        }

        private void txtEmpName_Enter(object sender, EventArgs e)
        {
            lblEmpName.Visible = false;
        }

        private void txtEmpName_Leave(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "")
            {
                lblEmpName.Visible = true;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            lblLastName.Visible = false;
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                lblLastName.Visible = true;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            lblEmail.Visible = false;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblEmail.Visible = true;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            lblPhone.Visible = false;
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                lblPhone.Visible = true;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            lblAddress.Visible = false;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                lblAddress.Visible = true;
            }
        }

        
        private void txtIdentification_Enter(object sender, EventArgs e)
        {
            lblIdentification.Visible = false;
        }

        private void txtIdentification_Leave(object sender, EventArgs e)
        {
            if (txtIdentification.Text == "")
            {
                lblIdentification.Visible = true;
            }
        }


        private void txtTitle_Enter(object sender, EventArgs e)
        {
            lblTitle.Visible = false;
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                lblTitle.Visible = true;
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            lblSalary.Visible = false;
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (txtSalary.Text == "")
            {
                lblSalary.Visible = true;
            }
        }

        private void txtAmmount_Enter(object sender, EventArgs e)
        {
            lblAmmount.Visible = false;
        }

        private void txtAmmount_Leave(object sender, EventArgs e)
        {
            if (txtAmmount.Text == "")
            {
                lblAmmount.Visible = true;
            }
        }

        private void txtPaymentID_Enter(object sender, EventArgs e)
        {
            lblPaymentID.Visible = false;
        }

        private void txtPaymentID_Leave(object sender, EventArgs e)
        {
            if (txtPaymentID.Text == "")
            {
                lblPaymentID.Visible = true;
            }
        }

        private void txtVacationID_Enter(object sender, EventArgs e)
        {
            lblVacationID.Visible = false;
        }

        private void txtVacationID_Leave(object sender, EventArgs e)
        {
            if (txtVacationID.Text == "")
            {
                lblVacationID.Visible = true;
            }
        }




        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabCreateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentification_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewVacation_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 5;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void SubmitCreate(object sender, EventArgs e)
        {
            bool isCreated = system.CreateEmployee(txtIdentification.Text, txtEmpName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, boxGender.Text, boxMarital.Text, txtAddress.Text, dateBirth.Value.Date, dateHire.Value.Date, txtTitle.Text, txtSalary.Text);
            if (isCreated)
            {
                MessageBox.Show("Success");
                tabControl.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Oops Something Went Wrong");
            }
        }

    }
}
