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
    public partial class Login : Form
    {
        public static FastUser tUser = new FastUser();

        
        private User retuser = new User();

 

        public User RetUser
        {
            get { return this.retuser; }
            set { this.retuser = value; }
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "7o4BMc60Db3JCCIg8MwvSminScN5rLSwYFpAAV9Y",
            BasePath = "https://passwordstoragev2.firebaseio.com/"
        };

        IFirebaseClient client;

        
        
        public Login()
        {
            InitializeComponent();
           
            client = new FireSharp.FirebaseClient(config);

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
              
        }

        private async void buttonLogin_ClickAsync(object sender, EventArgs e)
        { 
          

            FirebaseResponse responseCH = await client.GetTaskAsync(Username.Text);

            User result = responseCH.ResultAs<User>();
           


            if (Password.Text == result.Password)
            {

                tUser.UpCast(result);


                MainPage main = new MainPage();
                this.Hide();
                if (main.ShowDialog() != DialogResult.OK)
                {
                    this.Show();
                    
                }
                tUser = main.RetUser;
                retuser.DownCast(main.RetUser);
                this.Close();

                

                SetResponse response = await client.SetTaskAsync(retuser.UserName.ToString(), retuser);
                retuser = response.ResultAs<User>();
                tUser = new FastUser();

            }
            else
            {
                MessageBox.Show("incorrect password");
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
