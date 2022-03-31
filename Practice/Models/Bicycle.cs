using Practice.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Models
{
    public class Bicycle:Vehicle,IWheel,ITransmission
    {
        public string PedalKind { get; set; }
        public override double DriveTime { get; set; }
        public override double DrivePath { get; set; }
        public double WheelThickness { get; set; }
        public string TransmissionKind { get; set; }

        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
