using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Sort
{
    public class BubbleSort
    {
        public static void Sort(params int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                for (int i = 0; i < arr.Length -k- 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
        }
    }
}
