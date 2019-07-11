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
    public partial class ViewAll : Form
    {
        FastUser user = new FastUser();
        public ViewAll()
        {
             InitializeComponent();
            user = MainPage.user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            string display = "";
            foreach (string i in user.Sites)
            {
                display = display + i + "\t\t"+ user.Dict[i].Password + "\r\n";
            }



            this.textBox1.Text = display;

        }
    }
}
