using Hangman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

using PlayersBuisnessLayer;


namespace Hangman
{
    public partial class PlayScreen : Form
    {
        private MainScreen _Msc; 
       
        private string[] Letters;
        private int[] LettersPositionInWord;
        int MissedTry = 0;
        int RemainingGamerLives = 6;
        int PreviuoslyCollectedPoints = 0;
        bool gameplayed = false;
        public PlayScreen(MainScreen Msc)
        {
            InitializeComponent();
            _Msc = Msc;
        }

        private void Play_Load(object sender, EventArgs e)
        {

            this.lblUserName.Text = _Msc.UserAvatar;
            this.lblCollectedPoints.Text = _Msc.CollectedPoints.ToString();
            this.lblPlayingGameLevel.Text = _Msc.GameLevel;
            this.lblTotalPoints.Text = _Msc.TotalPoints.ToString();
            PreviuoslyCollectedPoints =_Msc.CollectedPoints;
               
         

            


        }

        private void btnBackToMainScreen_Click(object sender, EventArgs e)
        {
            if (gameplayed)
            {
                clsGameSession.Save(_Msc.UserAvatar, _Msc.ChosenWord, _Msc.CollectedPoints, DateTime.Now);
            }
            _Msc.Show();
            this.Close();
           
        }
        private void EnableAlphabetButtons() 
        {
            foreach (Control ctrl in this.Controls)

            {

                if (ctrl.GetType().Equals(typeof(Button)))

                {
                    if (ctrl.Tag == "Alphabet")
                    {
                        ctrl.Enabled = true;
                    }
                }

            }

        }

        private void DisableAlphabetButtons()
        {
            foreach (Control ctrl in this.Controls)

            {

                if (ctrl.GetType().Equals(typeof(Button)))

                {
                    if (ctrl.Tag == "Alphabet")
                    {
                        ctrl.Enabled = false;
                    }
                }

            }

        }

      
        private void WordToLetters(string word) 

        {
         Letters= new string[word.Length];

         for(int i=0; i< word.Length ; i++) 
            {

                Letters[i] = word[i].ToString();


            }
        
        
        }
        private string SelectWord(string GmeDiffLevel) 
        {

            return clsWord.SelectWordRandomly(GmeDiffLevel);

            

        }

        private void ShowSelectedWordAsDashes(string SelectedWord) 
        {
            foreach (Control ctrl in this.Controls)

            {

                if (ctrl is Label)

                {
                    if (ctrl.Tag.ToString() != "non_alphabet")
                    {

                        if (Convert.ToInt32(ctrl.Tag) <= SelectedWord.Length-1)
                        {
                            ctrl.Visible = true;
                        }
                    }
                }

            }

        }

        private int CountOccurencesOfLetter(string Letter) 
        {
            int index = 0;
            int counter = 0;
            index= _Msc.ChosenWord.IndexOf(Letter);
           
            while (index != -1) 
            {
                counter++;
                index= _Msc.ChosenWord.IndexOf(Letter,index+Letter.Length);

            } 
        
         return counter;
        
        }
        private bool IsSelectedLetterInHiddenWord(string Letter)
        {
            if(!_Msc.ChosenWord.Contains(Letter))
                return false;
            
            
            int LetterOccurences=CountOccurencesOfLetter(Letter);

            LettersPositionInWord = new int[LetterOccurences];
            
            bool indicator = false;
            int counter = 0;

            for (int i = 0; i < Letters.Length; i++)
            {
                if (Letters[i] == Letter)
                {
                    LettersPositionInWord[counter] = i;
                    indicator = true;
                    counter++;
                }

            }

            return indicator;
        }

        private void FillDashesWithLetters(string Letter)
        {
           
            foreach (Control ctrl in this.Controls)

            {

                if (ctrl.GetType().Equals(typeof(Label)))

                {
                    if (ctrl.Tag.ToString() != "non_alphabet")
                    {
                        if (Convert.ToInt32(ctrl.Tag) <= Letters.Length)
                        {
                            for (int i = 0; i < LettersPositionInWord.Length; i++)
                            {
                                if (LettersPositionInWord[i] == Convert.ToInt32(ctrl.Tag))
                                {
                                    ctrl.Text = Letters[Convert.ToInt32(ctrl.Tag)];
                                    
                                }


                            }
                           


                        }
                    }
                }

            }

        }
        private void btnPlay_Click(object sender, EventArgs e) 
        {
            gameplayed = true;
            btnPlay.Enabled= false;
            _Msc.ChosenWord = SelectWord(_Msc.GameLevel);
            WordToLetters(_Msc.ChosenWord);
            EnableAlphabetButtons();
            MessageBox.Show("Game is started", "Info", MessageBoxButtons.OK);
            ShowSelectedWordAsDashes(_Msc.ChosenWord);
            btnBackToMainScreen.Enabled= false;
           
         
        }

       private void ChangHangmanPic(int MissedTry) 
        {

            switch (MissedTry)
            {


                case 1:
                    picBHangMan.Image = Resources.gallow_head;
                    break;

                case 2:
                    picBHangMan.Image = Resources.gallow_head_torso;
                    break;

                case 3:
                    picBHangMan.Image = Resources.gallow_head_torso_r_arm;
                    break;

                case 4:
                    picBHangMan.Image = Resources.gallow_head_torso_r_arm_l_arm;
                    break;
                case 5:
                    picBHangMan.Image = Resources.gallow_head_torso_r_arm_l_arm_r_leg;
                    break;

                case 6:
                    picBHangMan.Image = Resources.FullMan;
                    break;

            }


        }
        private bool IsThereWinner() 
        {

            foreach (Control ctrl in this.Controls)

            {

                if (ctrl is Label)

                {
                    if (ctrl.Tag.ToString() != "non_alphabet")
                    {

                        if ((ctrl.Text=="_") && (Convert.ToInt32(ctrl.Tag)<_Msc.ChosenWord.Length))
                        {
                            return false;
                        }
                    }
                }

            }
            return true;

        }
        private void UpdateGamerCollectedPoints() 
        {

            _Msc.CollectedPoints = _Msc.ChosenWord.Length * 10;


        }

        private bool GamerHanged(int MissedTry) 
        {

            return MissedTry == 6;
        
        
        }
        private bool IsNotGuest() 
        {

            return _Msc.UserAvatar != "Guest";
        }
        private void btn_Click(object sender, EventArgs e)
        {
            
            Button LetterButton = (Button)sender;
            if (IsSelectedLetterInHiddenWord(LetterButton.Text.ToLower()))
            {
                
                FillDashesWithLetters(LetterButton.Text);
                LetterButton.Enabled = false;
                LetterButton.BackColor = Color.Green;
                if (IsThereWinner()) 
                {
                MessageBox.Show("Congrats You Guessed The Hidden Word","Game Won",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBackToMainScreen.Enabled = true;
                    if (IsNotGuest())
                    {
                        UpdateGamerCollectedPoints();
                        _Msc.TotalPoints += _Msc.CollectedPoints;
                        clsPlayer CurrentPlayer = new clsPlayer(_Msc.PlayerID,_Msc.UserAvatar, _Msc.Password, _Msc.Age, _Msc.TotalPoints);
                        CurrentPlayer.Save();
                        
                    }
                    DisableAlphabetButtons();
                }

            }
            else 
            {
                RemainingGamerLives--;
                lblNumberOfRemainingLives.Text = RemainingGamerLives.ToString();
                MissedTry++;
                ChangHangmanPic(MissedTry);
                LetterButton.Enabled = false;
                LetterButton.BackColor = Color.Red;
                if (GamerHanged(MissedTry)) 
                {
                    btnBackToMainScreen.Enabled = true;
                    MessageBox.Show("You Are Hanged", "Game Lost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DisableAlphabetButtons();



                }

            }

            

        }
    }
}
