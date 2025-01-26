using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3._PR1._Pràctica_1.EnegyClass
{
    public abstract class EnergySystem
    {
        protected string Date {  get; set; }
        public abstract double CheckMinimumEnergySource(double sourceEnergy, double minimumRange);

        public abstract string ShowEnergyCalculated( double energy);
        public abstract void  CheckDate(string date);
    }
}
