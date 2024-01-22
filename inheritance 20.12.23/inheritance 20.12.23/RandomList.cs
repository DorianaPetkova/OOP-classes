using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_20._12._23
{
    internal class RandomList : List<string>
    {
        private Random random;
        public RandomList()
        {
            random = new Random();
        }
        public string RandomString()
        {
            int index= random.Next(0, this.Count);
            string element=this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
