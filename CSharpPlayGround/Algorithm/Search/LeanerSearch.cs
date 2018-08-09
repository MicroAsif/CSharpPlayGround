using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Search
{
    class LeanerSearch
    {
        public long Search(int[] arrs, int key)
        {
            foreach (var item in arrs)
            {
                if (item == key)
                    return item;
            }
            return 0;
        }
    }
}
