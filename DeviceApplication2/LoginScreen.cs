using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
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
            File_IO thingy = new File_IO();

            User client = new User(crimson_id.Text, password.Text);
            thingy.set_client(client);
            //If FileIO returns success, continue, else prompt for re-entry
            if (thingy.request_login(client) == true)
            {
                MessageBox.Show("You Have Logged on Successfully");
                this.Hide();
                Main_Menu main_menu_form = new Main_Menu(client);
                //Schedule will be created using client credentials
                main_menu_form.Show();
            }
            else
            {
                MessageBox.Show("Either user_name or password was incorrect");
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();


            Calendar form5 = new Calendar();


            form5.Show();
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


       
       
        /*/protected override void OnPaint(PaintEventArgs e)
        {
            // Create string to draw.
            string drawString = "The University of Alabama";

            // Create font and brush.
            Font drawFont = new Font("Arial", 10, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            // Create point for upper-left corner of drawing.
          
            
            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, 35, 0);
            e.Graphics.DrawString("Class Registration Application", drawFont, drawBrush,30, 25);
            e.Graphics.Clear(Color.White);

           
           
        }/*/




     
    }
}