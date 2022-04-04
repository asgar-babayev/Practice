using Practice.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public class Bicycle:Vehicle,IWheel,ITransmission
    {
        private string _pedalKind;
        private double _driveTime;
        private double _drivePath;
        private string _transmissionKind;
        private double _wheelThickness;
        public string PedalKind 
        {
            get { return _pedalKind; } 
            set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _pedalKind = value; } 
        }
        public override double DriveTime { get { return _driveTime; } set { if (value > 0) _driveTime = value; } }
        public override double DrivePath { get { return _drivePath; } set { if (value > 0) _drivePath = value; } }
        public string TransmissionKind { get { return _transmissionKind; } set { if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) _transmissionKind = value; } }
        public double WheelThickness { get { return _wheelThickness; } set { if (value > 0) _wheelThickness = value; } }


        public Bicycle(string pedalKind, double wheelThickness, string transmissionKind, double driveTime, double drivePath)
        {
            PedalKind = pedalKind;
            WheelThickness = wheelThickness;
            TransmissionKind = transmissionKind;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
    }
}
