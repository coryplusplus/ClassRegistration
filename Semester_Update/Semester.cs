using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceApplication2
{
    public partial class Semester : Form
    {
        public static User client = null;
        public static string term = "";
        private static List<string> semester_list = new List<string>();
        public static string selectedTerm = " ";
        DateTime creation = DateTime.Now;
        public Semester(User x)
        {                   
            InitializeComponent();

            File_IO.request_semester();
            string currentSemester = "";
            currentSemester = listBox1.SelectedValue.ToString();

            for (int i = 0; i < semester_list.Count; i++)
            {
               listBox1.Items.Add(semester_list[i]);
                //need to get rid of .shortprint to enable the use of GUI functions 

            }

            
            client = x;   
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void append_semester(string x)
        {

            semester_list.Add(x);
            
            
        }
        public static void getNextTerms()
        {
            

        }
        public static void setTerm(string x)
        {
            term = x;
        }
        public static string getTerm()
        {
            return term;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a semester");
            }
            else
            {
                setSelectedTerm(listBox1.SelectedItem.ToString());
                Main_Menu main_menu_form = new Main_Menu();
                //Schedule will be created using client credentials
                main_menu_form.Show();
                this.Hide();
            }
        }
        public static void setSelectedTerm(string s)
        {
            selectedTerm = s;
        }
        public string getSelectedTerm()
        {
            return selectedTerm;
        }
    }
}