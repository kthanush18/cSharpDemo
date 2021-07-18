using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo.library
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string s1 = "abcdef";
            string s2 = "xyz";

            Console.WriteLine(s1==s2);
            Console.WriteLine(s1.CompareTo(s2));
        }
    }
}
