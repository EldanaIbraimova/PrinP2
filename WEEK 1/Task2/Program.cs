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
        public Student(string n, int i)
        {
            name = "S1";
            id = 101;
       
        }
        public void PrintInfo()
        {
            Console.Write(name + " " + id + " ");
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student("",0);
            int yy = 1;
           
            s.PrintInfo();
            Console.WriteLine(yy + 1);

        }
    }
}
