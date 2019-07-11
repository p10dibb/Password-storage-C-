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
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private async void Login_ClickAsync(object sender, EventArgs e)
        {
            Login log = new Login();

            User user = new User();
           
            this.Hide();
            if (log.ShowDialog()!= DialogResult.OK)
            {
               
                this.Show();
                
            }
         

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            
            SignUp sign = new SignUp();

            this.Hide();
            if (sign.ShowDialog() != DialogResult.OK)
            {
                this.Show();
            }


        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
