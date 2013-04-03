using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceApplication2
{
    public partial class Search_Menu : Form
    {
        private File_IO sending = new File_IO();
        private File_IO receiving = new File_IO();
        private Search search_list = new Search();
        private Schedule course_schedule = new Schedule();
        public Search_Menu(Schedule y, File_IO send, File_IO receive)
        {
            course_schedule = y;
            sending = send;
            receiving = receive;
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit_search_Click(object sender, EventArgs e)
        {
            File_IO sending = new File_IO();
            sending.request_lookup(subject_input.Text,course_number_input.Text);
            //search_list = receiving.read_file()
            this.Hide();
            View_Classes view_search_list_form = new View_Classes(search_list,course_schedule,sending,receiving);
            view_search_list_form.Show();
        }
    }
}