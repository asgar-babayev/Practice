using Practice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Extensions
{
   public static class ReflectionExtension
    {
        public static void ShowInfo(this Vehicle vehicle)
        {
            Console.WriteLine("--------------------------------------------");
            foreach (var item in vehicle.GetType().GetProperties())
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(vehicle)}");
            }
            Console.WriteLine("DriveSpeed - " + vehicle.AverageSpeed());
            Console.WriteLine("--------------------------------------------");
        }
    }
}
