using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DeviceApplication2
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
            File_IO.request_schedule();
        }


        private void menuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login_screen_form = new LoginScreen();
            login_screen_form.Show();
        }

        private void view_schedule_Click(object sender, EventArgs e)
        {
            View_Classes view_schedule_form = new View_Classes();
            view_schedule_form.Show();

        }

        private void lookup_class_Click(object sender, EventArgs e)
        {
            Search_Menu search_menu_form = new Search_Menu();
            search_menu_form.Show();
        }


        private void view_q_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void addToCalendar_Click(object sender, EventArgs e)
        {
            //CalendarView.addToCalendar(Schedule.getAll());
        }


    }
}