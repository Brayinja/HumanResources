using System;
using HumanResources.Model;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace HumanResources.Controller
{
    class Controller
    {
        public HumanResourcesEntities db = new HumanResourcesEntities();

        public Boolean Login(string Username, string Password)
        {
            ObjectParameter Message = new ObjectParameter("responseMessage", typeof(string));
            ObjectParameter IdAdmin = new ObjectParameter("idAdmin", typeof(int));
            int loginQuery = db.PR_AdminLogin(Username, Password, Message, IdAdmin);
            return Message.Value.Equals("Success");
        }

        public ObjectResult<PR_ViewEmployees_Result> GetEmployees()
        {
            return db.PR_ViewEmployees();
        }

        public void ListEmployees(ListView listToShow)
        {
            foreach(var employee in GetEmployees())
            {
                String[] row = {employee.Identification.ToString(), employee.FullName, employee.Email, employee.Phone};
                var listViewItem = new ListViewItem(row);
                listToShow.Items.Add(listViewItem);
            }

            listToShow.DoubleClick += new EventHandler(SelectEmployee);
        }

        public void SelectEmployee(object sender, EventArgs e)
        {

            MessageBox.Show(sender.ToString());
        }

        public void ResetTextField(TextBox textField, Label lblRelation)
        {
            if (textField.Text == "")
            {
                lblRelation.Visible = true;
            }
        }

        public bool CreateEmployee(String identification, String name, String lastname, String email, String phones, String gender, String maritalState, String adress, DateTime birthDate, DateTime hireDate, String title, String salary)
        {
            try
            {
                ObjectParameter Message = new ObjectParameter("responseMessage", typeof(string));
                db.PR_CreateEmployee(Decimal.Parse(identification), name, lastname, email, phones, gender, maritalState, adress, birthDate, hireDate, title, Decimal.Parse(salary), Message);
                return Message.Value.Equals("Success");
            }
            catch
            {
                return false;
            }
        }

        public bool AddPayment(String employeeId, String amount, String description, DateTime date)
        {
            try
            {
                ObjectParameter Message = new ObjectParameter("responseMessage", typeof(string));
                db.PR_AddPayment(Int32.Parse(employeeId), Decimal.Parse(amount), description, date, Message);
                return Message.Value.Equals("Success");
            }
            catch
            {
                return false;
            }
        }
    }
}
