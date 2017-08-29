using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义泛型1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] str = {"袁文伟", "赵宁", "清云"};
            //MyClass<string> mc = new MyClass<string>(str);
            //for (int i = 0; i < mc.Count; i++)
            //{
            //    Console.WriteLine(mc[i]);
            //}
            //double[] scores = {96, 78, 25, 63};
            //MyClass<double> mc =new MyClass<double>(scores);
            //for (int i = 0; i < mc.Count; i++)
            //{
            //    Console.WriteLine(mc[i]);
            //}
            //American<string> us=new American<string>();
            //us.Fly("用枪对射！~");
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "dzyyy", Age = 22, Gender = true });
            list.Add(new Person() { Name = "lmg", Age = 23, Gender = true });
            list.Add(new Person() { Name = "cmrd", Age = 21, Gender = false });

            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Name);
            }



            Console.ReadKey();
        }
    }
    public class Person : IComparable<Person>, IComparer<Person>
    {
        public Person()
        {

        }

        public Person(string name, int age, bool gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public bool Gender
        {
            get;
            set;
        }

        public int CompareTo(Person other)
        {
            return other.Name.Length - this.Name.Length;
        }

        public int Compare(Person x, Person y)
        {
            return x.Name.Length - y.Name.Length == 0 ? y.Age - x.Age : x.Name.Length - y.Name.Length;
        }
    }
    /// <summary>
    /// 泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyClass<T>
    {
        private T[] _data;

        public MyClass(T[] userData)
        {
            _data = userData;
        }

        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }

        }

        public int Count {
            get { return _data.Length; }
        }
    }
    //泛型方法
  
    //泛型接口
    public interface IFace<T>
    {
        void Fly(T msg);
    }

    public class Chinese:IFace<string>
    {
        public void Fly(string msg)
        {
            Console.WriteLine("中国人飞檐走壁"+msg);
        }
    }

    public class American<T> : IFace<T>
    {
        public void Fly(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
