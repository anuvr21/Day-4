using System;
namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            decimal salary;
            Employee e = new Employee();
            Console.WriteLine("Enter employee id:");
            e.id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            e.name=Console.ReadLine();
            Console.WriteLine("Enter the salary:");
            e.salary=decimal.Parse(Console.ReadLine());


            Console.WriteLine("Employee id:" + e.id);
            Console.WriteLine("Employee name:" + e.name);
            Console.WriteLine("Employee salary:" + e.salary);
        }
    }
}
