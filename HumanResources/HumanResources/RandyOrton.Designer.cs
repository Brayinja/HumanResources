using System.Diagnostics;

namespace HumanResources
{
    partial class RandyOrton
    {
        // To repoio
        private Controller.Controller system = new Controller.Controller();
        // End repoio

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            // To repoio
            initEmployeeList();
            // End repoio
        }

        // To repoio
        private void initEmployeeList()
        {
            this.listEmployee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.listEmployee.FormattingEnabled = true;
            this.listEmployee.MultiColumn = true;

            var databaseEmployees = system.getEmployees();
            foreach(var employee in databaseEmployees){
                var employeeString = employee.Identification + ",";
                employeeString += employee.FullName + ",";
                employeeString += employee.Email + ",";
                employeeString += employee.Phone + ",";
                this.listEmployee.Items.Add(employeeString);
            }

            this.listEmployee.Items.AddRange(new object[] {
            "Item 1, column 1",
            "Item 2, column 1 ",
            "Item 3, column 1",
            "Item 4, column 1",
            "Item 5, column 1",
            "Item 1, column 2",
            "Item 2, column 2",
            "Item 3, column 2"});
            this.listEmployee.Location = new System.Drawing.Point(189, 39);
            this.listEmployee.Name = "listBox1";
            this.listEmployee.Size = new System.Drawing.Size(633, 316);
            this.listEmployee.TabIndex = 0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 478);
            this.Controls.Add(this.listEmployee);
            this.Name = "RandyOrton";
            this.Text = "RandyOrton";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.ListBox listEmployee;
        // End repoio
    }
}