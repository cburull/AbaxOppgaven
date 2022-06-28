using System;

namespace AbaxOppgaven
{
    abstract class Vehicle
    {
        protected int _power;
        protected string _ID;
        protected string _status = "ingen";

        public Vehicle(string ID, int power)
        {
            _power = power;
            _ID = ID;
        }

        public void ShowInfo()
        {
            Console.WriteLine(InfoText());
            Console.WriteLine();
        }

        public abstract string InfoText();

        public abstract void Start();

        public string SameVehicle_Text(Vehicle vehicle2)
        {
            return _ID == vehicle2._ID ? "like" : "forskjellige";
        }
    }
}
