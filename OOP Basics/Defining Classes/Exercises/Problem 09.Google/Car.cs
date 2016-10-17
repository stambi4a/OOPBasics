namespace Problem_09.Google
{
    using System;

    internal class Car
    {
        internal Car(string model,int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        internal string Model { get; private set; }

        internal int Speed { get; private set; }

        public override string ToString()
        {
            return $"{this.Model} {this.Speed}{Environment.NewLine}";
        }
    }
}
