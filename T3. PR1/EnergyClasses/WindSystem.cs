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
        public static double CheckMinimumWindVelocity(double windVelocity)
        {
            bool flag = true;
            string msgMinimum = "La velocitat del vent no pot ser menor a 5, torna a introduïr un numero.";

            while (flag)
            {
                flag = false;
                if (windVelocity < 5)
                {
                    Console.WriteLine(msgMinimum);
                    flag = true;
                }
            }
            return windVelocity;
        }
    }
}
