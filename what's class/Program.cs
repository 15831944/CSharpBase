using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace what_s_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.Amount);
            Student t = new Student(1,"江川");
            Console.WriteLine(Student.Amount);
            Student t2 = new Student(2, "刘海峰");
            Console.WriteLine(Student.Amount);
            t.Report();
            t2.Report();
        }
    }

    public class Student
    {
        public static int Amount { get; set; }
         static Student()
         {
             Amount = 100;
         }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Amount++;
        }

        ~Student()
        {
            Console.WriteLine("拜拜！~");
        }
         int Id { get; set; }
         string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"我是{Id}号学生，我的名字是{Name};");
        }

    }
}
