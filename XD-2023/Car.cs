using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_2023
{
    public class Car
    {
        public string color;
        public string name;
        public int maxspeed;
        public int year;

        public Car(string nameName, string colorName, int yearName, int maxSpeedName)
        { name = nameName;
          color = colorName;
          year = yearName;
          maxspeed = maxSpeedName;
        }
        public Car(string nameName)
        { name = nameName; }
        public void fullThrottle()
        {
            Console.WriteLine(name + "is going at the speed of" + maxspeed);
        }

    }
}

