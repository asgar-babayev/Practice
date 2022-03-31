using Practice.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public class Plane:Vehicle,IWheel,IEngine
    {
        public int WingLength { get; set; }
        public override double DriveTime { get; set; }
        public override double DrivePath { get; set; }
        public double WheelThickness { get; set; }
        public double HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }

        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($@"
Wheel Thickness - {WheelThickness}
Horse Power - {HorsePower}
Tank Size - {TankSize}
Current Oil - {CurrentOil}
Fuel Type - {FuelType}
Drive Time - {DriveTime}
Drive Path - {DrivePath}
");
        }
    }
}
