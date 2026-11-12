using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_14
{
    internal class Player
    {
        public Player()
        {
        }

        public Player(string name, int point, bool activeStatus)
        {
            Name = name;
            Point = point;
            ActiveStatus = activeStatus;
        }

        public string Name { get; set; }

        public int Point { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
