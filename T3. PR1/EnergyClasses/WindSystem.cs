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

        private string minimumMsg = "La velocitat del vent no pot ser menor a {0}, torna a introduïr un numero.";
        private double _limit =5;
        public double WindVelocity {
            get {return WindVelocity;}
            set { if (WindVelocity < _limit) throw new ArgumentException(minimumMsg); }
        }

        public WindSystem (double windVelocity, DateTime date) : base(date)
        {
            WindVelocity = windVelocity;
        }
        public  double CalculateEnergy( double windVelocity)
        {
            return Math.Round(Math.Pow(windVelocity,3) * 0.2, 2); 
        }
        public override void ShowEnergyCalculated(double energy)
        {
            Console.WriteLine();
            Console.WriteLine( $"La energia calculada és {energy} Juls");
        }
        
        public string GetInfoRegistre(DateTime data, double resultenergy)
        {
            return $"| {data} |       Eolic       |    {resultenergy} Juls    |";
        }

    }
}
