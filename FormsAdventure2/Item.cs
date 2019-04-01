using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAdventure2
{
    class Item
    {
        public string name;
        public string description;
        public int uses;
        public int score;

        public Item(string n, string d, int u, int s)
        {
            name = n;
            description = d;
            uses = u;
            score = s;
        }
    }
}
