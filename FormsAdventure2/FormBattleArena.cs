using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FormsAdventure2
{
    public partial class FormBattleArena : Form
    {
        public FormBattleArena()
        {
            InitializeComponent();
            Instance = this;

            frm_main.heroUpdate();
            CharacterNames();
            CharacterHitpoints();
            playaudio();
        }

        public static FormBattleArena Instance { get; private set; }

        // bgm
        private void playaudio()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.fight_music);
            sound.PlayLooping();
        }

        //--------------------------------------------------------------------------------------------------------------------------------
        // pulse pistol sound
        private void playPulse()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.pulse);
            sound.Play();

            Thread.Sleep(2000);
        }

        // tracer melee sound
        private void playTracerMelee()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.tracer_melee);
            sound.Play();

            Thread.Sleep(2000);
        }

        // tracer blink sound
        private void playTracerBlink()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.tracer_blink);
            sound.Play();

            Thread.Sleep(2000);
        }

        // tracer pulse bomb sound
        private void playTracerBomb()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.tracer_bomb);
            sound.Play();

            Thread.Sleep(3000);
        }

        // this is used to control the sounds of each playable hero, remains unfinished as of now (will update when needed; once new locations are available to play)
        private void SoundEffects()
        {
            if (frm_main.PokeName == "Tracer")
            {
                
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------


        // hero and enemy statistics boxes
        private void CharacterNames()
        {
            heroName.Text = frm_main.PokeName;
            enemyName.Text = frm_main.EnemyName;
        }

        // update the character's hitpoints
        public void CharacterHitpoints()
        {
            heroHP.Text = "HP: " + Location1.Poke_HP.ToString();
            enemyHP.Text = "HP: " + Location1.Enemy_HP.ToString();
        }

        // update the character's total damage
        private void CharacterDamage()
        {
            heroDmg.Text = "Damage: " + pokeDamage.ToString();
            enemyDmg.Text = "Damage: " + enemyDamage.ToString();
        }

        // hide and show buttons - used for when turn is complete
        private void HideActions()
        {
            Btn_Move1.Hide();
            Btn_Move2.Hide();
            Btn_Move3.Hide();
            Btn_Move4.Hide();
        }

        private void ShowActions()
        {
            if (Move1_amount >= 1)
            Btn_Move1.Show();
            Btn_Move2.Show();
            Btn_Move3.Show();
            if (Move4_amount >= 1)
            Btn_Move4.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------

        private void storyBox_TextChanged(object sender, EventArgs e)
        {
            HideActions();
        }

        private void Enemy_widow_Click(object sender, EventArgs e)
        {

        }

        private void Poke_tracer_Click(object sender, EventArgs e)
        {

        }

        private void Enemy_HP_TextChanged(object sender, EventArgs e)
        {
            enemyHP.Text = "HP: " + Location1.Enemy_HP.ToString();
        }

        private void Poke_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Poke_Dmg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Poke_HP_TextChanged(object sender, EventArgs e)
        {
            heroHP.Text = "HP: " + Location1.Poke_HP.ToString();
        }

        private void Enemy_Dmg_TextChanged(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------------------

        public int Move1_amount = 3;

        public string Move1 = "Pulse Pistols";
        public string Move2 = "Melee";
        public string Move3 = "Blink";
        public string Move4 = "Pulse Bomb";

        private void Move1_Click(object sender, EventArgs e)
        {
            HideActions();
            int i = 25;
            storyBox.Text = frm_main.PokeName + " used " + Move1 + ", dealing " + i + " damage!";
            Application.DoEvents();

            Move1_amount = Move1_amount - 1;
            
            frm_main.Score = frm_main.Score + i;
            frm_main.scoreUpdate();

            pokeDamage = pokeDamage + i;
            heroDmg.Text = "Damage: " + pokeDamage;

            Location1.Enemy_HP = Location1.Enemy_HP - i;

            if (storyBox.Text == frm_main.PokeName + " used " + Move1 + ", dealing " + i + " damage!")
                playPulse();

            LowEnemyHP();
            CharacterHitpoints();

            if (Location1.Enemy_HP != 0)
                EnemyAttack();

            ActionNameUpdate();
        }

        private void Move2_Click(object sender, EventArgs e)
        {
            int i = 15;

            storyBox.Text = frm_main.PokeName + " used " + Move2 + ", dealing " + i + " damage!";
            Application.DoEvents();

            frm_main.Score = frm_main.Score + i;
            frm_main.scoreUpdate();

            pokeDamage = pokeDamage + i;
            heroDmg.Text = "Damage: " + pokeDamage;

            Location1.Enemy_HP = Location1.Enemy_HP - i;
            playTracerMelee();

            LowEnemyHP();
            CharacterHitpoints();

            Application.DoEvents();

            if (Location1.Enemy_HP != 0)
                EnemyAttack();

            ActionNameUpdate();
        }

        private void Move3_Click(object sender, EventArgs e)
        {
            int i = 1;

            storyBox.Text = frm_main.PokeName + " used " + Move3 + ", dealing " + i + " damage!";
            Application.DoEvents();

            frm_main.Score = frm_main.Score + i;
            frm_main.scoreUpdate();

            pokeDamage = pokeDamage + i;
            heroDmg.Text = "Damage: " + pokeDamage;

            Location1.Enemy_HP = Location1.Enemy_HP - i;
            playTracerBlink();
            CharacterHitpoints();

            Application.DoEvents();

            if (Location1.Enemy_HP != 0)
                EnemyAttack();

            ActionNameUpdate();
        }

        public int Move4_amount = 2;

        private void Move4_Click(object sender, EventArgs e)
        {
            int i = 45;

            storyBox.Text = frm_main.PokeName + " used " + Move4 + ", dealing " + i + " damage, while self-inflicting 10 damage!";
            Application.DoEvents();

            frm_main.Score = frm_main.Score + i;
            frm_main.scoreUpdate();

            pokeDamage = pokeDamage + i;
            heroDmg.Text = "Damage: " + pokeDamage;

            Move4_amount = Move4_amount - 1;

            Location1.Enemy_HP = Location1.Enemy_HP - 45;
            Location1.Poke_HP = Location1.Poke_HP - 10;
            playTracerBomb();

            LowEnemyHP();
            CharacterHitpoints();

            Application.DoEvents();

            if (Location1.Enemy_HP != 0)
            EnemyAttack();

            ActionNameUpdate();
        }

        private void ActionNameUpdate()
        {
            Btn_Move1.Text = Move1 + @"
Damage: 25
Moves Remaining: " + Move1_amount + " / 3";

            Btn_Move4.Text = Move4 + @"
Damage: 45
Moves Remaining: " + Move4_amount + " / 2";
        }

        //--------------------------------------------------------------------------------------------------------------------------------
        private void pickaMove()
        {
            storyBox.Text = "                                         Pick a Move";
        }
        //--------------------------------------------------------------------------------------------------------------------------------

        // widow sniper sound
        private void playWidowSnipe()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.widow_shot);
            sound.Play();

            var t = Task.Delay(3000);
            t.Wait();

            playaudio();
            pickaMove();
        }

        // widow smg sound
        private void playWidowSmg()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.widow_smg);
            sound.Play();

            var t = Task.Delay(3000);
            t.Wait();

            playaudio();
            pickaMove();
        }

        // widow melee sound
        private void playWidowMelee()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.widow_melee);
            sound.Play();

            var t = Task.Delay(3000);
            t.Wait();

            playaudio();
            pickaMove();
        }

        // widow hello sound
        private void playWidowHello()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.widow_hello);
            sound.Play();

            var t = Task.Delay(3000);
            t.Wait();

            playaudio();
            pickaMove();
        }
        //--------------------------------------------------------------------------------------------------------------------------------

        // death sound
        private void playDeath()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.death);
            sound.Play();

            Thread.Sleep(4000);
        }

        private void LowEnemyHP()
        {
            if (Location1.Enemy_HP < 0)
                Location1.Enemy_HP = 0;

            if (Location1.Enemy_HP == 0)
            {
                enemyHP.Text = "HP: 0";

                Enemy.Hide();
                playDeath();
                GameController.ShowSubform(new well_done());
            }
        }

        public int LowPokeHP = 10;

        public string EnemyMove1 = "Snipe";
        public string EnemyMove2 = "SMG";
        public string EnemyMove3 = "Melee";
        public string EnemyMove4 = "\"Hello\"";

        public int pokeDamage = 0;
        public int enemyDamage = 0;


        private void EnemyAttack()
        {
            if (Location1.Poke_HP >= 150)
            {
                int i = 30;
                storyBox.Text = frm_main.EnemyName + " used " + EnemyMove1 + ", dealing " + i.ToString() + " damage to " + frm_main.PokeName + ".";

                enemyDamage = enemyDamage + i;
                enemyDmg.Text = "Damage: " + enemyDamage;

                Location1.Poke_HP = Location1.Poke_HP - i;

                Application.DoEvents();
                playWidowSnipe();
                CharacterHitpoints();

                ShowActions();
            }

            else if (Location1.Poke_HP >= 100 && Location1.Poke_HP < 150)
            {
                int i = 25;
                storyBox.Text = frm_main.EnemyName + " used " + EnemyMove2 + ", dealing " + i.ToString() + " damage to " + frm_main.PokeName + ".";

                enemyDamage = enemyDamage + i;
                enemyDmg.Text = "Damage: " + enemyDamage;

                Location1.Poke_HP = Location1.Poke_HP - i;

                Application.DoEvents();
                playWidowSmg();
                CharacterHitpoints();

                ShowActions();
            }

            else if (Location1.Poke_HP > 50 && Location1.Poke_HP < 100)
            {
                int i = 20;
                storyBox.Text = frm_main.EnemyName + " used " + EnemyMove3 + ", dealing " + i.ToString() + " damage to " + frm_main.PokeName + ".";

                enemyDamage = enemyDamage + i;
                enemyDmg.Text = "Damage: " + enemyDamage;

                Location1.Poke_HP = Location1.Poke_HP - 20;

                Application.DoEvents();
                playWidowMelee();
                CharacterHitpoints();

                ShowActions();
            }

            else if (Location1.Poke_HP > 0 && Location1.Poke_HP <= 50)
            {
                int i = 10;
                storyBox.Text = frm_main.EnemyName + " used " + EnemyMove4 + ", dealing " + i.ToString() + " damage to " + frm_main.PokeName + ".";

                enemyDamage = enemyDamage + i;
                enemyDmg.Text = "Damage: " + enemyDamage;

                if (Location1.Poke_HP < 10)
                    i = Location1.Poke_HP;

                Location1.Poke_HP = Location1.Poke_HP - i;

                Application.DoEvents();
                playWidowHello();
                CharacterHitpoints();

                if (Location1.Poke_HP == 0)
                {
                    heroHP.Text = "HP: 0";

                    Hero.Hide();
                    playDeath();

                    GameController.ShowSubform(new game_over());
                }

                ShowActions();
            }
        }

        public static int clicks = 0;

        private void Btn_Inventory_Click(object sender, EventArgs e)
        {
            clicks++;

            if (clicks == 1)
            {
                Inventory.firstTime = true;
                Inventory inventory = new Inventory();
                inventory.Show();
            }
            else
            {
                Inventory.firstTime = false;
                Inventory inventory = new Inventory();
                inventory.Show();
            }
        }
    }
}
