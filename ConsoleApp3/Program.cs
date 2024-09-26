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
            public string SayName(string s)
            {
                if (s != string.Empty)
                {

                    Console.WriteLine("logged name: " + s);
                } ;
                return s;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
