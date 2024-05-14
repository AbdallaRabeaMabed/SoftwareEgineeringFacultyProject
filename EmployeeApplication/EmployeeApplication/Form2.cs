using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        long nationalID;
        string fullName, gender, dateOfBirth, job, password;
        double salary;

        private void buttonSort_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SortBySalary(this.databaseEmployeeAppDataSet.Employee);
        }

        private void buttonGetMales_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillByMales(this.databaseEmployeeAppDataSet.Employee);
        }

        private void buttonBigSalary_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.BigSalary(this.databaseEmployeeAppDataSet.Employee);
        }

        private void buttonMinSalary_Click(object sender, EventArgs e)
        {
            double minSalary;
            minSalary = (double)this.employeeTableAdapter.MinSalary();
            labelMinSalaryValue.Text = minSalary.ToString();

            MessageBox.Show("Minimum Salary = " + minSalary);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchByName(this.databaseEmployeeAppDataSet.Employee, textBoxSearch.Text);
        }

        private void numericUpDownSalary_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNationalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            nationalID = long.Parse(nationalIDTextBox.Text);

            fullName = fullNameTextBox.Text;

            gender = genderTextBox.Text;

            dateOfBirth = dateOfBirthDateTimePicker.Value.ToString("yyyy-MM-dd");

            job = jobTextBox.Text;

            password = passwordTextBox.Text;

            salary = double.Parse(salaryTextBox.Text);
           
            this.employeeTableAdapter.DeleteEmployee(nationalID, fullName, gender, dateOfBirth, job, password, salary);

            this.employeeTableAdapter.Fill(this.databaseEmployeeAppDataSet.Employee);

            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseEmployeeAppDataSet);
        }

      
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //Get data from form application
            nationalID = long.Parse(textBoxNationalID.Text);

            fullName = textBoxFullName.Text;

            gender = "";
            bool isChecked = radioMale.Checked;
            if (isChecked)
                gender = radioMale.Text;
            else
                gender = radioFemale.Text;

            dateOfBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            job = comboBoxJob.SelectedItem.ToString();

            password = textBoxPassword.Text;

            salary = (double)numericUpDownSalary.Value;
            
            this.employeeTableAdapter.InsertEmployee(nationalID,fullName,gender,dateOfBirth,job,password,salary);

            this.employeeTableAdapter.Fill(this.databaseEmployeeAppDataSet.Employee);

            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseEmployeeAppDataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseEmployeeAppDataSet);

        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseEmployeeAppDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.databaseEmployeeAppDataSet.Employee);

        }
    }
}
