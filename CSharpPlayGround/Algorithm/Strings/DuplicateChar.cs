using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Strings
{
    public class DuplicateChar
    {
        public static Dictionary<char, int> Duplication(string data)
        {
            var duplicate = new Dictionary<Char, int>();
            for (int i = 0; i < data.Length; i++)
            {
                char c = data[i];
                if (duplicate.ContainsKey(c))
                {
                    duplicate[c]++;
                }
                   else
                {
                    duplicate.Add(c, 1);
                } 
               
            }
            return duplicate;
        }
    }
}
