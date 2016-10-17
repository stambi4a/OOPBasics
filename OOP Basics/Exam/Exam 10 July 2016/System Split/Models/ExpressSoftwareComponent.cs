namespace System_Split.Models
{
    using System_Split.Enumerations;

    public class ExpressSoftwareComponent : SoftwareComponent
    {
        private const decimal DefaultExpressSoftwareCapacityIncrease = 0;
        private const decimal DefaultExpressSoftwareMemoryIncrease = 1m;
        private const SoftwareComponentType DefaultExpressSoftwareType = SoftwareComponentType.Express;

        public ExpressSoftwareComponent(string name, int capacity, int memory)
            : base(name, capacity, memory, DefaultExpressSoftwareType, DefaultExpressSoftwareCapacityIncrease, DefaultExpressSoftwareMemoryIncrease)
        {
        }
    }
}
