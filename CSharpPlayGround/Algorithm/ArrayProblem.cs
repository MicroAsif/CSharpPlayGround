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
    }
}
