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
    public partial class frm_main : Form
    {
        static frm_main _instance;

        public frm_main()
        {
            _instance = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form title = new frm_title();
            title.ShowDialog();
            GameController.Start_game(this);
        }

        private void lbl_luck_Click(object sender, EventArgs e)
        {

        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_main_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            
        }


        public static void nameUpdate()
        {
            _instance.txt_NameBox.Text = "Name: " + FormCharacterCreator.CharacterName;
        }

        public static bool Male;

        public static void genderUpdate()
        {
            if (Male == true)
                _instance.txt_Gender.Text = "Gender: Male";

            else
                _instance.txt_Gender.Text = "Gender: Female";
        }

        public static int Score = 0;

        public static void scoreUpdate()
        {
            _instance.txt_Score.Text = "Score: " + Score.ToString();
        }

        public static string PokeName;
        public static string EnemyName;

        public static void heroUpdate()
        {
            _instance.txt_currentHero.Text = "Hero: " + PokeName;
        }

        private void txt_Score_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
