using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAdventure2
{
    public partial class game_over : Form
    {
        public game_over()
        {
            InitializeComponent();
            txt_finalScore.Text = "Final Score: " + frm_main.Score;
        }

        private void txt_finalScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
