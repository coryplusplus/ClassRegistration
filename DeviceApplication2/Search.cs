using System;
using System.Collections.Generic;
using System.Text;


namespace DeviceApplication2
{
    public class Search
    {
        private List<Course> search_list = new List<Course>();
        private DateTime creation = DateTime.Now;
//////////////////////////////methods//////////////////////////////////
        public void add_result(Course x)
        {
            search_list.Add(x);
        }

        public string get_crn(int index)
        {
            string crn;
            crn = search_list[index].getCRN();
            return crn;
        }

        public Course get_course(int index)
        {
            Course c;
            c = search_list[index];
            return c;
        }

        public int get_size()
        {
            return search_list.Count;
        }



    }
}
