using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatCrafter
{
    class Material
    {
        private string _name;
        private double _valueBuy;
        private double _valueSell;
        private int _idUniq;
        private int _nbInv;
        private int _nbTotalBuy;

        public Material(string name, int idUniq, double valueBuy, double valueSell)
        {
            _name = name;
            _idUniq = idUniq;
            _valueBuy = valueBuy;
            _valueSell = valueSell;
            _nbInv = 0;
            _nbTotalBuy = 0;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
