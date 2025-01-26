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
        private string minimumMsg = "El caudal de l'aigua no pot ser menor a {0}, torna a introduïr un numero.";
        private double limit = 20;
        public double WaterFlow { get; set; }
        public HidroelectricSystem(double waterFlow, DateTime date): base(date)
        {
            WaterFlow = waterFlow;
        }
        public double CalculateEnergy(double waterflow)
        {
            return waterflow * 9.8 * 0.8;
        }
        public override double CheckMinimumEnergySource(double windVelocity, double limit)
        {

            bool flag = true;

            while (flag)
            {
                flag = false;
                if (windVelocity < limit)
                {
                    Console.WriteLine(minimumMsg, limit);
                    flag = true;
                }
            }
            return windVelocity;
        }
        public override void ShowEnergyCalculated(double energy)
        {
            Console.WriteLine();
            Console.WriteLine($"La energia calculada és {energy}");
        }
    
    }
}
