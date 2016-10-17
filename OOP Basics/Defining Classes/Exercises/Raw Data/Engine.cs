namespace Raw_Data
{
    internal class Engine
    {
        internal Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        internal int Speed { get; set; }

        internal int Power { get; set; }
    }
}
