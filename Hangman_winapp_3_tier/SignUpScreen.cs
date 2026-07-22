using System;
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
    public partial class SignUpScreen : Form
    {
        private LoginScreen _Lgsc ;
        public SignUpScreen(LoginScreen Lgsc)
        {
            InitializeComponent();
            _Lgsc = Lgsc;
        }

       private void btnCreateAccount_Click(object sender, EventArgs e)
       {
           

          
            if (clsPlayer.Find(txtBUserName.Text, txtBPassword.Text,clsPlayer.EnCredentialsMode.SignUp) == null)
            {
                clsPlayer NewPlayer = new clsPlayer(txtBUserName.Text, txtBPassword.Text, txtBAge.Text,0);
                MessageBox.Show("Account created successfully ", "Creating Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Use your userid and password to login in the login screen ", "Creating Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPlayer.Save();
                btnCreateAccount.Enabled = false;
            }
            else 
            {
                MessageBox.Show("UserName is already taken,please select another user name","Creating Account",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtBUserName.Text = "";
                txtBPassword.Text = "";
                txtBAge.Text = "";
                //btnCreateAccount.Enabled = true;
            }

           
       }

        private void txtBAge_TextChanged(object sender, EventArgs e)
        {
            btnCreateAccount.Enabled = true;
        }

        private void btnBackToLoginScreen_Click(object sender, EventArgs e)
        {
           _Lgsc.Show();
           this.Close();
            
        }
    }
}
