﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3._PR1.EnergyClasses;

namespace T3._PR1._Practica_1.EnegyClass
{
    public class WindSystem : EnergySystem, IEnergyCalculate
    {

        private string minimumMsg = "La velocitat del vent no pot ser menor a {0}, torna a introduir un número.";
        private double _limit =5;
        public double WindVelocity { get; set; }

        public WindSystem (double windVelocity, DateTime date) : base(date)
        {
            while (windVelocity < _limit)
            {
                Console.WriteLine(string.Format(minimumMsg, _limit));
                Console.WriteLine();
                windVelocity = HelperClass.CheckTypeDouble();
            }
            WindVelocity = windVelocity;
        }
        public  double CalculateEnergy( double energy)
        {
            return Math.Round(Math.Pow(energy, 3) * 0.2, 2); 
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
