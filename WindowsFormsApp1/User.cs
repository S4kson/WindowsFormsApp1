using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        private string login;
        private string name;
        private string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
