using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3._PR1.EnergyClasses;

namespace T3._PR1._Pràctica_1.EnegyClass
{
    public class HidroelectricSystem : EnergySystem, IEnergyCalculate
    {
        public double WaterFlow {  get; set; }
        public HidroelectricSystem(double waterFlow) 
        {
            WaterFlow = waterFlow;
        }
        public  double CalculateEnergy( double waterflow)
        {
            return waterflow * 9.8 * 0.8;
        }
    }
}
