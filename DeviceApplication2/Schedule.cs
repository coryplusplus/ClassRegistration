using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceApplication2
{
   public class Schedule
    {
       private List <Course> schedule_list = new List<Course>();
        private DateTime creation = DateTime.Now;
        private DateTime last_change = DateTime.Now;
///////////////////////////////////////////////////////////
     /*   public bool getCourse(Course x)
        {
            bool find = false;
            find = schedule_list.Exists(x);
            return find;
        }*/
       public void append_course(Course x)
        {
           // if (schedule_list.Exists(x) == false)
            //{

                schedule_list.Add(x);
              //  schedule_list.Sort();
                last_change = DateTime.Now;
            //}
            
        }

       public void remove_course(int index)
        {
            schedule_list.RemoveAt(index);
            last_change = DateTime.Now;
        }

       public Course get_course(int index)
       {
           Course c = new Course();
           c = schedule_list[index];
           return c;
       }
       public string get_crn(int index)
        {
            string crn;
            crn = schedule_list[index].getCRN();
            return crn;
        }
       public int get_size()
       {
           return schedule_list.Count;
       }

        






        
       

    }
}
