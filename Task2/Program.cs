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
        public string id;
        public string year;


        public Student(string name, string id, string year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        
        public void Info()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }


        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student ggg = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            ggg.Info();
           
          
        }
    }
}
