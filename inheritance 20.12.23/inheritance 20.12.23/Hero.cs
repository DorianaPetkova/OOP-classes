using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_20._12._23
{
    internal class Hero 
    {
        private string username;
        private int level;

        public Hero(string username, int level)
        {
            this.username = username;
            this.level = level;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.username} Level:{ this.level}";
        }
    }
}
