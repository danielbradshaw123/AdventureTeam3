using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAdventure2
{
    class Character
    {
        public string name;
        public int luck;
        public int gold;
        public int score;

        List<Item> items = new List<Item>();

        public Character()
        {
            name = "Joe Blogs";
            luck = 5;
            gold = 10;
            score = 0;
        }
    }
}
