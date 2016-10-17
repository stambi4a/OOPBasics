namespace Kermen.Models
{
    using Interfaces;

    public abstract class ElectricalConsumer : IElectricalConsumer
    {
        protected ElectricalConsumer(double cost)
        {
            this.CostPerMonth = cost;
        }

        public double CostPerMonth { get; protected set; }
    }
}
