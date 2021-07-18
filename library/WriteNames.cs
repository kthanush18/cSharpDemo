using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo.library
{
    public class WriteNames
    {
        public static void Main(string[] args)
        {
            var sw = new StreamWriter(@"d:\professional\swathi\names.txt");
           
                while (true)
                {
                    Console.Write("Enter name [end to stop] :");
                    var name = Console.ReadLine();
                    if (name == "end")
                        break;

                    sw.WriteLine(name);
                }
            }
        }
    }

