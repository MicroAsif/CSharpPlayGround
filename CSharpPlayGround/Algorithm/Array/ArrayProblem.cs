﻿using System;
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


        public static (int first, int second) FindTwoTop(int[] arr)
        {
            int top1 = 0, top2 = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (top1 < arr[i])
                {
                    top2 = top1;
                    top1 = arr[i];
                }
                else if (top2 < arr[i])
                {
                    top2 = arr[i];
                }
            }
            return (top1, top2);
        }


        //1, 2, 3, 4 , 5, 0 , 6, 0
        public static int[] PushAllZeroToTheEnd(params int[] arr)
        {
            int count = 0;
            int[] newArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newArray[count++] = arr[i];
                }
            }
            return newArray;
        }
      
    }
}