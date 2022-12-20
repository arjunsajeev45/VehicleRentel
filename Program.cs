using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentel.Helper;
using VehicleRentel.Model;
using System.Diagnostics;

namespace VehicleRentel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car C= new Car();
            Bike B = new Bike();
            HelperClass help = new HelperClass();

           Car C1= help.GetCarDetails(C);
            Bike B1=help.GetBikeDetails(B);

            help.DisplayCar(C1);
            help.DisplayBike(B1);
            help.WriteaFile(C , B);
            //Process.Start("notepad.exe", @"C:\Users\Rinsh\source\repos\VehicleRentel\notepad\" + C.Name + ".txt");

        }
    }
}
 