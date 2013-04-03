using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceApplication2
{
    public class User
    {
        private string crimson_id;
        private string password;

        public User(string x, string y)
        {
            crimson_id = x;
            password = y;
        }
        //Added last two methods so that the Login request could be performed
        public string getID(){
            return crimson_id;
        }
        public string getPassword(){
            return password;
        }
    }
}
