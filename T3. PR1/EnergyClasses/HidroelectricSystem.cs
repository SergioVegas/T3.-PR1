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
        public HidroelectricSystem(double waterFlow)
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
        public override string ShowEnergyCalculated(double energy)
        {
            return $"La energia calculada és {energy}";
        }
        public override void CheckDate(string date)
        {
            const string MsgWrongDay = "No es posible que sigui aquest dia, torna a introduir una data valida.";
            const string MsgWrongMonth = "No es posible que sigui aquest mes, torna a introduir una data valida.";
            const string MsgWrongYear = "No es posible que sigui aquest any, torna a introduir una data valida.";
            const int ActualYear = 2025;
            const int MinDate = 1;
            const int MaxDay = 31;
            const int MaxMonth = 12;
            string[] arrayDate = date.Split('-', ' ', '/');
            int[] arrayNumbers = new int[arrayDate.Length];
            for (int i = 0; i < arrayDate.Length; i++)
            {
                arrayNumbers[i] = int.Parse(arrayDate[i]);
            }
            if (arrayNumbers[0] > MaxDay | arrayNumbers[0] < MinDate)
            { Console.WriteLine(MsgWrongDay); }
            else if (arrayNumbers[1] > MaxMonth| arrayNumbers[0] < MinDate) {Console.WriteLine(MsgWrongMonth);}
            else if (arrayNumbers[2] == ActualYear) { Console.WriteLine(MsgWrongYear);}
        }
    }
}
