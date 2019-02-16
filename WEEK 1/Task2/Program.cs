using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public int id;
        public int year;

        public Student(string n, int i)
        {
            name = n;
            id = i;
            year = 1;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name + " " + id + " " + year);

        }
        public void IncrementYearStudy()
        {
            year++;

        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student("S1",101);
          
           
            s.PrintInfo();
            s.IncrementYearStudy();
            s.PrintInfo();
            

        }
    }
}
