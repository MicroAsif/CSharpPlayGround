using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Sort
{
    class Sorting
    {
        public void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[index])
                        index = j;
                }
                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }
    }
}
