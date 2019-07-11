using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage
{
    public class Item
    {
        private string name;
        private string password;
        private string username;
        private string email;
        private string url;
        
        public Item()
        {
            name = "";
            password = "";
            email = "";
            url = "";
            username = "";
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }
    }
}
