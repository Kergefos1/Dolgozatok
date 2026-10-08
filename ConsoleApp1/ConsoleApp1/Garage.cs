using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Garage
    {
        private string _name;
        private int _capacity;
        private List<Vehicle> _vehicles;

        public string Name { get { return _name; }set {_name = value; } }
        public int Capacity { get { return _capacity; } }
        public List<Vehicle> Vehicles { get { return _vehicles; } }


        public Garage(string name, int capacity)
        {
            _name = name;
            _capacity = capacity;
            List<Vehicle> vehicles = new();
        }

        public bool AddVehilce(Vehicle vehicle)
        {
            return false;       
        }

        public string FindbyPlate(string plate)
        {
            return _vehicles.Where(x => x.Plate == plate).Select(x => x.Plate).ToString();
        }


    }
}
