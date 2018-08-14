using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Strings
{
    class Palindrome
    {
        public bool Reverse(string message)
        {
            string newMsg = message;
            newMsg.Reverse();

            char[] chars = newMsg.ToCharArray();
            String s = new String(chars);

            if (s.Equals(newMsg))
                return true;
            return false;

        }
    }
}
