using Practice.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public class Car : Vehicle, ITransmission, IWheel, IEngine
    {
        private int _doorCount;
        private string _vinCode;
        private string _transmissionKind;
        private double _wheelThickness;
        private double _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        private double _driveTime;
        private double _drivePath;
        public int DoorCount { get { return _doorCount; } set { if (value > 0 || value <= 10) _doorCount = value; } }
        public string VinCode { get { return _vinCode; } set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _vinCode = value; } }
        public string TransmissionKind { get { return _transmissionKind; } set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _transmissionKind = value; } }
        public double WheelThickness { get { return _wheelThickness; } set { if (value > 0) _wheelThickness = value; } }
        public double HorsePower { get { return _horsePower; } set { if (value > 0) _horsePower = value; } }
        public double TankSize { get { return _tankSize; } set { if (value > 0 || value < 100) _tankSize = value; } }
        public double CurrentOil { get { return _currentOil; } set { if (value > 0 || value <= TankSize) _currentOil = value; } }
        public string FuelType { get { return _fuelType; } set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _fuelType = value; } }
        public override double DriveTime { get { return _driveTime; } set { if (value > 0) _driveTime = value; } }
        public override double DrivePath { get { return _drivePath; } set { if (value > 0) _drivePath = value; } }

        public Car(int doorCount, string vinCode, string transmissionKind, double wheelThickness, double horsePower, double tankSize, double currentOil, string fuelType, double driveTime, double drivePath)
        {
            DoorCount = doorCount;
            VinCode = vinCode;
            TransmissionKind = transmissionKind;
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
