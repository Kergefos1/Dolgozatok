using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicle
    {
        private string _plate;
        private int _year;
        private bool _isElectric;
        private static int _count;

        public string Plate { get { return _plate; } set { _plate = value; } }
        public int Year { get { return _year; } set { if(_year >= 1996 && _year <= 2026) _year = value; } }
        public bool IsElectric { get { return _isElectric; } set { _isElectric = value; } }
        public static int Count { get {return _count; } }

        public Vehicle(string plate,int year,bool iselectric)
        {
            _plate = plate;
            _year = year;
            _isElectric = iselectric;
            _count++;
        }

        private int _balance;
        private int _hoursparked;

        public int Balance { get { return _balance; } }
        public int HoursParked { get { return _hoursparked; } }

        public bool TopUp(int amount)
        {
            if (amount == 1000 || amount == 2000 || amount == 5000)
            {
                _balance += amount;
                return true;
            }
            else
                return false;
        }
        public bool Park(int hours)
        {
            if (_isElectric && _balance > hours * 200)
            {
                _balance -= hours * 200;
                _hoursparked++;
                return true;
            }
            else if (_isElectric == false && _balance > hours * 400)
            {
                _balance -= hours * 400;
                _hoursparked++;
                return true;
            }
            else
                return false;
        }

        public string GetDescription()
        {
            if (_year == 0)
                return $"{_plate}, Ismeretlen Évjárat, {IsElectric}, {_balance}, {_hoursparked}, {Count}";
            else
                return $"{_plate}, {_year}, {IsElectric}, {_balance}, {_hoursparked}, {Count}";
        }

    }
}
