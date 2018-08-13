using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer objContainer=new UnityContainer();
            objContainer.RegisterType<Customer>();
            objContainer.RegisterType<IDal, OracleDal>();
            objContainer.RegisterType<IDal,SQLServerDal>();
     
            Customer obj = objContainer.Resolve<Customer>();

            //Customer obj = new Customer(new SQLServerDal());
            obj.CustomerName = "test1";
             obj.Add();
        }


    }
    public class Customer
    {
        // private SQLServerDal Odal = new SQLServerDal();
        //private OracleDal OdalOra = new OracleDal();
        private IDal Odal;
        public string CustomerName { get; set; }

        public Customer(IDal iobj)
        {
            Odal = iobj;
        }

        public void Add()
        {
            //if (true)
            //{
            //    Odal=new SQLServerDal();
                
            //}
            //else
            //{
            //    Odal=new OracleDal();
                
            //}
            Odal.Add();
        }
    }

    public interface IDal
    {
        void Add();
    }

    public class SQLServerDal:IDal
    {
        public void Add()
        {
            Console.WriteLine("abc");
        }
    }
    public class OracleDal:IDal
    {
        public void Add()
        {
            Console.WriteLine("def");
        }
    }
}
