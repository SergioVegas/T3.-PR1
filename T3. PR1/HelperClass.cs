using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3._PR1
{
    public static class HelperClass
    {
        public static double CheckTypeDouble()
        {
            const string MsgNoNegative = "Aquest nombre no pot ser negatiu. ";
            double needCheck = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    needCheck = double.Parse(Console.ReadLine());
                    flag = false;
                    if (needCheck < 0)
                    {
                        flag = true;
                        Console.WriteLine(MsgNoNegative);
                    }
                }
                catch (FormatException)
                { Console.WriteLine("Format incorrecte"); }

            }
            return needCheck;
        }
        public static int CheckTypeInt()
        {
            const string MsgNoNegative = "Aquest nombre no pot ser negatiu. ";
            int needCheck = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    needCheck = int.Parse(Console.ReadLine());
                    flag = false;
                    if (needCheck < 0)
                    {
                        flag = true;
                        Console.WriteLine(MsgNoNegative);
                    }
                }
                catch (FormatException)
                { Console.WriteLine("Format incorrecte"); }

            }
            return needCheck;
        }
        public static int CheckTypeIntWithRange(int minRange, int maxRange)
        {
            const string MsgNotInRange = "Aquest numero no esta entre el rang definit.";
            int needCheck = 0;
            bool flag = true;

            while (flag)
            {
                try
                {
                    needCheck = int.Parse(Console.ReadLine());
                    flag = false;
                    
                    if (needCheck < minRange | needCheck > maxRange)
                    {
                        flag = true;
                        Console.WriteLine(MsgNotInRange);
                    }
                }
                catch (FormatException)
                { Console.WriteLine("Format incorrecte");}
            }
            return needCheck;
        }
        public static void FillArray(double[] arrayDouble, double filler)
        {
            arrayDouble[i] = filler;
        }
        //No se si realment es util, per aixo no l'he implementat
        public static void CheckDate(string date)
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
            else if (arrayNumbers[1] > MaxMonth | arrayNumbers[0] < MinDate) { Console.WriteLine(MsgWrongMonth); }
            else if (arrayNumbers[2] == ActualYear) { Console.WriteLine(MsgWrongYear); }
        }
    }
}
