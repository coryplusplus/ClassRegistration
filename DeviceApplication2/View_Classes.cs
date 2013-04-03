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
    public partial class View_Classes : Form
    {
        private Schedule class_schedule;
        private Search search_results;
        private File_IO sending = new File_IO();
        private File_IO receiving = new File_IO();
        private bool from_login = false;
        private bool add = false;

        public View_Classes(Schedule x)
        {
            try
            {
                from_login = true;

                InitializeComponent();
                class_schedule = x;
                Course c = new Course();

                string test = "";
                add = false;
                from_login = false;

                add_or_remove.Text = "Remove Course";
                class_schedule = x;
                
                XmlTextReader reader = new XmlTextReader("http://bmrwhite.jlrand.com/test.xml");
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
                                //if (class_schedule.getList(c) == false){
                                class_schedule.append_course(c);
                                //}
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


                 for (int i = 0; i < class_schedule.get_size(); i++)
                {
                    class_list.Items.Add(class_schedule.get_course(i).shortprint_course());
                    //need to get rid of .shortprint to enable the use of GUI functions 

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public View_Classes(Schedule x, File_IO send, File_IO receive)
        {//This is from the View Classes button
            
            InitializeComponent();
            Course c = new Course();
            add = false;
            from_login = false;
            sending = send;
            receiving = receive;
            add_or_remove.Text = "Remove Course";
            class_schedule = x;
            
            try
            {
                for (int i = 0; i < class_schedule.get_size(); i++)
                {
                    class_list.Items.Add(class_schedule.get_course(i).shortprint_course());

                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public View_Classes(Search x,Schedule y, File_IO send, File_IO receive)
        {//This is from the LOOKUP Classes button
            InitializeComponent();

            add = true;
            from_login = false;
            Course c = new Course();

            string test = "";
            add = true;
            from_login = false;
            sending = send;
            receiving = receive;
            add_or_remove.Text = "Add Course";
            search_results = x;
            class_schedule = y;

            try
            {
                XmlTextReader reader = new XmlTextReader("http://bmrwhite.jlrand.com/MasterClasses.xml");


                //replace http://blah blah blah with bmrwhite.jlrand.com/"+ username+".xml"
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
                                //Need a conditional to output only searched subject
                                //if (c.getSubj() == textInput.Text){
                                search_results.add_result(c);
                                //}
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
                for (int i = 0; i < search_results.get_size(); i++)
                {
                    class_list.Items.Add(search_results.get_course(i).shortprint_course());

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void add_or_remove_Click(object sender, EventArgs e)
        {
            try
            {
                bool serverResponse = false;
                Course c = new Course();
                File_IO thingy2 = new File_IO();
                int selectedIndex = 0;
                Course selectedCourse = new Course();
                selectedIndex = class_list.SelectedIndex;
                
                //look at student's      
                if (add)
                {
                    selectedCourse = search_results.get_course(selectedIndex);

                    serverResponse = thingy2.request_add_course(selectedCourse.getCRN());
                    if (serverResponse == true)
                    {
                        class_schedule.append_course(selectedCourse);
                        MessageBox.Show("Course added");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add Course");
                    }                 
                }
                else
                {
                    selectedCourse = class_schedule.get_course(selectedIndex);
                    serverResponse = thingy2.request_remove_course(selectedCourse.getCRN());
                    if (serverResponse == true)
                    {
                        //call request_remove_course passing the Course object
                       
                        class_schedule.remove_course(selectedIndex);

                        class_list.Items.Clear();

                        for (int i = 0; i < class_schedule.get_size(); i++)
                        {
                            class_list.Items.Add(class_schedule.get_course(i).shortprint_course());

                        }
                        
                        MessageBox.Show("Course Removed");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Remove Course");
                    }


                }




            }
            catch (Exception d){
                MessageBox.Show(d.Message);
            }
        }
        private void menuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}