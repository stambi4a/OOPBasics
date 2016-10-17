namespace Raw_Data
{
    internal class Car
    {
        internal Car(string model, Engine engine, Cargo cargo, Tyre[] tyres)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tyres = tyres;
        }

        internal string Model { get; set; }
        internal Engine Engine { get; set; }
        internal Cargo Cargo { get; set; }
        internal Tyre[] Tyres { get; set; }
    }
}
