using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DeviceApplication2
{
    public class File_IO
    {
        public static string client = "";
        public static void set_client(string s)
        {
            client = s;
        }


        public static bool request_add_course(string crn)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("addRequest.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("AddCourse");

                writer.WriteStartElement("CRN");
                writer.WriteString(crn);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public static bool request_remove_course(string crn)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("removeRequest.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("RemoveCourse");

                writer.WriteStartElement("CRN");
                writer.WriteString(crn);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public static Search request_lookup(string subject, string courseNumber)
        {
            Search search_results = new Search();
            try
            {
                XmlTextWriter writer = new XmlTextWriter("searchRequest.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("CourseSearch");

                writer.WriteStartElement("Subject");
                writer.WriteString(subject);
                writer.WriteEndElement();

                writer.WriteStartElement("CourseNumber");
                writer.WriteString(courseNumber);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                Course c = new Course();
                string test = "";

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

                                search_results.add_result(c);
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
                                case "Days": c.setDay(reader.Value.ToString()); break;
                                case "StartTime": c.setTime(reader.Value.ToString()); break;
                                case "EndTime": c.setTime(c.getTime() + "-" + reader.Value.ToString()); break;
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return search_results;
        }
        public static void request_semester()
        {
            try
            {
                string test = "";
                XmlTextWriter writer = new XmlTextWriter("semesterRequest.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("Semester");

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                XmlTextReader reader = new XmlTextReader("semesterResponse.xml");
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            test = reader.Name.ToString();

                            break;

                        case XmlNodeType.Text:

                            switch (test)
                            {
                                case "Term": Semester.append_semester(reader.Value.ToString());
                                    break;
                            }
                            break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void request_selected_sem()
        {
            XmlTextWriter writer2 = new XmlTextWriter("semesterSelectRequest.xml", null);
            writer2.WriteStartDocument();
            writer2.WriteStartElement("SemesterSelected");
            writer2.WriteStartElement("Term");
            writer2.WriteString(Semester.selectedTerm.ToString());
            
            writer2.WriteEndElement();
            writer2.WriteEndElement();
            writer2.WriteEndDocument();
            writer2.Close();
        }
        public static void request_schedule()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("scheduleRequest.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("Schedule");

                writer.WriteStartElement("Request");
                writer.WriteString("true");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Schedule Request...
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

                            Schedule.append_course(c);
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
                            case "Days": c.setDay(reader.Value.ToString()); break;
                            case "StartTime": c.setTime(reader.Value.ToString()); break;
                            case "EndTime": c.setTime(c.getTime() + "-" + reader.Value.ToString()); break;
                            case "Capacity": c.setCap(reader.Value.ToString()); break;
                            case "Actual": c.setAct(reader.Value.ToString()); break;
                            case "Remaining": c.setRem(reader.Value.ToString()); break;
                            case "WaitListCap": c.setWL_Cap(reader.Value.ToString()); break;
                            case "WaitListRem": c.setWL_Rem(reader.Value.ToString()); break;
                            case "WaitListAct": c.setWL_Act(reader.Value.ToString()); break;
                            case "StartDate": c.setDate(reader.Value.ToString()); break;
                            case "EndDate": c.setDate(c.getDate() + '-' + reader.Value.ToString()); break;
                            case "Instructor": c.setInstructor(reader.Value.ToString()); break;
                            case "Location": c.setLocation(reader.Value.ToString()); break;
                            case "Attribute": c.setAttr(reader.Value.ToString()); break;
                            default: break;
                        }

                        break;
                }


            }
        }
        public static Boolean request_login()
        {

            Boolean login = false;
            string loginResult = "";
            if ((User.getID() == "") || (User.getPassword() == "")) return false;

            XmlTextWriter writer = new XmlTextWriter("loginRequest.xml", null);
            writer.WriteStartDocument();
            writer.WriteStartElement("StudentLog");

            writer.WriteStartElement("ID");
            writer.WriteString(User.getID().ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("PW");
            writer.WriteString(User.getPassword().ToString());
            writer.WriteEndElement();



            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            XmlTextReader read = new XmlTextReader("http://dl.getdropbox.com/u/2852286/loginResult.xml");//Could have implemented in a database
            while (read.Read())
            {
                switch (read.NodeType)
                {
                    case XmlNodeType.Text:
                        loginResult = read.Value.ToString();
                        if (loginResult == "TRUE") { login = true; }
                        break;
                }
            }
            read.Close();
            if (login == true)
                return true;


            return false;

        }
    }
}

