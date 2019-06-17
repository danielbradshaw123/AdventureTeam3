using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;
using System.Reflection;
using System.IO;
using System.Resources;
using System.Diagnostics;

namespace FormsAdventure2
{
    public partial class Location1 : Form
    {
        public Location1()
        {
            InitializeComponent();

            yesButton.Hide();
            noButton.Hide();
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

        }

        private void characterName_TextChanged(object sender, EventArgs e)
        {

        }


        private void Location1_Load(object sender, EventArgs e)
        {
            frm_title.stopaudio();
        }

        public static int clicks = 0;
        public string CharacterName;
        public static int characterCreator = 2;

        public void character_Click_1(object sender, EventArgs e)
        {
            clicks++;
            if (clicks == 1)
            {
                storyBox.Text = "Hi guys it's me, Winston, and welcome to the 'amazing' and 'wonderful' world of Pokéwatch.";
                shadow.Hide();
                characterName.Text = "  Winston";
            }

            if (clicks == 2)
                storyBox.Text = "This world is inhabited by heroes called... well, heroes I guess. For some people, heroes are like idols. Myself... I am a hero who studies other heroes as a profession.";

            if (clicks == 3)
                characterCreator = 0;

            if (characterCreator == 0 && clicks == 3)
            {
                storyBox.Text = "You see, Georg--- wait that's not right! Sorry, I believe we haven't been introduced yet. What was your name again?";
                Btn_CharacterCreator.Show();
            }

            if (characterCreator == 1)
            {
                storyBox.Text = "Thanks! That's much better, now where were we? Oh, that's right. So you see " + FormCharacterCreator.CharacterGender + FormCharacterCreator.CharacterName + ", I trust that you will assist Pokéwatch in the defeat of Talonwatch. We need your guidance, after all.";
                Btn_CharacterCreator.Hide();
            }

            if (clicks >= 6 && characterCreator == 1)
            {
                storyBox.Text = "Your first mission is to assist Tracer in defeating Widowmaker. Do you think you have what it takes to become a hero trainer?";

                yesButton.Show();
                noButton.Show();
            }
        }

        private void Btn_CharacterCreator_Click(object sender, EventArgs e)
        {
            Btn_CharacterCreator.Hide();
            FormCharacterCreator charcreator = new FormCharacterCreator();
            charcreator.Show();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            storyBox.Text = "Great! Get ready, this battle will be a tough one...";
            characterCreator = 0;

            frm_main.Score = frm_main.Score + 50;
            frm_main.scoreUpdate();

            Btn_Battle.Show();
            yesButton.Hide();
            noButton.Hide();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            storyBox.Text = "That's the WRONG answer. Until you gain some faith in your abilities, I will keep asking you until you pick the right answer. I never take NO as an option.";
            yesButton.Hide();
            noButton.Hide();
        }



        public static int Poke_HP = 200;
        public static int Enemy_HP = 200;

        public static bool BattleTime;

        private void Btn_Battle_Click(object sender, EventArgs e)
        {
            frm_main.PokeName = "Tracer";
            frm_main.EnemyName = "Widow";

            GameController.ShowSubform(new FormBattleArena());
        }
    }
}
