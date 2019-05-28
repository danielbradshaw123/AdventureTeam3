using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAdventure2
{
    // class to contain functions to control the game and update the main form
    static class GameController
    {
        private static Character player;
        private static Form main;
        private static Panel main_panel;

        public static void Start_game(Form f)
        {
            // find main form
            main = f;

            // find the main panel to display subforms
            Panel foundpanel = (Panel)main.Controls.Find("pnl_main", true).First();
            if (foundpanel != null)
            {
                main_panel = foundpanel;
            }

            // create the game character and update character panel on main form
            player = new Character();
            //UpdatePnlCharacter();

            // display first location in panel on main form
            ShowSubform(new Location1());

        }


        // use to load subform into main panel
        public static void ShowSubform(Form subform)
        {
            subform.TopLevel = false;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(subform);
            subform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //subform.Dock = DockStyle.Fill;
            subform.Show();
        }


        // used to update the character panel after any changes to character stats
        private static void UpdatePnlCharacter()
        {
            Label foundlabel;
            foundlabel = (Label)main.Controls.Find("lbl_name",true).First();
            if (foundlabel != null)
                foundlabel.Text = "Name: " + player.name;

            foundlabel = (Label)main.Controls.Find("lbl_luck", true).First();
            if (foundlabel != null)
                foundlabel.Text = "Luck: " + player.luck;

            foundlabel = (Label)main.Controls.Find("lbl_gold", true).First();
            if (foundlabel != null)
                foundlabel.Text = "Gold: " + player.gold;

            foundlabel = (Label)main.Controls.Find("lbl_score", true).First();
            if (foundlabel != null)
                foundlabel.Text = "Score: " + player.score;
        }
    }
}
