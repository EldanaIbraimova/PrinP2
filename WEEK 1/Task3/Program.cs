using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void DoubleNums(string[] nnums)
        {
            for(int i = 0; i < nnums.Length; ++i)
            {
                Console.Write(nnums[i] + " " + nnums[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();//считываем кол-во чисел
            string nums = Console.ReadLine();//считываем слова
            string[] nnums = nums.Split();//создаем массив из строк которые содержат в себе числа
            DoubleNums(nnums);//выводим двойные числа
            
        }
    }
}
