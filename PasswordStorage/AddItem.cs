using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PasswordStorage
{
    public partial class AddItem : Form
    {
        private FastUser retUser = new FastUser();

      

        public FastUser RetUser
        {
            get { return this.retUser; }
            set { this.retUser = value; }
        }

        public AddItem()
        {
            retUser = MainPage.user;
            InitializeComponent();

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = Name.Text;
            item.Url = URL.Text;
            item.Email = Email.Text;
            item.Username = this.UserName.Text;


            if (this.retUser.Sites.Contains(this.Name.Text))
            {
                MessageBox.Show("site already made");
            }
            else
            {
                if (Password.Text != ConfirmPassword.Text)
                {
                    MessageBox.Show("passwords dont match");
                }
                else
                {
                    item.Password = Password.Text;



                    retUser.Sites.Add(item.Name);
                    retUser.Items.Add(item);
                    retUser.Dict.Add(item.Name, item);
                    retUser.Sites.Sort();
                    this.Close();


                }
            }
               


           
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
