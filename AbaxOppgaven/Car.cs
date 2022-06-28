using System;

namespace AbaxOppgaven
{
    class Car : Vehicle
    {
        protected int _maxSpeed;
        protected string _color;
        protected string _type;

        public Car(string ID, int power, int maxSpeed, string type, string color) : base(ID, power)
        {
            _maxSpeed = maxSpeed;
            _color = color;
            _type = type;
        }

        public override string InfoText()
        {
            return @$"Bil med reg.nr: {_ID}
Status: {_status}
Maksfart: {_maxSpeed} km/t
Effekt: {_power} kw
Farge: {_color}
Type: {_type}";
        }

        public override void Start()
        {
            _status = "kjører";
        }        
    }
}
