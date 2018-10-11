using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Sort
{
    class MergeSort
    {
        public static void Sort(int[] arr)
        {
            int mid;
            if (arr.Length < 2)
                return;

            mid = arr.Length / 2;

            int[] l = new int[mid];
            int[] r = new int[arr.Length-mid];
            for (int i = 0; i < mid; i++) { l[i] = arr[i];}
            for (int i = mid; i < arr.Length; i++) {r[i-mid] = arr[i];}
            Sort(l);
            Sort(r);
            Merge(l, r, arr);
        }

      

        public static void Merge(int[] l, int[] r, int[] a)
        {
            Print("Left array : ", l);
            Print("Right array : ", r);
            int i = 0, j = 0, k = 0;
            while(i < l.Length && j < r.Length)
            {
                if (l[i] <= r[j])
                    a[k++] = l[i++]; 
                else
                    a[k++] = r[j++]; 
            }
            while (i < l.Length) {
                a[k++] = l[i++]; 
            }
            while(j < r.Length)
            {
                a[k++] = r[j++]; 
            }
            Print("Merged array : ", a);
        }

        public static void Print(string m, int[] a)
        {
            Console.Write($"{m} \t");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}  ");
            }
            Console.Write("\n");
            
        }


    }
}
