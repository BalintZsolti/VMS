using System;
using static VehicleManufacturingSystem.Enumerations;

namespace VehicleManufacturingSystem
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string name) : base(name, VehicleType.Motorcycle) { }

        public override void Assemble()
        {
            Console.WriteLine($"Assembling motorcycle {Name}");
            IsAssembled = true;
        }

        public override void Paint()
        {
            if (IsAssembled)
            {
                Console.WriteLine($"Painting motorcycle {Name}");
                IsPainted = true;
            }
            else
            {
                Console.WriteLine($"Cannot paint motorcycle {Name} because it is not assembled.");
            }
        }

        public override void Test()
        {
            if (IsAssembled && IsPainted)
            {
                Console.WriteLine($"Testing motorcycle {Name}");
                IsTested = true;
            }
            else
            {
                Console.WriteLine($"Cannot test motorcycle {Name} because it is not assembled and/or painted.");
            }
        }
    }
}
