namespace Problem_11.Cat_lady
{
    public class Siamese : Cat
    {
        public Siamese(string name, double earSize)
            : base(name)
        {
            this.EarSize = earSize;
        }

        public double EarSize { get; private set; }

        public override string ToString()
        {
            return this.GetType().Name + " " + base.ToString() + " " + this.EarSize;
        }
    }
}
