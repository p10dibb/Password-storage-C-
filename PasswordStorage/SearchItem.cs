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
    public partial class SearchItem : Form
    {
        string lastSearch = "";

        FastUser user = new FastUser();
        public SearchItem()
        {
            this.user = MainPage.user;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchItem_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (user.Sites.Contains(this.SearchBox.Text))
            {
                        Item i = this.user.Dict[this.SearchBox.Text];
                        this.URL.Text = i.Url;
                        this.Email.Text = i.Url;
                        this.Password.Text = i.Password;
                        this.UserName.Text = i.Username;                                          
                }
            
            else
            {
                MessageBox.Show("site not found");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
