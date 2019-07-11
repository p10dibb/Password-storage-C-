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
    public partial class SignUp : Form
    {
        public static FastUser tUser = new FastUser();
        private User retUser = new User();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "7o4BMc60Db3JCCIg8MwvSminScN5rLSwYFpAAV9Y",
            BasePath = "https://passwordstoragev2.firebaseio.com/"
        };

        IFirebaseClient client;


        public SignUp()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void signupButton_ClickAsync(object sender, EventArgs e)
        {
            if (this.Password.Text != this.ConfirmPassword.Text)
            {
                MessageBox.Show("passwords do not match");
            }
            else
            {

                if (!CheckEmail())
                {
                    MessageBox.Show("invalid Email");
                }
                else
                {
                    if (false)//firebase contains username
                    {

                    }
                    else
                    {
                        
                        

                       tUser = new FastUser(this.FirstName.Text, this.LastName.Text, this.UserName.Text, this.Password.Text, this.Email.Text);
                       

                        MainPage main = new MainPage();

                        this.Hide();
                        if (main.ShowDialog() != DialogResult.OK)
                        {
                            this.Show();
                        }

                        this.retUser.DownCast(main.RetUser);
                        SetResponse response = await client.SetTaskAsync(retUser.UserName.ToString(), retUser);
                        retUser = response.ResultAs<User>();

                    }
                }
            }
        }

        public bool CheckEmail()
        {
            bool at = false;

            if (this.Email.Text.Length <= 0)
            {
                return false;

            }
            for (int i = 1; i < this.Email.Text.Length; i++)
            {
                if (this.Email.Text[i] == '@')
                {
                    at = true;
                    break;
                }
            }

            if (!at)
            {
                return false;
            }

            //check for dot still needed
            return true;
        }
    }
}
