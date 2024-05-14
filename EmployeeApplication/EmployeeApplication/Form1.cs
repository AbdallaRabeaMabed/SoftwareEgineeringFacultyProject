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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // create object from the second form (sign up)
            FormSignUp formRegister = new FormSignUp();
            // Hide the login form
            this.Hide();
            // assign the Close action from the login form (this form)
            //to the signup form
            formRegister.FormClosed += (s, args) => this.Close();
            // Display SignUp
            formRegister.Show();
        }
    }
}
