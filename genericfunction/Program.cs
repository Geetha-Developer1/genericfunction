using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericfunction
{
    class student
    {
        internal void Display<i, n, a>(i id, n name, a age)
        {
            Console.WriteLine($"ID {id},name {name},age {age}");
        }
        internal void marks<m1,m2,m3>(m1 sub1,m2 sub2,m3 sub3)
        {
            Console.WriteLine("Subject1 marks: " + sub1);
            Console.WriteLine("Subject2 marks: " + sub2);
            Console.WriteLine("Subject3 marks: " + sub3);

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student id :");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("ENter student name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Age :");
            int age= int.Parse(Console.ReadLine());
            student s=new student();
            s.Display(id, name, age);
            s.marks(90, 80, 70);


            

        }
    }
}
