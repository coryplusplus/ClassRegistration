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
        public User client = null;
        public File_IO sending = new File_IO();
        public File_IO receiving = new File_IO();
        public Schedule course_schedule = new Schedule();

        public Main_Menu(User x)
        {
          
            InitializeComponent();
            client = x;
            sending.set_client(client);
            sending.set_file_name("sending.xml");
            receiving.set_client(client);
            receiving.set_file_name("receiving.xml");
            string test = "";
            XmlTextReader reader = new XmlTextReader("http://bmrwhite.jlrand.com/test.xml");
            Course c = new Course();
            //REPLACE HTTP WITH A LOCAL DIRECTORY WHERE THE FILE WILL BE SAVED

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        test = reader.Name.ToString();

                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name.ToString() == "Class")
                        {

                            course_schedule.append_course(c);
                            c = new Course();//Must use this or it will only print the final course
                            break;
                        }
                        else { break; }
                    case XmlNodeType.Text:

                        switch (test)
                        {
                            case "Select": c.setSelect(reader.Value.ToString()); break;
                            case "CRN": c.setCRN(reader.Value.ToString()); break;
                            case "Subject": c.setSubj(reader.Value.ToString()); break;
                            case "CourseNum": c.setCrse(reader.Value.ToString()); break;
                            case "Section": c.setSec(reader.Value.ToString()); break;
                            //Everything below this will be displayed only in longDisplay
                            case "Campus": c.setCmp(reader.Value.ToString()); break;
                            case "Credit": c.setCred(reader.Value.ToString()); break;
                            case "Title": c.setTitle(reader.Value.ToString()); break;
                            case "Day": c.setDay(reader.Value.ToString()); break;
                            case "StartTime": c.setTime(reader.Value.ToString()); break;
                            case "EndTime": c.setTime(c.getTime() + reader.Value.ToString()); break;
                            case "Capacity": c.setCap(reader.Value.ToString()); break;
                            case "Actual": c.setAct(reader.Value.ToString()); break;
                            case "Remaining": c.setRem(reader.Value.ToString()); break;
                            case "WaitListCap": c.setWL_Cap(reader.Value.ToString()); break;
                            case "WaitListRem": c.setWL_Rem(reader.Value.ToString()); break;
                            case "WaitListAct": c.setWL_Act(reader.Value.ToString()); break;
                            case "StartDate": c.setDate(reader.Value.ToString()); break;
                            case "EndDate": c.setDate(c.getDate() + reader.Value.ToString()); break;
                            case "Instructor": c.setInstructor(reader.Value.ToString()); break;
                            case "Location": c.setLocation(reader.Value.ToString()); break;
                            case "Attribute": c.setAttr(reader.Value.ToString()); break;
                            default: break;
                        }

                        break;
                }


            }
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
            this.Hide();
            View_Classes view_schedule_form = new View_Classes(course_schedule,sending,receiving);
            view_schedule_form.Show();

        }

        private void lookup_class_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Menu search_menu_form = new Search_Menu(course_schedule,sending,receiving);
            search_menu_form.Show();
        }
    }
}