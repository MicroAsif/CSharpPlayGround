using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Sets
{
    class CartesianProduct
    {
        public int[,] Test(int[] setA, int[] setB)
        {
            int[,] product = new int[setA.Length, setB.Length];
            if (setA.Length != setB.Length)
                return null;
            for (int i = 0; i < setA.Length; i++)
            {
                for (int j = 0; j < setB.Length; j++)
                {
                    product[i,j] = setA[i]*setB[j];
                }
                
            }
            return product;
        }
    }
}
