using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public abstract class Vehicle
    {
        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }


        public abstract double AverageSpeed();

        public abstract void ShowInfo();
    }
}
