using System;

namespace VehicleManufacturingSystem
{
    public class Engineer<T> : IPerson where T : Vehicle
    {
        public string Name { get; set; }

        public Engineer(string name)
        {
            Name = name;
        }

        public void Design(T vehicle)
        {
            Console.WriteLine($"{Name} is designing {vehicle.Name}.");
        }

        public void SuperviseProduction(T vehicle)
        {
            Console.WriteLine($"{Name} is supervising the production of {vehicle.Name}.");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is performing duties.");
        }
    }
}
