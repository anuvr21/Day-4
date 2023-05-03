using System;
namespace Constructor
{
    class Employee
    {
        public int id;
        public string name;
        public decimal salary;
        public Employee() { }

        public Employee(int id,string name,decimal salary) 
        {
            this.id = id;
            this.name = name;
            this.salary=salary;
        }
    }
}
