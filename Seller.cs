using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    class Seller
    {
        private int _moneyEarned = 0;
        public void SellNewsPaper(NewsPaper np)
        {
            _moneyEarned = _moneyEarned + (int)np.GetPrice();
        }

        public override string ToString()
        {
            return $"money earned: {_moneyEarned}";
        }
    }
}
