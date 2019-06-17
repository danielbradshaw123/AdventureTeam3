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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        public static Inventory Instance2 { get; private set; }

        public static int Potion = 0;

        private void CharacterHitpoints()
        {
            FormBattleArena.Instance.heroHP.Text = "HP: " + Location1.Poke_HP.ToString();
            FormBattleArena.Instance.enemyHP.Text = "HP: " + Location1.Enemy_HP.ToString();
        }

        public static bool firstTime;

        private void lbl_BioticGrenade_Click(object sender, EventArgs e)
        {
            FormBattleArena.Empty = 1;

            lbl_BioticAmount.Hide();
            lbl_BioticDesc.Hide();
            lbl_BioticGrenade.Hide();
            img_Biotic.Hide();

            if (Location1.Poke_HP <= 180)
                Location1.Poke_HP = Location1.Poke_HP + 20;

            else if (Location1.Poke_HP > 180)
            {
                Location1.Poke_HP = 200;
            }

            lbl_itemless.Show();
            CharacterHitpoints();
        }

        private void Btn_closeInventory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            if(firstTime == true)
            {
                lbl_BioticAmount.Show();
                lbl_BioticDesc.Show();
                lbl_BioticGrenade.Show();
                img_Biotic.Show();
            }
            else
            {
                lbl_BioticAmount.Hide();
                lbl_BioticDesc.Hide();
                lbl_BioticGrenade.Hide();
                img_Biotic.Hide();

                lbl_itemless.Show();
            }
        }
    }
}
