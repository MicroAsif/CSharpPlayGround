using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.InterviewQuestions
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base");
        }
        public void F1() => Console.WriteLine("Base F1");
        public virtual void F2() => Console.WriteLine("Base F2");
        public virtual void F3() => Console.WriteLine("Base F3");
    }
    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived");
        }
        public new void F1() => Console.WriteLine("Derived F1");
        public override void F2() => Console.WriteLine("Derived F2");
        public new void F3() => Console.WriteLine("Derived F3");
    }
}
