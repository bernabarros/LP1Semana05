using System;
using System.Reflection.Metadata;
using Bogus;
using Spectre;
using Spectre.Console;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            BarChart bc = new BarChart();

            Faker faker = new Faker(Vehicle_car)
                .RuleFor(u => u.Manufacturer, (f,u) => f.Vehicle.Manufacturer)
                .RuleFor(u => u.Number, (f,u) => f.Random.Number(1,20))
        }
    }

    public class Vehicle_car
    {
        public Vehicle_car();
        {
            
        }
        public string Manufacturer { get; set; }
        public int Number { get; set; }
    }
}
