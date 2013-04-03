using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace DeviceApplication2
{
    public class File_IO
    {
        private User client;
        private string file_name;

        public File_IO()
        {
            client = null;
            file_name = null;
        }

        public void set_client(User x)
        {
            client = x;
        }

        public void set_file_name(string x)
        {
            file_name = x;
        }

        public void write_schedule()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("L:\\Visual Studio 2005\\Projects\\xmlTest\\xmlTest\\testing.xml", null);
                writer.WriteStartDocument();

                writer.WriteComment("Student courses registered stored in this file");
                writer.WriteStartElement(client.getID());
                writer.WriteStartElement("Course");
               // writer.WriteStartElement();

                writer.WriteEndElement();


                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                Console.WriteLine(writer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool request_add_course(string crn)
        {
            try
            {
                string response = "false";
                XmlTextWriter writer = new XmlTextWriter("L:\\Visual Studio 2008\\addResult.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("Add");

                writer.WriteStartElement("CRN");
                writer.WriteString(crn);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                XmlTextReader read = new XmlTextReader("addResponse.xml");//Could have implemented in a database
                while (read.Read())
                {
                    switch (read.NodeType)
                    {
                        case XmlNodeType.Text:
                            response = read.Value.ToString();
                            break;
                    }
                }
                read.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }
        public bool request_remove_course(string crn)
        {
            try
            {
                string response = "false";
                XmlTextWriter writer = new XmlTextWriter("L:\\Visual Studio 2008\\removeRequest.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("Remove");

                writer.WriteStartElement("CRN");
                writer.WriteString(crn);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                XmlTextReader read = new XmlTextReader("removeResponse.xml");//Could have implemented in a database
                while (read.Read())
                {
                    switch (read.NodeType)
                    {
                        case XmlNodeType.Text:
                            response = read.Value.ToString();
                            break;
                    }
                }
                read.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }
        public void request_lookup(string subj, string courseNum)
        {  
            try
            {
                XmlTextWriter writer = new XmlTextWriter("L:\\Visual Studio 2008\\searchResult.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("CourseSearch");

                writer.WriteStartElement("Subject");
                writer.WriteString(subj);
                writer.WriteEndElement();

                writer.WriteStartElement("CourseNum");
                writer.WriteString(courseNum);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Boolean request_login(User clientLog)
        {
            try
            {
                Boolean id = false;
                string test = "";
                if ((clientLog.getID() == "") || (clientLog.getPassword() == "")) return false;

                XmlTextWriter writer = new XmlTextWriter("L:\\Visual Studio 2008\\loginRequest.xml", null);
                writer.WriteStartDocument();
                writer.WriteStartElement("StudentLog");

                writer.WriteStartElement("ID");
                writer.WriteString(clientLog.getID().ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("PW");
                writer.WriteString(clientLog.getPassword().ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                XmlTextReader read = new XmlTextReader("loginresponse.xml");//Could have implemented in a database
                while (read.Read())
                {
                    switch (read.NodeType)
                    {
                        case XmlNodeType.Text:
                            test = read.Value.ToString();
                            if (test == "TRUE") { id = true; }
                            break;
                    }
                }
                read.Close();
                if (id == true)
                    return true;


                return false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
