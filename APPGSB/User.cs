using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPGSB
{
    internal class User
    {
        private int id;
        private string username;
        private string password;

        public User(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }
        public int getId()
        {
            return this.id;
        }
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
    }
}
