using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.InterviewQuestions
{
    class A
    {
        public int i;
        public void Display() => Console.WriteLine(i); 
    }
    class B : A
    {
        public int j;
        public void Display() => Console.WriteLine(j);
    }
}
