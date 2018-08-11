
using CSharpPlayGround.Algorithm.Math;
using CSharpPlayGround.Algorithm.Search;
using CSharpPlayGround.Algorithm.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            //LCM lcm = new LCM();
            //var result = lcm.BeetweenTwoNumber(8, 5);

            int[] arrs = { 10, 1, 30, 52, 30, 40, 4, 5 };
            //LeanerSearch l = new LeanerSearch();
            //var result = l.Search(arrs, 5);

            //int[] arrs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //BinarySearch bs = new BinarySearch();
            //var result = bs.Search(arrs, 2);


            Sorting s = new Sorting();
            s.SelectionSort(arrs);

            for (int i = 0; i < arrs.Length; i++)
            {
                Console.WriteLine(arrs[i]);
            }
            Console.Read();
        }
    }
}
