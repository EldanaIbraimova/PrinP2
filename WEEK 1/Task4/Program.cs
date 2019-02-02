using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nn = Console.ReadLine();
            int n = int.Parse(nn);
            for(int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    if (j <= i)
                    {
                        Console.Write("[*]");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
