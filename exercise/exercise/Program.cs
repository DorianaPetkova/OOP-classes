using System.Security.Principal;
namespace exercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Student student=new Student();
            string name = Console.ReadLine();
            string major = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Student student1 = new Student(name, major, age);
            student1.Who();
            student1.Increase(3);
            Bank account = new Bank(123456789, 1000);
            account.Display();
            account.Deposit(500.50);
            account.Display();
            account.Withdraw(200.75);
            account.Display();

        }
    }
}
