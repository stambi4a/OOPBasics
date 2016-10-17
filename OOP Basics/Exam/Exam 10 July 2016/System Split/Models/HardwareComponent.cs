namespace System_Split.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using System_Split.Enumerations;

    public abstract class HardwareComponent : Component
    {
        protected HardwareComponent(
            string name, 
            int capacity, 
            int memory, 
            HardwareComponentType hardwareType,
            decimal capacityIncrease,
            decimal memoryIncrease)
            : base(name, capacity, memory, capacityIncrease, memoryIncrease)
        {
            this.SoftwareComponents = new Dictionary<string, SoftwareComponent>();
            this.HardwareType = hardwareType;
        }

        public HardwareComponentType HardwareType { get; }

        public IDictionary<string, SoftwareComponent> SoftwareComponents { get; protected set; }

        public int MemoryInUse => this.CalculateUsedMemory();

        public int CapacityInUse => this.CalculateUsedCapacity();

        public void AddSoftwareComponent(SoftwareComponent component)
        {
            this.SoftwareComponents.Add(component.Name, component);
        }

        public void RemoveSoftwareComponent(SoftwareComponent component)
        {
            this.SoftwareComponents.Remove(component.Name);
        }

        public int CalculateUsedMemory()
        {
            return this.SoftwareComponents.Sum(component => component.Value.Memory);
        }

        public int CalculateUsedCapacity()
        {
            return this.SoftwareComponents.Sum(component => component.Value.Capacity);
        }
    }
}
