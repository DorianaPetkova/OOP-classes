// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
using inheritance_20._12._23;

Dog dog = new Dog();
dog.Bark();
dog.Eat();

Puppy puppy = new Puppy();
puppy.Bark();
puppy.Weep();

Cat cat = new Cat();
cat.Eat();
cat.Meow();

RandomList list = new RandomList();
list.Add("Search");
list.Add("And");
list.Add("Rescue");

Console.WriteLine(list.Count);
Console.WriteLine(list.RandomString());

Stack stack = new Stack();
Stack<string> fullstack = new Stack<string>();
fullstack.Push("b");
fullstack.Push("c");

stack.AddRange(fullstack);
Console.WriteLine(stack.IsEmpty());

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string mname = Console.ReadLine();
int mage = int.Parse(Console.ReadLine());
string fname = Console.ReadLine();
int fage = int.Parse(Console.ReadLine());
Person mother = new Person(mname, mage);
Person father = new Person(fname, fage);



Child child = new Child(name, age, mother, father);
Console.WriteLine(child);

string username = Console.ReadLine();
int level = int.Parse(Console.ReadLine());
Hero hero = new Hero(username, level);


