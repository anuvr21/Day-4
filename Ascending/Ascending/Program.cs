using System;
namespace Ascending
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            int n=str.Length;
            char[] ca=str.ToCharArray();
            for(int i=1;i<n;i++)
            {
                for(int j=1;j<n-i;j++)
                {
                    if (ca[j] > ca[j+1])
                    {
                        char ch = ca[j];
                        ca[j] = ca[j+1];
                        ca[j+1] = ch;
                    }
                }
            }
            foreach (char ch in ca)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
