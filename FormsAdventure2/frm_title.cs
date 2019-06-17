using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

using System.Reflection;
using System.IO;
using System.Resources;
using System.Diagnostics;

namespace FormsAdventure2
{
    public partial class frm_title : Form
    {
        public frm_title()
        {
            InitializeComponent();


        }

        private void frm_title_Load(object sender, EventArgs e)
        {
            playaudio();
        }

        private void playaudio()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.start_menu_theme);
            sound.PlayLooping();
        }


        public static void stopaudio()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.start_menu_theme);
            sound.Stop();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
