using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_20._12._23
{
    internal class Stack : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public Stack<string> AddRange(Stack<string> range) 
        { 
            while (range.Count>0)
                this.Push(range.Pop());
            return this;
        }
    }
}
