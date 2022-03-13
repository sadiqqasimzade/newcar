using System;
using System.Collections.Generic;
using System.Text;

namespace car.Model
{
    internal class Vehicle
    {
        public string color;
        public int year;

        public Vehicle(int year)
        {
            this.year = year;
        }
        public Vehicle(int year,string color):this(year)
        {
            this.color = color;
        }
    }
}
