using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method override and method hidding 
            Base b = new Derived();
            b.F1();
            b.F2();
            b.F3();


            Z z = new Z();
            z.Set(10, 20);
            Console.WriteLine(z.x + " " + z.y);

            //Can't access const with an instance
            //Console.WriteLine(z.C1 + " " + z.C2);


       
            // Params 

            Display(1,2,3);
            int[] a = { 1, 2, 3, 4, 5 };
            Display(a);


            // another example 

            B b1 = new B();
            b1.i = 1;
            b1.j = 2;

            b1.Display();

            Console.Read();
        }


        public static void Display(params int[] b)
        {
            foreach (var item in b)
            {
                Console.WriteLine("Array is having : {0}", item);
            }

        }
    }
}
