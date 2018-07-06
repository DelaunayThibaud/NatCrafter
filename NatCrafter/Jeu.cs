using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatCrafter
{
    class Jeu
    {
        private int _minutes;
        private int _seconde;

        public Jeu(int modeDeJeu)
        {
            switch (modeDeJeu)
            {
                case 0:
                    break;
                case 1:
                    _seconde = 0;
                    _minutes = 10;
                    break;
                case 2:
                    _seconde = 0;
                    _minutes = 5;
                    break;
            }
        }

        public void majTimer()
        {
            if (_seconde == 0)
            {
                _seconde = 59;
                _minutes -= 1;
            }
            else
            {
                _seconde -= 1;
            }
        }

        public string TimerString()
        {
            string temp;
            if(_seconde < 10)
            {
                temp = _minutes + ":0" + _seconde;
            }
            else
            {
                temp = _minutes + ":" + _seconde;
            }
            return temp;
        }
    }
}
