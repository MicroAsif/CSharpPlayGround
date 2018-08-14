using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Strings
{
    class FirstDuplicate
    {
        public char Run(char[] chars)
        {
            List<char> charactars = new List<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                char index = chars[i];

                if (charactars.Contains(index))
                  return index;
                charactars.Add(index);
            }
            return '0';
        }
    }
}
