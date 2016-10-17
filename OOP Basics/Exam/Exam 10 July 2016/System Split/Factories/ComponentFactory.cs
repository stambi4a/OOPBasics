namespace System_Split.Factories
{
    using System;

    using System_Split.Models;

    public class ComponentFactory
    {
        public static Component CreateComponent(string componentType, string name, int capacity, int memory)
        {
            var type = Type.GetType("System_Split.Models." + componentType);
            var component = (Component)Activator.CreateInstance(type, name, capacity, memory);

            return component;
            /*switch(componentType)
            {
                case "PowerHardware":
                    {
                        return new PowerHardwareComponent(name, capacity, memory);
                    }

                case "HeavyHardware":
                    {
                        return new HeavyHardwareComponent(name, capacity, memory);
                    }

                case "LightSoftware":
                    {
                        return new LightSoftwareComponent(name, capacity, memory);
                    }

                case "ExpressSoftware":
                    {
                        return new ExpressSoftwareComponent(name, capacity, memory);
                    }

                default:
                    {
                        throw new ArgumentException("Invalid command!");
                    }
            }*/
        }
    }
}
