using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    partial class Program
    {
        #region Inputs

        static void SetPedalKind(out string pedalKind)
        {
        Start:
            try
            {
                Console.Write("Pedalın növünü daxil edin: ");
                pedalKind = Console.ReadLine();
                CheckPedalKind(pedalKind);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckPedalKind(string pedalKind)
        {
            if (string.IsNullOrEmpty(pedalKind) || string.IsNullOrWhiteSpace(pedalKind))
                throw new Exception("Pedal növünü daxil etmək məcburidir.");
        }

        static void SetWheelTickness(out double wheelTickness)
        {
        Start:
            try
            {
                Console.Write("Təkərin qalınlığını daxil edin: ");
                wheelTickness = Convert.ToDouble(Console.ReadLine());
                CheckWheelTickness(wheelTickness);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckWheelTickness(double wheelTickness)
        {
            if (wheelTickness <= 0)
                throw new Exception("Təkər qalınlığını daxil etmək məcburidir.");
        }

        static void SetTransmissionKind(out string transmissionKind)
        {
        Start:
            try
            {
                Console.Write("Ötürmə növünü daxil edin: ");
                transmissionKind = Console.ReadLine();
                CheckTransmissionKind(transmissionKind);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckTransmissionKind(string transmissionKind)
        {
            if (string.IsNullOrEmpty(transmissionKind) || string.IsNullOrWhiteSpace(transmissionKind))
                throw new Exception("Ötürmə növünü daxil etmək məcburidir.");
        }

        static void SetDriveTime(out double driveTime)
        {
        Start:
            try
            {
                Console.Write("Gedilən vaxtı daxil edin: ");
                driveTime = Convert.ToDouble(Console.ReadLine());
                CheckDriveTime(driveTime);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckDriveTime(double driveTime)
        {
            if (driveTime <= 0)
                throw new Exception("Gedilən vaxtı daxil etmək məcburidir.");
        }

        static void SetDrivePath(out double drivePath)
        {
        Start:
            try
            {
                Console.Write("Gedilən yolu daxil edin: ");
                drivePath = Convert.ToDouble(Console.ReadLine());
                CheckDrivePath(drivePath);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckDrivePath(double drivePath)
        {
            if (drivePath <= 0)
                throw new Exception("Gedilən yolu daxil etmək məcburidir.");
        }

        static void SetDoorCount(out int doorCount)
        {
        Start:
            try
            {
                Console.Write("Qapı sayını daxil edin: ");
                doorCount = Convert.ToInt32(Console.ReadLine());
                CheckDoorCount(doorCount);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckDoorCount(int doorCount)
        {
            if (doorCount <= 0 || doorCount > 10)
                throw new Exception("Qapı sayını düzgün daxil edin.");
        }

        static void SetVinCode(out string vinCode)
        {
        Start:
            try
            {
                Console.Write("Vin kodu daxil edin: ");
                vinCode = Console.ReadLine();
                CheckVinCode(vinCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckVinCode(string vinCode)
        {
            if (string.IsNullOrEmpty(vinCode) || string.IsNullOrWhiteSpace(vinCode))
                throw new Exception("Vin kodu daxil etmək məcburidir.");
        }

        static void SetHorsePower(out double horsePower)
        {
        Start:
            try
            {
                Console.Write("At gücünü daxil edin: ");
                horsePower = Convert.ToDouble(Console.ReadLine());
                CheckHorsePower(horsePower);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckHorsePower(double horsePower)
        {
            if (horsePower <= 0)
                throw new Exception("At gücü daxil etmək məcburidir.");
        }

        public static double tS;
        static void SetTankSize(out double tankSize)
        {
        Start:
            try
            {
                Console.Write("Yağ tutumunu daxil edin: ");
                tankSize = Convert.ToDouble(Console.ReadLine());
                tS = tankSize;
                CheckTankSize(tankSize);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckTankSize(double tankSize)
        {
            if (tankSize <= 0)
                throw new Exception("Yağ tutumunu daxil etmək məcburidir.");
        }

        static void SetCurrentOil(out double currentOil)
        {
        Start:
            try
            {
                Console.Write("Cari yağ miqdarını daxil edin: ");
                currentOil = Convert.ToDouble(Console.ReadLine());
                CheckCurrentOil(currentOil);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckCurrentOil(double currentOil)
        {
            if (currentOil < 0 || tS < currentOil)
                throw new Exception("Cari yağ miqdarı yağ tutumundan çox ola bilməz.");
        }

        static void SetFuelType(out string fuelType)
        {
        Start:
            try
            {
                Console.Write("Benzin növünü daxil edin: ");
                fuelType = Console.ReadLine();
                CheckFuelType(fuelType);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckFuelType(string oilType)
        {
            if (string.IsNullOrEmpty(oilType) || string.IsNullOrWhiteSpace(oilType))
                throw new Exception("Benzin növünü daxil etmək məcburidir.");
        }

        static void SetWingLength(out int wingLength)
        {
        Start:
            try
            {
                Console.Write("Qanad uzunluğunu daxil edin: ");
                wingLength = Convert.ToInt32(Console.ReadLine());
                CheckDoorCount(wingLength);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CheckWingLength(int wingLength)
        {
            if (wingLength <= 0 || wingLength > 120)
                throw new Exception("Qanad uzunluğu 0-dan az 120-dən çox ola bilməz");
        }

        static void SetChoiseForSwitch(ref int choise)
        {
        Start:
            try
            {
                Console.Write("(Info - 0) Seçim edin: ");
                choise = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InfoSwitchCase()
        {
            Console.WriteLine(@"0 - Info
1 - Velosiped əlavə et
2 - Maşın əlavə et
3 - Təyyarə əlavə et
4 - Çıxış");
        }
        #endregion
    }
}
