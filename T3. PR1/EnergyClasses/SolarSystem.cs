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
        
        public SolarSystem(double sunHours )
        {
            SunHours = sunHours;
        }
        public  double CalculateEnergy(double sunHours)
        {
            return SunHours * 1.5;
        }
        public static double CheckMinimumSunHours(double sunHours)
        {
            bool flag = true;
            string msgMinimum = "Les hores de sol no pot ser menor a 1, torna a introduïr un numero.";

            while (flag)
            {
                flag = false;
                if (sunHours < 1) 
                { 
                    Console.WriteLine(msgMinimum);
                    flag = true;
                }
            }
            return sunHours;
        }
    }
}
