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
        private double _limit = 1;
        public double SunHours {
            get {return SunHours;}
            set
            {
                if (SunHours < _limit) throw new ArgumentException(minimumMsg);}}
        
        public SolarSystem(double sunHours, DateTime date) : base(date)
        {
            SunHours = sunHours;
        }
        public  double CalculateEnergy(double sunHours)
        {
            return Math.Round(SunHours * 1.5, 2);
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
