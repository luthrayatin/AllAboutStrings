using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWorks
{
    public class StringReduce
    {
        public string Go(string str)
        {
            StringBuilder sb = null;
            var stack = new Stack<char>();
            foreach (var t in str)
            {
                if (stack.Count > 0 && stack.Peek() == t)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(t);
                }
            }
            sb = new StringBuilder();
            if (stack.Count > 0)
            {
                while (stack.Count > 0)
                {
                    sb.Insert(0, stack.Pop());
                }
            }
            else
            {
                return "Empty String";
            }
            return sb.ToString();
        }
    }
}
