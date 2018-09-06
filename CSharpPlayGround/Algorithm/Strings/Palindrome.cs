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
            int min = 0;
            int max = message.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true; 
                }
                char a = message[min];
                char b = message[max];
                if (char.ToLower(a) != char.ToLower(b))
                    return false;

                min++;
                max--;
            }

        }
    }
}
