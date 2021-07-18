using System;
using System.IO;

namespace cSharpDemo.library
{
    public class SearchNames
    {
        
        static void Main(string[] args)
        {
            using var sr = new StreamReader(@"c:\classroom\jun21\names.txt");
            Console.Write("Enter search string :");
            var pattern = Console.ReadLine();
            pattern = pattern.ToUpper();

            while (true)
            {
                var name = sr.ReadLine();
                if (name == null)  // EOF 
                    break;

                // Check whether name contains pattern without case sensitivity 
                if (name.ToUpper().Contains(pattern))
                    Console.WriteLine(name);
            }

        }
    }
}    

