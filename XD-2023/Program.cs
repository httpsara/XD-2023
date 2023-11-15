using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120);
            Car Volvo = new Car("XC-90");
            //Car Ford = new Car();
            //Car Opel = new Car();
            //Ford.name = "Mustang";
            //Ford.year = 2021;
            //Ford.color = "white";
            //Ford.maxspeed = 100;

            //Opel.name = "Astra";
            //Opel.color = "Blue";
            //Opel.year = 2020;
            //Opel.maxspeed = 120;

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrottle();

            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();

        }
    }
}
