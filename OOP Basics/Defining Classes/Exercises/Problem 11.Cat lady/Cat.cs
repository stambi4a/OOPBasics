namespace Problem_11.Cat_lady
{
    public abstract class Cat
    {
        public Cat(string name)
        {
            this.Name = name; 
        }

        public string Name { get; private set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
