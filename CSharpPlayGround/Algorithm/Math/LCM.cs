using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Math
{
    public class LCM
    {
        public long BeetweenTwoNumber(int n1, int n2)
        {
            int max, i, lcm = 1;
            max = (n1 > n2) ? n1 : n2;
            i = max;

            while (true)
            {
                if ( i%n1 == 0 && i%n2 == 0)
                {
                    lcm = i;
                    break;
                }
                i++;
            }
            return lcm;
        }

        public long BeetweenArrays(int[] arr)
        {
            return 0;
        }
       
    }
}
