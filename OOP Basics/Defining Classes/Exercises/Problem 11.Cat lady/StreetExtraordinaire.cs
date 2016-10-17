namespace Problem_11.Cat_lady
{
    public class StreetExtraordinaire : Cat
    {
        public StreetExtraordinaire(string name, double decibels)
            : base(name)
        {
            this.Decibels = decibels;
        }

        public double Decibels { get; private set; }

        public override string ToString()
        {
            return this.GetType().Name + " " + base.ToString() + " " + this.Decibels;
        }
    }
}
