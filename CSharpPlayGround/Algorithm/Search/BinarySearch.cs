using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Search
{
    class BinarySearch
    {
        public int Search(int[] arrs, int key)
        {
          
            int left = 0;
            int right = arrs.Length-1;
            int i = 1;
            while(left < right)
            {
                Console.WriteLine($"count : {i}");
                int mid = (left + right) / 2;
                if (arrs[mid] == key)
                    return arrs[mid];
                if (key > mid)
                    left = mid+1;
                if (key < mid)
                    right = mid - 1;
                
                i++;
            }
            return -1;
        }
    }
}
