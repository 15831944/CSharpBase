using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            string numberA = Console.ReadLine();
            Console.WriteLine("请输入第二个数字");
            string numberB = Console.ReadLine();
            Console.WriteLine("请输入运算符");
            string operate = Console.ReadLine();
            var oper = OperationFactory.CreateOperate(operate);
            oper.NumnerA = Convert.ToDouble(numberA);
            oper.NumberB = Convert.ToDouble(numberB);
            string result = oper.GetResult().ToString();
            Console.WriteLine(result);
        }
    }

    public class Operation
    {
        public double NumnerA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            const double result = 0;
            return result;
        }

    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumnerA + NumberB;
            return result;
        }
    }
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumnerA - NumberB;
            return result;
        }
    }
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumnerA * NumberB;
            return result;
        }
    }
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;

            if (NumberB == 0)
                throw new Exception("除数不能为0.");
            result = NumnerA / NumberB;
            return result;

        }
    }

    public static class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }

    }
}
