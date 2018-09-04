using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Math
{
    class Fibonacci
    {
        public int FiboRecursion(int n)
        {
            if (n <= 1)
                return n;

            return FiboRecursion(n - 1) + FiboRecursion(n - 2);
        }

        public int Fibo(int n)
        {
            if (n <= 1)
                return n;
            int f1 = 0;
            int f2 = 1;
            int f = 0 ;
           
            for(int i=2; i <= n; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
            }
            return f;

        }
    }
}
