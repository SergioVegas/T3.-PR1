using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3._PR1._Pràctica_1.EnegyClass
{
    public class HidroelectricSystem : EnergySystem
    {
        public double WaterFlow {  get; set; }
        public HidroelectricSystem(double waterFlow) 
        {
            waterFlow = this.WaterFlow;
        }
        public override double CalculateEnergy( double waterflow)
        {
            return waterflow * 9.8 * 0.8;
        }
    }
}
