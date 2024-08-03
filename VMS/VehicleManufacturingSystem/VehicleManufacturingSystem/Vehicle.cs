using System;
using static VehicleManufacturingSystem.Enumerations;

namespace VehicleManufacturingSystem
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public VehicleType Type { get; set; }
        public bool IsAssembled { get; protected set; }
        public bool IsPainted { get; protected set; }
        public bool IsTested { get; protected set; }

        public Vehicle(string name, VehicleType type)
        {
            Name = name;
            Type = type;
        }

        public abstract void Assemble();

        public virtual void Paint()
        {
            Console.WriteLine($"Painting {Name}");
            IsPainted = true;
        }

        public virtual void Test()
        {
            Console.WriteLine($"Testing {Name}");
            IsTested = true;
        }

        public virtual void Ship()
        {
            if (IsAssembled && IsPainted && IsTested)
            {
                Console.WriteLine($"Shipping {Name}");
            }
            else
            {
                Console.WriteLine($"Cannot ship {Name}. It needs to be assembled, painted, and tested first.");
            }
        }
    }
}
