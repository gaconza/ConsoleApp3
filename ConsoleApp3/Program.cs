using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class Human
        {
            public string SayName(string s, int a)
            {
                if (a<0)
                {
                    a = 0;
                    Console.WriteLine("logged name and age: "+ s+" "+a);
                }
                return s+a;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
