using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!~");
            Vehicle v = new Car();
            v.Run();
            v = new Truck();
            v.Run();
            v = new RaceCar();
            v.Run();
        }
    }

    //abstract class VehicleBase
    //{
    //    abstract public void Stop();
    //    abstract public void Fill();
    //    abstract public void Run();

    //}
    interface IVehicle
    {
         void Stop();
        void Fill();
        void Run();
    }




    abstract class Vehicle : IVehicle
    {
        public void Stop()
        {
            Console.WriteLine("车停了");
        }

        public void Fill()
        {

            Console.WriteLine("Pay and fill...");
        }

        //public virtual void Run()
        //{
        //    Console.WriteLine("Vehicle is running");
        //}
        abstract public void Run();
    }

    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("汽车跑ing");
        }



    }
    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("卡车跑ing");
        }

    }

    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("赛车跑ing");
        }
    }
}
