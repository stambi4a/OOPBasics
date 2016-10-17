namespace Raw_Data
{
    internal class Cargo
    {
        internal Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        internal string Type { get; set; }

        internal int Weight { get; set; }
    }
}
