using Practice.Extensions;
using Practice.Models;
using System;

namespace Practice
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choise = 0;
            do
            {
                SetChoiseForSwitch(ref choise);
                switch (choise)
                {
                    case 0:
                        InfoSwitchCase();
                        break;
                    case 1:
                        SetPedalKind(out string pedalKind);
                        SetWheelTickness(out double wheelTicknessBicycle);
                        SetTransmissionKind(out string transmissionKindBicycle);
                        SetDriveTime(out double driveTimeBicycle);
                        SetDrivePath(out double drivePathBicycle);
                        Bicycle bicycle = new Bicycle(pedalKind, wheelTicknessBicycle, transmissionKindBicycle, driveTimeBicycle, drivePathBicycle);
                        bicycle.ShowInfo();
                        break;
                    case 2:
                        SetDoorCount(out int doorCount);
                        SetVinCode(out string vinCode);
                        SetTransmissionKind(out string transmissionKindCar);
                        SetWheelTickness(out double wheelTicknessCar);
                        SetHorsePower(out double horsePowerCar);
                        SetTankSize(out double tankSizeCar);
                        SetCurrentOil(out double currentOilCar);
                        SetFuelType(out string oilTypeCar);
                        SetDriveTime(out double driveTimeCar);
                        SetDrivePath(out double drivePathCar);
                        Car car = new Car(doorCount, vinCode, transmissionKindCar, wheelTicknessCar, horsePowerCar, tankSizeCar, currentOilCar, oilTypeCar, driveTimeCar, drivePathCar);
                        car.ShowInfo();
                        Console.WriteLine("LeftOilAmount - " + car.LeftOilAmount());
                        Console.WriteLine("--------------------------------------------");
                        break;
                    case 3:
                        SetWingLength(out int wingLength);
                        SetWheelTickness(out double wheelTicknessPlane);
                        SetHorsePower(out double horsePowerPlane);
                        SetTankSize(out double tankSizePlane);
                        SetCurrentOil(out double currentOilPlane);
                        SetFuelType(out string oilTypePlane);
                        SetDriveTime(out double driveTimePlane);
                        SetDrivePath(out double drivePathPlane);
                        Plane plane = new Plane(wingLength, wheelTicknessPlane, horsePowerPlane, tankSizePlane, currentOilPlane, oilTypePlane, driveTimePlane, drivePathPlane);
                        plane.ShowInfo();
                        Console.WriteLine("LeftOilAmount - " + plane.LeftOilAmount());
                        Console.WriteLine("--------------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Çıxış edildi.");
                        break;
                    default:
                        break;
                }
            } while (choise != 4);
        }
    }
}
