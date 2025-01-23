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
        public override double CheckMinimumWaterFlow(double waterflow)
        {
            bool flag = true;
            string msgMinimum = "El cabl de l'aigua no pot ser menys de 20, torna a introduïr un numero.";

            while (flag)
            {
                flag = false;
                if (waterflow < 1)
                {
                    Console.WriteLine(msgMinimum);
                    flag = true;
                }
            }
            return waterflow;
        }

    }
}
