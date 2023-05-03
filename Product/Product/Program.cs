using System;
namespace Product
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product p=new Product();
            Console.WriteLine("Enter Product id:");
            p.proid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product name:");
            p.proname=Console.ReadLine();
            
            Console.WriteLine("Product Id:"+p.proid);
            Console.WriteLine("Product Name:"+p.proname);
            
        }
    }
}

