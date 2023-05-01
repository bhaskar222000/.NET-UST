using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    public abstract class Car
    {
        public long Id 
        { get; set; }
        public string Name 
        { get; set; }
        public abstract double CalculateDriveCost(double km);
    }
    public class Hatchback : Car
    {
        public bool PowerWindows { get; set; }
        public bool AutomaticGear { get; set; }
        public Hatchback() { } 
        public Hatchback(long id, string name, bool powerWindows, bool automaticGear)
        {
            Id = id;
            Name = name;
            PowerWindows = powerWindows;
            AutomaticGear = automaticGear;
        }
        public override double CalculateDriveCost(double km)
        {
            double cost;
            if (AutomaticGear)
                cost = 12;
            else
                cost = 10;
            return cost * km;
        }
    }
    public class Sedan : Car
    {
        public bool ABS { get; set; }
        public int BootSpace { get; set; }
        public Sedan() { }
        public Sedan(long id, string name, bool abs, int bootSpace)
        {
            Id = id;
            Name = name;
            ABS = abs;
            BootSpace = bootSpace;
        }
        public override double CalculateDriveCost(double km)
        {
            double cost = 0;
            if (BootSpace > 600)
                cost = 15 + (15 * 0.20);
            else
                cost = 15;
            return cost * km;
        }
    }
    public class UtilityCar : Car

    {
        public bool RearCoolingVents { get; set; }
        public UtilityCar() { }
        public UtilityCar(long id, string name, bool rearCoolingVents)
        {
            Id = id;
            Name = name;
            RearCoolingVents = rearCoolingVents;
        }
        public override double CalculateDriveCost(double km)
        {
            return 18 * km;
        }
    }
}
