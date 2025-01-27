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
        private string minimumMsg = "Les hores de spñ  no poden ser menor a {0}, torna a introduïr un numero.";
        private double limit = 1;
        public double SunHours {  get; set; }
        
        public SolarSystem(double sunHours, DateTime date) : base(date)
        {
            SunHours = sunHours;
        }
        public  double CalculateEnergy(double sunHours)
        {
            return Math.Round(SunHours * 1.5, 2);
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
            Console.WriteLine($"La energia calculada és {energy} Juls");
        }
        public string GetInfoRegistre(DateTime data, double resultenergy)
        {
            return $"| {data} |       Solar       |    {resultenergy} Juls    |";
        }
    }
}
