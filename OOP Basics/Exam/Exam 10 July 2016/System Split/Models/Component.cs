namespace System_Split.Models
{
    public abstract class Component
    {
        protected Component(string name, int capacity, int memory, decimal capacityIncrease, decimal memoryIncrease)
        {
            this.Name = name;
            this.CapacityIncrease = capacityIncrease;
            this.MemoryIncrease = memoryIncrease;
            this.CalculateCapacity(capacity);
            this.CalculateMemory(memory);
        }

        public string Name { get; protected set; }

        public  decimal CapacityIncrease { get; protected set; }

        public  decimal MemoryIncrease { get; protected set; }

        public int Capacity { get; private set; }

        public int Memory { get; private set; }

        protected void CalculateCapacity(int capacity)
        {
            this.Capacity = capacity + (int)(capacity * this.CapacityIncrease);
        }

        protected void CalculateMemory(int memory)
        {
            this.Memory = memory + (int)(memory * this.MemoryIncrease);
        }
    }
}
