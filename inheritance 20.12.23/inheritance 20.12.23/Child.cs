using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_20._12._23
{
    internal class Child : Person
    {
        public Person Mother{ get; set; }
        public Person Father{ get; set; }
        public Child(string name, int age, Person mother, Person father):base(name, age)
        {
            this.Mother = mother;
            this.Father = father;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format(base.ToString() + "Mother: {0}, Father: {1}", Mother, Father));
            return sb.ToString();
        }

    }
}
