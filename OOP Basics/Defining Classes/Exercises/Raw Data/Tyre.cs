namespace Raw_Data
{
    internal class Tyre
    {
        internal Tyre(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }

        internal int Age { get; set; }

        internal double Pressure { get; set; }
    }
}
