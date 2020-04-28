using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public static class RapportDataFormatter
    {
        public static string Stringifyer(Item item)
        {
            return item.Name + ", " + item.SellIn + ", " + item.Quality;
        }

    }
}
