using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayersBuisnessLayer;


namespace Hangman
{
    

    public partial class LoginScreen : Form
    {


        public static Start StartScreen;
        public LoginScreen(Start startScreen)
        {
            InitializeComponent();
            StartScreen = startScreen;
        }

        public LoginScreen()
        {
            InitializeComponent();
        }
         private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            SignUpScreen signUpScreen = new SignUpScreen(this);
            this.Hide();
            signUpScreen.Show();
           
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            clsPlayer CurrentPlayer = clsPlayer.Find(txtBUserID.Text, txtBPassword.Text,clsPlayer.EnCredentialsMode.Login);
            if (CurrentPlayer != null) 
            {
                MainScreen Msc = new MainScreen(CurrentPlayer.ID,CurrentPlayer.AvatarName,CurrentPlayer.Password,CurrentPlayer.Age,CurrentPlayer.TotalPoints,0,"","",DateTime.Now);
                MessageBox.Show("You Logged in successfully","LogIn Info",MessageBoxButtons.OK);
                Msc.Show();
                this.Close();
                
                
            }
            else 
            {
                MessageBox.Show("User With these credentials could not be found in our database."+Environment.NewLine+"Please Check your credentials or signup for an account", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
            
            
            
          

        }

        private void txtBPassword_TextChanged(object sender, EventArgs e)
       {
            btnLogin.Enabled = true;

        }

        private void chkBCreateNewAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBCreateNewAccount.Checked)
            {
                txtBUserID.Text = "";
                txtBPassword.Text = "";
                btnSignUp.Enabled = true;

            }
            else
            {

                btnSignUp.Enabled = false;
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
           

        }
    }


   
}
