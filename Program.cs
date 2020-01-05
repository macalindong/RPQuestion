using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
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
            System.Console.ReadLine();
        }
    }
}
