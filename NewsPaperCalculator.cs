using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    internal static class NewsPaperCalculator
    {
        internal static int CalcNumberOfCharts(NewsPaper np)
        {
            return np.ToString().Length;
        }
    }
}
