using System;
using T3._PR1;
using T3.PR1;
using T3._PR1._Pràctica_1.EnegyClass;
using T3._PR1.EnergyClasses;
namespace T3.PR1
{
    public static class RenovableEnergy
    {
        const string Title = "   _      _      _      _      _      _      _      _      _      _      _      _      _      _   \r\n _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_ \r\n(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)\r\n (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_) \r\n   _                                                                                          _   \r\n _( )_                                                                                      _( )_ \r\n(_ o _)     ░█▀▀░█▀▀░█▀█░█▀▀░█▀█░█▀▀░█▀▄░█▀▀░█░█░░░█▀▀░█▀█░█░░░█░█░▀█▀░▀█▀░█▀█░█▀█░█▀▀     (_ o _)\r\n (_,_)      ░█▀▀░█░░░█░█░█▀▀░█░█░█▀▀░█▀▄░█░█░░█░░░░▀▀█░█░█░█░░░█░█░░█░░░█░░█░█░█░█░▀▀█      (_,_) \r\n   _        ░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀░▀▀▀░▀░▀░▀▀▀░░▀░░░░▀▀▀░▀▀▀░▀▀▀░▀▀▀░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀        _   \r\n _( )_                                                                                      _( )_ \r\n(_ o _)                                                                                    (_ o _)\r\n (_,_)                                                                                      (_,_) \r\n   _      _      _      _      _      _      _      _      _      _      _      _      _      _   \r\n _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_ \r\n(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)\r\n (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_) ";
        const string MsgPresentation = "Benvingut al simulador d'energias renovables!\n" + "Creat per Sergio Vegas i EcoEnergy Systems";
        const string MsgMenuExplanation = "A continuació et donarem tres opcions per escollir, introdueix el numero corresponent a l'opció:\n" +
            "1. Iniciar simulació : Configurar un dels nostres sistemes d'energia.\n" +
            "2. Veure els informes de les simulacions fetes.\n" +
            "3. Sortir de la aplicació";
        const string MsgEnergyMenu =  "Pot escollir entre les següents energies, posant el numero corresponent:\n 1.Solar\n 2.Eolica\n 3.Hidraulica.";
        const string MsgSimulationMenu = "Has escollit iniciar una simulació!\n" + "Cuantes simulacions vols fer? Introdueix un nombre enter entre 1 i 100.";
        const string MsgResgistres = "Aquest son els registres de les simulacions fetes.";
        const string MsgOutApp = "Moltes gràcies per participar en la nostra aplicació! :)";
        const string MsgErrorMenu = "Aquest numero no es cap de les opcions.";
        const string MsgNoMoreOption = "La primera opció ja s'ha utilitzat. Si us plau, selecciona una altra opció.\nSi vols fer més simulacions surt i torna a inciar una simulació. ";
        static bool firstOptionUsed = false;

        public static void Main(string[] args)
        {
            string[] arrayRegistres = new string[0];
            bool continueMenu = true;
            Presentation();
            while (continueMenu)
            {
                InitialMenu( ref arrayRegistres, ref continueMenu);
            }
        }
        public static void InitialMenu(ref string[] arrayRegistres, ref bool continueMenu)
        {
            const int MaxRangeSimultions = 100;
            const int MinRangeSimultions = 1;

            Console.WriteLine(MsgMenuExplanation);
            Console.WriteLine();
          
            bool flag = true;
            while (flag)
            {
                int menuNumb = HelperClass.CheckTypeInt();
                Console.WriteLine();
                flag = false;
                switch (menuNumb)
                {
                    case 1:
                        if (firstOptionUsed)
                        {
                            Console.WriteLine(MsgNoMoreOption);
                            flag = true; 
                        }
                        else
                        {
                            firstOptionUsed = true;
                            Console.Clear();
                            Console.WriteLine(MsgSimulationMenu);
                            menuNumb = HelperClass.CheckTypeIntWithRange(MinRangeSimultions, MaxRangeSimultions);
                            SimulationMenu(menuNumb, ref arrayRegistres);
                        }
                        break;
                    case 2:
                        Console.WriteLine(MsgResgistres);
                        PrintRegistres(arrayRegistres);
                        break;
                    case 3:
                        Console.WriteLine(MsgOutApp);
                        continueMenu = false;
                        break;
                    default:
                        Console.WriteLine(MsgErrorMenu);
                        flag = true;
                        break;
                }
            }
        }
        public static void Presentation()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Title);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MsgPresentation);
            Console.WriteLine();

        }
        public static void SimulationMenu(int simulationTry, ref string[] arrayRegistres)
        {
            arrayRegistres = ResizeArrays( ref arrayRegistres,  simulationTry);

            for (int i = 0; i < simulationTry; i++)
            {
                Console.WriteLine(MsgEnergyMenu);
                int menuNumb = HelperClass.CheckTypeInt();
                EnergyMenu(menuNumb, arrayRegistres, i);
                Console.WriteLine();
            }
        }
        public static void EnergyMenu(int menuNumb, string[] arrayRegistres, int contador)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;
                switch (menuNumb)
                {
                    case 1:
                        SolarEnergyAct(contador, ref arrayRegistres);
                        break;
                    case 2:
                        WindEnergyAct(contador, ref arrayRegistres);
                        break;
                    case 3:
                        HidroElectricEnergyAct(contador, ref arrayRegistres);
                        break;
                    default:
                        Console.WriteLine(MsgErrorMenu);
                        flag = true;
                        menuNumb = HelperClass.CheckTypeInt();
                        break;
                }
            }
        }
        public static string[] ResizeArrays(ref string[] arrayString, int newSize)
        {
            Array.Resize(ref arrayString, arrayString.Length + newSize);
            return arrayString;
        }
        public static void PrintRegistres(string[] arrayRegistres)
        {
            const string Lines = "------------------------------------------------------------";
            const string Columns = "|                     |                   |                | \r\n|                     |                   |                |\r\n|                     |                   |                |";
            const string Names = "|         Data        |   Tipus energia   | Calcul Energia | ";

            Console.WriteLine(Lines);
            Console.WriteLine(Names);
            Console.WriteLine(Lines);
            for (int i = 0; i < arrayRegistres.Length; i++)
            {
                Console.WriteLine(arrayRegistres[i]);
            }
            Console.WriteLine(Columns);
            Console.WriteLine(Lines);
        }
        //Funcions on s'instancien els objectes i es fan el cálcul de l'energia i es magatzema.
        public static void HidroElectricEnergyAct(int contador, ref string[] arrayRegistres)
        {
            const string MsgWaterFlow = "Introdueix la força del cabal de l'aigua";
            DateTime actualDate = DateTime.Now;
            double energyCalculated = 0;

            Console.WriteLine(MsgWaterFlow);
            double waterFlow = HelperClass.CheckTypeDouble();
            HidroelectricSystem dam = new HidroelectricSystem(waterFlow, actualDate);
            energyCalculated = Math.Round(dam.CalculateEnergy(waterFlow), 2);
            dam.ShowEnergyCalculated(energyCalculated);
            arrayRegistres[contador] = dam.GetInfoRegistre(actualDate, energyCalculated);
        }
        public static void WindEnergyAct(int contador, ref string[] arrayRegistres)
        {
            const string MsgWindSpeed = "Introdueix la velocitat del vent";
            DateTime actualDate = DateTime.Now;
            double energyCalculated = 0;


            Console.WriteLine(MsgWindSpeed);
            double windVelocity = HelperClass.CheckTypeDouble();
            WindSystem turbine = new WindSystem(windVelocity, actualDate);
            energyCalculated = Math.Round(turbine.CalculateEnergy(windVelocity), 2);
            turbine.ShowEnergyCalculated(turbine.CalculateEnergy(energyCalculated));
            arrayRegistres[contador] = turbine.GetInfoRegistre(actualDate, energyCalculated);
        }
        public static void SolarEnergyAct(int contador, ref string[] arrayRegistres)
        {
            const string MsgSunHours = "Introdueix el numero d'hores de sol, que el sistema utilitzarà.";
            DateTime actualDate = DateTime.Now;
            double energyCalculated = 0;

            Console.WriteLine(MsgSunHours);
            double sunHours = HelperClass.CheckTypeDouble();
            SolarSystem solarSheet = new SolarSystem(sunHours, actualDate);
            energyCalculated = Math.Round(solarSheet.CalculateEnergy(sunHours), 2);
            solarSheet.ShowEnergyCalculated(energyCalculated);
            arrayRegistres[contador] = solarSheet.GetInfoRegistre(actualDate, energyCalculated);
        }
      
    }
}
