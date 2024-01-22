using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercise
{
    internal class Student
    {
        private string name= default!;
        private int age;
        private string major= default!;
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {

                age = value;

            }
        }
        public Student()
        {
            Name = "";
            Major = "";
            Age = 19;  
        }
        public Student(string name, string major, int age)
        {
            Name = name;
            Major = major;
            Age = age;
        }
        
        public void Who()
        {
            Console.WriteLine($"Name: {Name}, \nMajor: {Major}, \nAge:{Age}");
        }
        public void Increase(int age1)
        {
            Age = age + age1;
            Console.WriteLine($"Increased:{Age}");
        }
    }
}
