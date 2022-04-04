using Practice.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public class Plane : Vehicle, IWheel, IEngine
    {
        private int _wingLength;
        private double _driveTime;
        private double _drivePath;
        private double _wheelThickness;
        private double _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        public int WingLength { get { return _wingLength; } set { if (value > 0 || value <= 120) _wingLength = value; } }
        public override double DriveTime { get { return _driveTime; } set { if (value > 0) _driveTime = value; } }
        public override double DrivePath { get { return _drivePath; } set { if (value > 0) _drivePath = value; } }
        public double WheelThickness { get { return _wheelThickness; } set { if (value > 0) _wheelThickness = value; } }
        public double HorsePower { get { return _horsePower; } set { if (value > 0) _horsePower = value; } }
        public double TankSize { get { return _tankSize; } set { if (value > 0 || value <= 110.000) _tankSize = value; } }
        public double CurrentOil { get { return _currentOil; } set { if (value > 0 || value <= TankSize) _currentOil = value; } }
        public string FuelType { get { return _fuelType; } set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _fuelType = value; } }

        public Plane(int wingLength, double wheelThickness, double horsePower, double tankSize, double currentOil, string fuelType, double driveTime, double drivePath)
        {
            WingLength = wingLength;
            WheelThickness = wheelThickness;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }

        public double LeftOilAmount()
        {
            return TankSize - CurrentOil;
        }
    }
}
