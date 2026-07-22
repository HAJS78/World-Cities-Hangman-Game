using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Hangman
{
   
    public partial class GameLevelScreen : Form
    {
      

        private MainScreen _Msc;
        public GameLevelScreen(MainScreen Msc)
        {
            InitializeComponent();
            _Msc = Msc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (rdBEasy.Checked)
            {
                _Msc.GameLevel = "easy";
            
            }
            else if(rdBMedium.Checked) 
            {
                _Msc.GameLevel = "medium";

            }
            else 
            {
                _Msc.GameLevel = "hard";

            }
        
           _Msc.Show(); 
            this.Close();
         
        }

        
    }
}
