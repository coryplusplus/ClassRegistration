using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;

namespace DeviceApplication2
{

    public partial class LoginScreen : Form
    {
        private System.Windows.Forms.TextBox crimson_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        public bool logged_in = false;

        public LoginScreen()
        {
            InitializeComponent();
        }
        //const string _testconnectionfile = "test.sdf";






        private void menuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            User.setID(crimson_id.Text);
            User.setPassword(password.Text);
            // If FileIO returns success, continue, else prompt for re-entry
            if (File_IO.request_login() == true)
            {
                MessageBox.Show("You Have Logged on Successfully");
                Semester sem = new Semester();
                sem.Show();
                //Main_Menu main_menu_form = new Main_Menu();
                //main_menu_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Either user name or password was incorrect");
            }
        }

        private void menuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void view_saved_schedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule class_schedule = new Schedule();
            View_Classes view_from_login_form = new View_Classes(class_schedule);
            view_from_login_form.Show();

        }
    }
}