using System;
using static VehicleManufacturingSystem.Enumerations;

namespace VehicleManufacturingSystem
{
    public class Worker : IPerson
    {
        public string Name { get; set; }
        public FactorySection Section { get; set; }

        public Worker(string name, FactorySection section)
        {
            Name = name;
            Section = section;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is working in {Section}.");
        }
    }
}
