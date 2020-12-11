using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    public class NamePopularity
    {
        public int count { get; set; }
        public int rank { get; set; }

        public NamePopularity(int _count, int _rank)
        {
            count = _count;
            rank = _rank;
        }
    }


}
