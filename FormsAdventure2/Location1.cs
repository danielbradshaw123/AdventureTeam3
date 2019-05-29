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
    public partial class Location1 : Form
    {
        public Location1()
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
            MessageBox.Show("test");
            storyBox.Text = "testing 123";
        }

        private void characterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void character_Click(object sender, EventArgs e)
        {

        }

        private void Location1_Load(object sender, EventArgs e)
        {

        }
    }
}
