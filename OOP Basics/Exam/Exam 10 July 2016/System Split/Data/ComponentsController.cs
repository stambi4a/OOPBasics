namespace System_Split.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using System_Split.Enumerations;
    using System_Split.Factories;
    using System_Split.InputOutputManager;
    using System_Split.Models;

    public class ComponentsController
    {
        private readonly ComponentsDatabase componentsDatabase;

        private OutputWriter outputWriter;

        public ComponentsController(ComponentsDatabase database)
        {
            this.componentsDatabase = database;
            this.outputWriter = new OutputWriter();
            ;
        }

        public void RegisterPowerHardware(string name, int capacity, int memory)
        {
            this.RegisterHardware(typeof(PowerHardwareComponent).Name, name, capacity, memory);
        }

        public void RegisterHeavyHardware(string name, int capacity, int memory)
        {
            this.RegisterHardware(typeof(HeavyHardwareComponent).Name, name, capacity, memory);
        }

        public void RegisterExpressSoftware(string hardwareComponentName, string name, int capacity, int memory)
        {
            this.RegisterSoftware(hardwareComponentName, typeof(ExpressSoftwareComponent).Name, name, capacity, memory);
        }

        public void RegisterLightSoftware(string hardwareComponentName, string name, int capacity, int memory)
        {
            this.RegisterSoftware(hardwareComponentName, typeof(LightSoftwareComponent).Name, name, capacity, memory);
        }

        public void ReleaseSoftwareComponent(string hardwareComponentName, string softwareComponentName)
        {
            if (this.componentsDatabase.HardwareComponents.ContainsKey(hardwareComponentName) && 
                this.componentsDatabase.HardwareComponents[hardwareComponentName].SoftwareComponents.ContainsKey(softwareComponentName))
            {
                this.componentsDatabase.HardwareComponents[hardwareComponentName].SoftwareComponents.Remove(
                    softwareComponentName);
            }
        }

        public void Analyze()
        {
            var currentSystemInfo = new StringBuilder();
            currentSystemInfo.AppendLine("System Analysis");
            currentSystemInfo.Append("Hardware Components: ").Append(this.componentsDatabase.HardwareComponents.Count).AppendLine();
            currentSystemInfo.Append("Software Components: ").Append(this.CalculateSoftwareComponentsCount()).AppendLine();
            currentSystemInfo.Append("Total Operational Memory: ")
                .Append(this.CalculateTotalOperationalMemory(this.componentsDatabase.HardwareComponents))
                .Append(@" / ")
                .Append(this.CalculateTotalMemory())
                .AppendLine();
            currentSystemInfo.Append("Total Capacity Taken: ")
                .Append(this.CalculateTotalCapacityTaken(this.componentsDatabase.HardwareComponents))
                .Append(@" / ")
                .Append(this.CalculateTotalCapacity());

            this.outputWriter.WriteLine(currentSystemInfo);
        }

        public void SystemSplit()
        {
            var finalisedSystemInfo = new StringBuilder();
            var powerHardwareComponents =
                this.componentsDatabase.HardwareComponents.Where(
                    component => component.Value.HardwareType == HardwareComponentType.Power);
            this.BuildHardwareComponentInfo(finalisedSystemInfo, powerHardwareComponents);

            var heavyHardwareComponents =
                this.componentsDatabase.HardwareComponents.Where(
                    component => component.Value.HardwareType == HardwareComponentType.Heavy);
            this.BuildHardwareComponentInfo(finalisedSystemInfo, heavyHardwareComponents);
            

            this.outputWriter.WriteLine(finalisedSystemInfo);
        }

        public void Dump(string hardwareComponentName)
        {
            if (this.componentsDatabase.HardwareComponents.ContainsKey(hardwareComponentName))
            {
                this.componentsDatabase.DumpedComponents.Add(hardwareComponentName, this.componentsDatabase.HardwareComponents[hardwareComponentName]);
                this.componentsDatabase.HardwareComponents.Remove(hardwareComponentName);
            }
        }

        public void Restore(string hardwareComponentName)
        {
            if (this.componentsDatabase.DumpedComponents.ContainsKey(hardwareComponentName))
            {
                this.componentsDatabase.HardwareComponents.Add(hardwareComponentName, this.componentsDatabase.DumpedComponents[hardwareComponentName]);
                this.componentsDatabase.DumpedComponents.Remove(hardwareComponentName);
            }
        }

        public void Destroy(string hardwareComponentName)
        {
            if (this.componentsDatabase.DumpedComponents.ContainsKey(hardwareComponentName))
            {
                this.componentsDatabase.DumpedComponents.Remove(hardwareComponentName);
            }
        }

        public void DumpAnalyze()
        {
            var dumpedElementsInfo = new StringBuilder();
            dumpedElementsInfo.AppendLine("Dump Analysis");
            dumpedElementsInfo.Append("Power Hardware Components: ").Append(this.CalculateHardwareTypeComponentsCount(HardwareComponentType.Power)).AppendLine();
            dumpedElementsInfo.Append("Heavy Hardware Components: ").Append(this.CalculateHardwareTypeComponentsCount(HardwareComponentType.Heavy)).AppendLine();
            dumpedElementsInfo.Append("Express Software Components: ").Append(this.CalculateSoftwareTypeComponentsCount(SoftwareComponentType.Express)).AppendLine();
            dumpedElementsInfo.Append("Light Software Components: ").Append(this.CalculateSoftwareTypeComponentsCount(SoftwareComponentType.Light)).AppendLine();
            dumpedElementsInfo.Append("Total Dumped Memory: ")
                .Append(this.CalculateTotalOperationalMemory(this.componentsDatabase.DumpedComponents))
                .AppendLine();
            dumpedElementsInfo.Append("Total Dumped Capacity: ")
                .Append(this.CalculateTotalCapacityTaken(this.componentsDatabase.DumpedComponents));

            this.outputWriter.WriteLine(dumpedElementsInfo);
        }

        private int CalculateHardwareTypeComponentsCount(HardwareComponentType type)
        {
            return
                this.componentsDatabase.DumpedComponents.Values
                    .Count(component => component.HardwareType == type);
        }

        private int CalculateSoftwareTypeComponentsCount(SoftwareComponentType type)
        {
            return
                this.componentsDatabase.DumpedComponents.Values.Sum(
                    component =>
                    component.SoftwareComponents.Count(softwareComponent => softwareComponent.Value.SoftwareType == type));
        }

        private void BuildHardwareComponentInfo(StringBuilder builder, IEnumerable<KeyValuePair<string, HardwareComponent>> hardwareComponents)
        {
            foreach (var hardwareComponent in hardwareComponents)
            {
                builder.Append("Hardware Component - ").Append(hardwareComponent.Key).AppendLine();
                builder.Append("Express Software Components - ")
                    .Append(hardwareComponent.Value.SoftwareComponents.Count(component => component.Value.SoftwareType == SoftwareComponentType.Express))
                    .AppendLine();
                builder.Append("Light Software Components - ")
                   .Append(hardwareComponent.Value.SoftwareComponents.Count(component => component.Value.SoftwareType == SoftwareComponentType.Light))
                   .AppendLine();
                builder.Append("Memory Usage: ")
                  .Append(hardwareComponent.Value.MemoryInUse).Append(@" / ").Append(hardwareComponent.Value.Memory)
                  .AppendLine();
                builder.Append("Capacity Usage: ")
                 .Append(hardwareComponent.Value.CapacityInUse).Append(@" / ").Append(hardwareComponent.Value.Capacity)
                 .AppendLine();
                builder.AppendLine("Type: " + hardwareComponent.Value.HardwareType);
                builder.Append("Software Components: ");
                builder.Append(
                    hardwareComponent.Value.SoftwareComponents.Count == 0
                        ? "None"
                        : string.Join(", ", hardwareComponent.Value.SoftwareComponents.Keys));
                builder.AppendLine();
            }
        }

        private void RegisterHardware(string type, string name, int capacity, int memory)
        {
            var component = ComponentFactory.CreateComponent(type, name, capacity, memory) as HardwareComponent;
            this.componentsDatabase.HardwareComponents.Add(name, component);
        }

        private void RegisterSoftware(string hardwareComponentName, string type, string name, int capacity, int memory)
        {
            var component = ComponentFactory.CreateComponent(type, name, capacity, memory) as SoftwareComponent;
            if (this.componentsDatabase.HardwareComponents.ContainsKey(hardwareComponentName) &&
                this.CheckIfCapacityIsEnough(
                    capacity, 
                    this.componentsDatabase.HardwareComponents[hardwareComponentName].CapacityInUse,
                    this.componentsDatabase.HardwareComponents[hardwareComponentName].Capacity))
            {
                this.componentsDatabase.HardwareComponents[hardwareComponentName].SoftwareComponents.Add(name, component);
            }
        }

        private bool CheckIfCapacityIsEnough(int capacity, int capacityInUse, int maxCapacity)
        {
            return capacity + capacityInUse <= maxCapacity;
        }

        private int CalculateSoftwareComponentsCount()
        {
            var count =
                this.componentsDatabase.HardwareComponents.Values.Sum(component => component.SoftwareComponents.Count);

            return count;
        }

        private int CalculateTotalOperationalMemory(IDictionary<string, HardwareComponent> hardwareComponents)
        {
            var totalOperationalMemory = hardwareComponents.Values.Sum(component => component.MemoryInUse);
            return totalOperationalMemory;
        }

        private int CalculateTotalCapacityTaken(IDictionary<string, HardwareComponent> hardwareComponents)
        {
            var totalOperationalCapacity= hardwareComponents.Values.Sum(component => component.CapacityInUse);
            return totalOperationalCapacity;
        }

        private int CalculateTotalCapacity()
        {
            var totalOperationalCapacity = this.componentsDatabase.HardwareComponents.Values.Sum(component => component.Capacity);
            return totalOperationalCapacity;
        }

        private int CalculateTotalMemory()
        {
            var totalOperationalMemory = this.componentsDatabase.HardwareComponents.Values.Sum(component => component.Memory);
            return totalOperationalMemory;
        }
    }
}
