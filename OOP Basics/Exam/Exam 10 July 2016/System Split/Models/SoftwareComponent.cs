namespace System_Split.Models
{
    using Enumerations;

    public abstract class SoftwareComponent : Component
    {
        protected SoftwareComponent(string name, int capacity, int memory, SoftwareComponentType softwareType, decimal capacityIncrease, decimal memoryIncrease)
            : base(name, capacity, memory, capacityIncrease, memoryIncrease)
        {
            this.SoftwareType = softwareType;
        }

        public SoftwareComponentType SoftwareType { get; }
    }
}
