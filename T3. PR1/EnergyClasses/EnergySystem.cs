using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3._PR1._Pràctica_1.EnegyClass
{
    public abstract class EnergySystem
    {
        protected DateTime Date {  get; set; }

        protected EnergySystem(DateTime date) { Date = date; }
        //Como implementarlo antes de instanciar obejto??
        public abstract double CheckMinimumEnergySource(double sourceEnergy, double minimumRange);

        public abstract void ShowEnergyCalculated( double energy);
    }
}
