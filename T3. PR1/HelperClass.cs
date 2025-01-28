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
                    
                    if (needCheck < minRange || needCheck > maxRange)
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
    }
}
