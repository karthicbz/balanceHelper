using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeHelper
{
    class Changer
    {
        public int cost;
        public int amount;
        public int money = 0;

        public int currencybalance()
        {
            return amount - cost;
        }
    }
}
