using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            Console.Write("Even Numebrs: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    if (i == n)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
