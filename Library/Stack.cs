using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Stack
    {
        private int[] s;
        private int lastIndex = 0;

        public Stack(int N)
        {
            s = new int[N];
        }

        public void push(int x)
        {
            if (lastIndex == s.Length)
            {
                Array.Resize(ref s, s.Length * 2);
            }

            s[lastIndex] = x;
            lastIndex++;
        }

        public int pop()
        {
            lastIndex--;
            int result = s[lastIndex];

            return result;
        }
    }
}
