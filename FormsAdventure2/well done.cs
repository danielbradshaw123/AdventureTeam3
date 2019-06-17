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
    public partial class well_done : Form
    {
        public well_done()
        {
            InitializeComponent();
            txt_finalScore.Text = "Final Score: " + frm_main.Score;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
