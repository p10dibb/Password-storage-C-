using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PasswordStorage
{
    public partial class ChangeItem : Form
    {
        FastUser retUser = new FastUser();

     
 
        public FastUser RetUser
        {
            get { return this.retUser; }
            set { this.retUser = value; }
        }

        public ChangeItem()
        {
            retUser = MainPage.user;
            InitializeComponent();
        }       

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Search_ClickAsync(object sender, EventArgs e)
        {
            if (retUser.Sites.Contains(this.SearchBox.Text)){

                retUser.Dict[this.SearchBox.Text].Email = this.Email.Text;
                retUser.Dict[this.SearchBox.Text].Password = this.Password.Text;
                retUser.Dict[this.SearchBox.Text].Url = this.URL.Text;
                retUser.Dict[this.SearchBox.Text].Username = this.Username.Text;               
                    
                        this.Close();                                 
                
            }
            else
            {
                MessageBox.Show("site not found");
            }
        }

        private void ChangeItem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Site.Text = retUser.Dict[this.SearchBox.Text].Name;
            this.Username.Text = retUser.Dict[this.SearchBox.Text].Username;
            this.Password.Text = retUser.Dict[this.SearchBox.Text].Password;
            this.URL.Text = retUser.Dict[this.SearchBox.Text].Url;
        }
    }
}
