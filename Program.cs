//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                if ((x % 3 == 0) && !(x % 5 == 0))
                {
                    System.Console.WriteLine("right");
                }
                else if ((x % 5 == 0) && !(x % 3 == 0))
                {
                    System.Console.WriteLine("point");
                }
                else if ((x % 5 == 0) && (x % 3 == 0))
                {
                    System.Console.WriteLine("rightpoint");
                }
                else
                {
                    System.Console.WriteLine(x);
                }
            }
        }
    }
}
