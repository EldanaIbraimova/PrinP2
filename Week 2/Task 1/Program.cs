using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pol = true;
            string s = Console.ReadLine();
            for(int i = 0; i < (s.Length/2) - 1; ++i)
            {
                int n = s.Length;
                

                if (s[i] != s[n-i-1])
                {
                    pol = false;
                }
            }
            
            if (pol == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
