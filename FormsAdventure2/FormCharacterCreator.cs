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
    public partial class FormCharacterCreator : Form
    {
        public FormCharacterCreator()
        {
            InitializeComponent();
        }

        private void FormCharacterCreator_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static bool isSaved = false;
        public static string CharacterName = "";
        public static string CharacterGender = "";

        public static int CharacterConfirmed = 0;

        public void button1_Click(object sender, EventArgs e)
        {
            // Checks if pressing alt+f4 should reopen the form
            CharacterConfirmed = 1;

            // Input from "Name" box
            CharacterName = txt_Name.Text;
            frm_main.nameUpdate();

            // Gender input
            if (Rbo_GenderMale.Checked)
            {
                CharacterGender = "Mr. ";
                frm_main.Male = true;
            }

            else
                CharacterGender = "Ms. ";

            frm_main.genderUpdate();

            Location1.characterCreator = 1;
            Location1.clicks = 4;

            frm_main.Score = frm_main.Score + 100;
            frm_main.scoreUpdate();

            Close();

        }

        private void Rbo_GenderMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        // Should the form close without the use of the button, form reopens until character is saved (e.g. alt+f4, task manager, etc.)

        private void FormCharacterCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CharacterConfirmed == 1)
            {
                FormCharacterCreator charcreator = new FormCharacterCreator();
                charcreator.Hide();
            }

            else
            {
                FormCharacterCreator charcreator = new FormCharacterCreator();
                charcreator.Show();
            }
        }
    }
}
