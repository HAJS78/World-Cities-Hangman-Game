using PlayersBuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hangman
{
    public partial class LeaderBoardScreen : Form
    {

        private MainScreen _Msc;

        public LeaderBoardScreen(MainScreen Msc)
        {
            InitializeComponent();
            _Msc = Msc;

        }
        
        private void LeaderBoardScreen_Load(object sender, EventArgs e)
        {

            dgvLeaderBoard.DataSource = clsPlayer.GetLeaderBoard();
                      
            

        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            _Msc.Show();
            this.Close();
        }

        
    }

     
}
