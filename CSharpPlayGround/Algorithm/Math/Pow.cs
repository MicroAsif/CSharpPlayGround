using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Math
{
    public static class Pow
    {
        public static int Test(int a, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return a;

            int result = 1; 
            for(int i=1;i<=n; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int Recursion(int a, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return a;

            if (n % 2 == 0)
            {
                int p = Recursion(a, n / 2);
                return p * p;
            }
            return a * Recursion(a, n - 1);
        }
    }
}
