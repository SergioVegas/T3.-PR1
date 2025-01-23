using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3._PR1.EnergyClasses;

namespace T3._PR1._Pràctica_1.EnegyClass
{
    public class WindSystem : EnergySystem, IEnergyCalculate
    {
        public double WindVelocity {  get; set; }

        public WindSystem (double windVelocity) 
        {
            WindVelocity = windVelocity;
        }
        public  double CalculateEnergy( double windVelocity)
        {
            return Math.Pow(windVelocity,3) * 0.2; 
        }
    }
}
