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


namespace Hangman
{

    
    

    public partial class MainScreen : Form
    {
        public int PlayerID;
        
        public string UserAvatar { set; get; }
        public string Password { set; get; }

        public string Age { set; get; }

        public int TotalPoints { set; get; }

        public int CollectedPoints { set; get; }

        public string GameLevel { set; get; }

        public string ChosenWord { set; get; }

        public DateTime DTN { set; get; }

      
        public MainScreen(int PlayerID, string UserAvatar, string Password, string Age, int TotalPoints, int CollectedPoints, string GameLevel, string ChosenWord, DateTime DTN)
        {
            InitializeComponent();
            this.PlayerID = PlayerID;
            this.UserAvatar = UserAvatar;
            this.Password = Password;
            this.Age = Age;
            this.TotalPoints = TotalPoints;
            this.CollectedPoints = CollectedPoints;
            this.GameLevel = GameLevel;
            this.ChosenWord = ChosenWord;
            this.DTN = DTN;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            LoginScreen.StartScreen.Close();   ;

        }

        private void btnGameLevel_Click(object sender, EventArgs e)
        {
           
           GameLevelScreen gameLevel = new GameLevelScreen(this);
           this.Hide();
           gameLevel.Show();
        
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayScreen play = new PlayScreen(this);
            this.Hide();
            play.Show();
           
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {


            



        }

      

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            LeaderBoardScreen leaderBoardScreen = new LeaderBoardScreen(this);
            this.Hide();
            leaderBoardScreen.Show();
          
            
        }

        

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen LogInScreen = new LoginScreen();
            LogInScreen.Show();
            
        }
    }




    
    
}
