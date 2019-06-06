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
    public partial class Location4 : Form
    {
        public Location4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameController.ShowSubform(new Location2());
        }

        private void storyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Location1_Click(object sender, EventArgs e)
        {
            storyBox.Text = "new text";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
