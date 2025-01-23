using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3._PR1._Pràctica_1.EnegyClass
{
    public class WindSystem : EnergySystem
    {
        public double WindVelocity {  get; set; }

        public WindSystem (double windVelocity) 
        {
            windVelocity = this.WindVelocity;
        }
        public override double CalculateEnergy( double windVelocity)
        {
            return Math.Pow(windVelocity,3) * 0.2; 
        }
    }
}
