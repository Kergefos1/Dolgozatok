using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Console1
    {
        public void ShowVehicle(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetDescription());
        }

        public void ShowVehicles(List<Vehicle> vehicles)
        {
            vehicles.ForEach(x => Console.WriteLine(x.GetDescription()));
        }
        
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
