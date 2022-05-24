using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void StopCar();

namespace pz_9
{

    internal class Car
    {
        public int skorost;

        public event StopCar MyEvent;

        public void speed()
        {
            for (int i = 0; i < 161; i++)
            {
                skorost = i;
                if (skorost == 81)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                else if (skorost == 121)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                Console.WriteLine($"{skorost} км/ч");

            }

        }


    }

    class Program
    {
        static void carname()
        { Console.WriteLine("Toyota"); }

        public class Patrolman
        {

            public void Danger()
            {
                Console.WriteLine("Снизьте скорость.");
            }
            public void OverDanger()
            {
                Console.WriteLine("Это было последнее предупреждение.");
            }
        }
        static void Main(string[] args)
        {
            Car speedometer = new Car();
            Patrolman signal = new Patrolman();
            speedometer.MyEvent += signal.Danger;
            speedometer.speed();
            speedometer.MyEvent += signal.OverDanger;

        }
    }
}