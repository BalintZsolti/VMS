using System;

namespace VehicleManufacturingSystem
{
    public class FactoryManager : IPerson
    {
        public string Name { get; set; }

        public FactoryManager(string name)
        {
            Name = name;
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is overseeing the factory operations.");
        }
    }
}
