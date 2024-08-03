using System;
using static VehicleManufacturingSystem.Enumerations;

namespace VehicleManufacturingSystem
{
    public class Car : Vehicle
    {
        public Car(string name) : base(name, VehicleType.Car) { }

        public override void Assemble()
        {
            Console.WriteLine($"Assembling car {Name}");
            IsAssembled = true;
        }

        public override void Paint()
        {
            if (IsAssembled)
            {
                Console.WriteLine($"Painting car {Name}");
                IsPainted = true;
            }
            else
            {
                Console.WriteLine($"Cannot paint car {Name} because it is not assembled.");
            }
        }

        public override void Test()
        {
            if (IsAssembled && IsPainted)
            {
                Console.WriteLine($"Testing car {Name}");
                IsTested = true;
            }
            else
            {
                Console.WriteLine($"Cannot test car {Name} because it is not assembled and/or painted.");
            }
        }
    }
}
