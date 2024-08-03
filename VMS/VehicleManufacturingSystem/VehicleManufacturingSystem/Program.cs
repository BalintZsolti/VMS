using System;
using System.Collections.Generic;
using System.Linq;
using static VehicleManufacturingSystem.Enumerations;

namespace VehicleManufacturingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Car1"),
                new Truck("Truck1"),
                new Motorcycle("Motorcycle1")
            };

            List<IPerson> workforce = new List<IPerson>
            {
                new Worker("Worker1", FactorySection.AssemblyLine),
                new Worker("Worker2", FactorySection.PaintShop),
                new Worker("Worker3", FactorySection.TestingGround),
                new Engineer<Car>("Engineer1"),
                new Engineer<Truck>("Engineer2"),
                new Engineer<Motorcycle>("Engineer3"),
                new FactoryManager("Manager1")
            };

            Engineer<T> FindEngineer<T>() where T : Vehicle
            {
                return workforce.OfType<Engineer<T>>().FirstOrDefault();
            }

            foreach (var vehicle in vehicles)
            {

                if (vehicle is Car)
                {
                    var engineer = FindEngineer<Car>();
                    if (engineer != null)
                    {
                        engineer.Design((Car)vehicle);
                        engineer.SuperviseProduction((Car)vehicle);
                    }
                    else
                    {
                        Console.WriteLine($"No suitable engineer found for {vehicle.Name}.");
                    }
                }
                else if (vehicle is Truck)
                {
                    var engineer = FindEngineer<Truck>();
                    if (engineer != null)
                    {
                        engineer.Design((Truck)vehicle);
                        engineer.SuperviseProduction((Truck)vehicle);
                    }
                    else
                    {
                        Console.WriteLine($"No suitable engineer found for {vehicle.Name}.");
                    }
                }
                else if (vehicle is Motorcycle)
                {
                    var engineer = FindEngineer<Motorcycle>();
                    if (engineer != null)
                    {
                        engineer.Design((Motorcycle)vehicle);
                        engineer.SuperviseProduction((Motorcycle)vehicle);
                    }
                    else
                    {
                        Console.WriteLine($"No suitable engineer found for {vehicle.Name}.");
                    }
                }

                foreach (var person in workforce.OfType<Worker>())
                {
                    if (person.Section == FactorySection.AssemblyLine)
                    {
                        person.PerformDuties();
                        vehicle.Assemble();
                    }
                    else if (person.Section == FactorySection.PaintShop)
                    {
                        person.PerformDuties();
                        vehicle.Paint();
                    }
                    else if (person.Section == FactorySection.TestingGround)
                    {
                        person.PerformDuties();
                        vehicle.Test();
                    }
                }

                vehicle.Ship();
            }

            foreach (var person in workforce.OfType<FactoryManager>())
            {
                person.PerformDuties();
            }
        }
    }
}
