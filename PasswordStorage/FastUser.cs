using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage
{
   public class FastUser 
    {
      

        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private string email;

        Dictionary<string, Item> dict = new Dictionary<string, Item>();
        List<Item> wot = new List<Item>();
        List<string> sites = new List<string>();

        public List<Item> Items
        {
            get { return this.wot; }
            set { this.wot = value; }
        }




        public FastUser(string fName = "", string lName = "", string uName = "", string pWord = "", string mail = "")
        {
            this.firstName = fName;
            this.lastName = lName;
            this.userName = uName;
            this.password = pWord;
            this.email = mail;
        }

        public void UpCast(User u)
        {
            this.firstName = u.FirstName;
            this.userName = u.UserName;
            this.LastName = u.LastName;
            this.password = u.Password;
            this.email = u.Email;
            this.wot = u.Items;
            this.sites = u.Sites;
            this.PopDict();
        }
      

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;
            }
        }

        public bool AddItem(string key, Item item)
        {
            //if (this.items.ContainsKey(key))
            //{
            //    this.items[key] = item;
            //}
            //else
            //{
            //    this.items.Add(key, item);
            //    this.sites.Add(key);
            //}

            if (sites.Contains(key))
            {

                //foreach (Item i in items)
                //{
                //    if (i.Name == key)
                //    {

                //        items.Remove(i);
                //    }
                //    break;
                //}
                //items.Add(item);

            }
            sites.Add(key);
            return true;
        }
        public string GetItemsList()
        {
            string ret = "";
            foreach (string str in sites)
            {
                ret = ret + "/r/n";
            }
            return ret;

        }

        public List<string> Sites
        {
            get
            {
                return this.sites;
            }
            set
            {
                this.sites = value;
                sites.Sort();
            }
        }


        public Dictionary<string, Item> Dict
        {
            get { return this.dict; }
            set { this.dict = value; }
        }

        public void PopDict()
        {

            foreach (Item i in this.wot)
            {
                dict.Add(i.Name, i);
            }
        }


    }
}
