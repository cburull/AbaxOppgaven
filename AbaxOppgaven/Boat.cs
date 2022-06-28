namespace AbaxOppgaven
{
    class Boat : Vehicle
    {
        protected int _maxSpeed;
        protected int _grossTonnage;

        public Boat(string ID, int power, int maxSpeed, int grossTonnage) : base(ID, power)
        {
            _maxSpeed = maxSpeed;
            _grossTonnage = grossTonnage;
        }

        public override string InfoText()
        {
            return @$"Båt med kjennetegn: {_ID}.
Status: {_status}
Maksfart: {_maxSpeed} knop
Effekt: {_power} kw
Bruttotonnasje: {_grossTonnage} kg";
        }

        public override void Start()
        {
            _status = "kjører";
        }
    }
}
