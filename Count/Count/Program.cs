//Count words in a string
using System;
using System.Runtime.Remoting.Channels;
using System.Xml.Schema;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string:");
            str= Console.ReadLine();

            int l = 0;
            int w = 1;

            while(l< str.Length)
            {
                if (str[l] == ' ' || str[l]=='\n'|| str[l]=='\t') 
                {
                    w++;
                }
                l++;
            }
            Console.WriteLine("Total number of words in {1} is {0}", w,str);
        }
    }
}
