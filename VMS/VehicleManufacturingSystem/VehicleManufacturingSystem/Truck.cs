using System;
using static VehicleManufacturingSystem.Enumerations;

namespace VehicleManufacturingSystem
{
    public class Truck : Vehicle
    {
        public Truck(string name) : base(name, VehicleType.Truck) { }

        public override void Assemble()
        {
            Console.WriteLine($"Assembling truck {Name}");
            IsAssembled = true;
        }

        public override void Paint()
        {
            if (IsAssembled)
            {
                Console.WriteLine($"Painting truck {Name}");
                IsPainted = true;
            }
            else
            {
                Console.WriteLine($"Cannot paint truck {Name} because it is not assembled.");
            }
        }

        public override void Test()
        {
            if (IsAssembled && IsPainted)
            {
                Console.WriteLine($"Testing truck {Name}");
                IsTested = true;
            }
            else
            {
                Console.WriteLine($"Cannot test truck {Name} because it is not assembled and/or painted.");
            }
        }
    }
}
