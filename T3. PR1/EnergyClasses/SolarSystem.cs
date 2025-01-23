using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3._PR1.EnergyClasses;

namespace T3._PR1._Pràctica_1.EnegyClass
{
    public  class SolarSystem : EnergySystem, IEnergyCalculate
    {
        public double SunHours {  get; set; }
        
        public SolarSystem(int sunHours )
        {
            sunHours = this.sunHours;
        }
        public  double CalculateEnergy(double sunHours)
        {
            return SunHours * 1.5;
        }
    }
}
