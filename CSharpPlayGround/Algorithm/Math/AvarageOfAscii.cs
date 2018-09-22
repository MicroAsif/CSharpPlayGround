using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayGround.Algorithm.Math
{
    class AvarageOfAscii
    {
        public static int Avarage(string message)
        {
            int sum = 0;
            for (int i = 0; i < message.Length; i++)
            {
                sum += (int)message[i];
            }
            return sum / message.Length;
        }
    }
}
