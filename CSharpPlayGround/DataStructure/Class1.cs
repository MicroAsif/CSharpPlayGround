using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.DataStructure
{
     class Class1
    {
        protected string Name { get; set; }
        private string email { get; set; }
        protected internal int vaule { get; set; }
        public string MyVaule { get; set; }
        
    }

    class Class2 : Class1
    {
      
    }
}
