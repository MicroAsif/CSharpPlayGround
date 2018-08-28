using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Strings
{
    class HammingDistance
    {
        public int Test(string a, string b)
        {
            int distance = 0;
            if (a.Length != b.Length)
                Console.WriteLine("string length must be same");

            for(int i = 0; i< a[i]; i++)
            {
                if (a[i] != b[i])
                    distance++;
            }

            return distance;
        }
    }
}
