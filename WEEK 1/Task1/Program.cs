using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nn = Console.ReadLine(); // ввод кол-ва чисел в типе стринг
            string nnums = Console.ReadLine();//ввод чисел
            int n = int.Parse(nn); //перевод из типа стринг в инт
            string[] nums = nnums.Split();
            string answer = ""; //простые числа
            
            int prime = 0; //кол-во простых чисел
            for (int i = 0; i < nums.Length; ++i) 
            {
                int x = int.Parse(nums[i]);
                int cnt = 0;//счетчик делителей 
                for (int j = 2; j < Math.Sqrt(x); ++j)
                {
                    if (x % j == 0)
                    {
                        ++cnt;
                    }

                }

                if (cnt == 0)
                {
                    prime++;
                    answer = answer + nums[i] + " ";
                }
            }
            Console.WriteLine(prime);
            Console.WriteLine(answer);

           
            
        }
    }
}
