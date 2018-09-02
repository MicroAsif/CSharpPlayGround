using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Math
{
    class Factorial
    {
        public int Test(int n)
        {
            if (n == 0)
                return 1;
            return n * Test(n - 1);
        }
    }
}
