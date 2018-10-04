using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm
{
    class ArrayProblem
    {

        public static (int element, int count) MaximumFrequency(int[] array){
            int count = 0, element = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int tempElement = array[i];
                int tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == tempElement)
                        tempCount++;
                    if (tempCount > count)
                    {
                        count = tempCount;
                        element = tempElement;
                    }
                }
            }
            return (element, count);
        }

        public static  int GetSingleMissingNo(int[] a)
        {
            int total = (a.Length + 1) * (a.Length + 2) / 2;

            for (int i = 0; i < a.Length; i++)
                total -= a[i];

            return total;
        }

        public static List<int> MissingNumbers (int[] a, int count)
        {
            var sequence = new List<int>(a);
            return Enumerable.Range(1, count).Except(a).ToList();

        }

      
    }
}
