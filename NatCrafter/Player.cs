using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatCrafter
{
    class Player
    {
        private int _level;
        private float _balance;

        public int Level
        {
            get { return _level; }
        }
        public float Balance
        {
            get { return _balance; }
        }

        public Player(float balance)
        {
            _level = 0;
            _balance = balance;
        }
    }
}
