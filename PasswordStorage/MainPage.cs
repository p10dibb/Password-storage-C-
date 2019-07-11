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
    public partial class MainPage : Form
    {
       
        public static FastUser user=new FastUser();
        private FastUser retUser = new FastUser();

        public FastUser RetUser
        {
            get { return this.retUser; }
            set { this.retUser = value; }
        }

        public MainPage()
        {
            
       
            
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            user = SignUp.tUser;
            if (user.FirstName == "")
            {
                user = Login.tUser;
            }
            retUser = user;
            this.Name.Text = user.FirstName + " " + user.LastName;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItem add = new AddItem();

            this.Hide();
            if (add.ShowDialog() != DialogResult.OK)
            {
                this.Show();
            }
           retUser= user = add.RetUser;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAll all = new ViewAll();

            this.Hide();
            if (all.ShowDialog() != DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchItem search = new SearchItem();

            this.Hide();
            if (search.ShowDialog() != DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeItem change = new ChangeItem();

            this.Hide();
            if (change.ShowDialog() != DialogResult.OK)
            {
                this.Show();
            }

            user = change.RetUser;
            retUser = change.RetUser;
        }
    }
}
