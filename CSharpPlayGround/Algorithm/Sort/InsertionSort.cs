using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Sort
{
    public class InsertionSort
    {
        public static void Sort(params int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int hole = i;

                while(hole > 0 && arr[hole - 1] > value)
                {
                    arr[hole] = arr[hole - 1];
                    hole--;
                }
                arr[hole] = value;
            }
        }
    }
}
