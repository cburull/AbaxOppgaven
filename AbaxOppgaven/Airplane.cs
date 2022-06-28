namespace AbaxOppgaven
{
    class Airplane : Vehicle
    {
        protected string _type;
        protected int _weight;
        protected int _loadCapacity;
        protected int _wingSpan;

        public Airplane(string ID, int power, string type, int weight, int loadCapacity, int wingSpan) : base(ID, power)
        {
            _type = type;
            _weight = weight;
            _loadCapacity = loadCapacity;
            _wingSpan = wingSpan;
        }

        public override string InfoText()
        {
            return @$"Fly med kjennetegn: {_ID}
Status: {_status}
Effekt: {_power} kw
Egenvekt: {_weight} tonn
Lasteevne: {_weight} tonn
Vingespenn: {_wingSpan} meter";
        }

        public override void Start()
        {
            _status = "flyr";
        }
    }
}
