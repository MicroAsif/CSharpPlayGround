using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Math
{
    public class Number
    {
        public static List<int> DecimalToBinary(int n)
        {
            int rem;
            List<int> container = new List<int>();
            while(n > 0)
            {
                rem = n % 2;
                container.Add(rem);
                n = n / 2; 
            }
            container.Reverse();
            return container;
        }
    }
}
