using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.InterviewQuestions
{
    public class Sample
    {
        public static int x = 100;
        public static int y = 150;
    }
    public class Newspaper : Sample
    {
         public new static int x = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine(Sample.x + " " + Sample.y + "  " + x);
            Console.Read();
        }

    }
}
