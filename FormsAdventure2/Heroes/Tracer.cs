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

namespace FormsAdventure2.Heroes
{
    class Tracer
    {
        // this class is used to load characters into the FormBattleArena class, will complete when more locations are available :)

        // move names
        public static string Move1 = "Pulse Pistols";
        public static string Move2 = "Melee";
        public static string Move3 = "Blink";
        public static string Move4 = "Pulse Bomb";

        // move sounds
        // pulse pistols
        private void playMove1()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.pulse);
            sound.Play();

            Thread.Sleep(2000);
        }

        // melee
        private void playMove2()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.tracer_melee);
            sound.Play();

            Thread.Sleep(2000);
        }

        // blink
        private void playMove3()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.tracer_blink);
            sound.Play();

            Thread.Sleep(2000);
        }

        // pulse bomb
        private void playMove4()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.tracer_bomb);
            sound.Play();

            Thread.Sleep(3000);
        }

    }
}
