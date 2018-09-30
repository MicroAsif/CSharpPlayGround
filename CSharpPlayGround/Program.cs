
using CSharpPlayGround.Algorithm.Math;
using CSharpPlayGround.Algorithm.Search;
using CSharpPlayGround.Algorithm.Sets;
using CSharpPlayGround.Algorithm.Sort;
using CSharpPlayGround.Algorithm.Strings;
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


            //Sorting s = new Sorting();
            //s.SelectionSort(arrs);

            //for (int i = 0; i < arrs.Length; i++)
            //{
            //    Console.WriteLine(arrs[i]);
            //}

            Palindrome palindrome = new Palindrome();
            Console.WriteLine(palindrome.Reverse("repaper"));

            //char[] chars = { 'a', 's', 'i', 'f', 'u', 'r', 'r', 'a', 'h' };

            //FirstDuplicate firstDuplicate = new FirstDuplicate();
            //Console.WriteLine(firstDuplicate.Run(chars));


            //Fibonacci f = new Fibonacci();
            //Console.WriteLine(f.Fibo(40));



            //int [] array1 = { 1, 2, 3 };
            //int[] array2 = { 10, 11, 12 };

            //CartesianProduct cp = new CartesianProduct();
            //int[,] arrays = cp.Test(array1, array2);
            //foreach (var item in arrays)
            //{
            //    Console.WriteLine(item);
            //}


            Console.WriteLine(Pow.Recursion(2, 8));

            Console.WriteLine(AvarageOfAscii.Avarage("GeeksforGeeks"));


            var data = Number.DecimalToBinary(11);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
