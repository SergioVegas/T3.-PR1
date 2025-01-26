using System;
using T3._PR1;
using T3.PR1;
using T3._PR1._Pràctica_1.EnegyClass;
namespace T3.PR1
{
    public static class RenovableEnergy
    {
        const string MsgPresentation = "Benvingut al simulador d'energias renovables!\n" + "Creat per Sergio Vegas i EcoEnergy Systems";
        const string MsgMenuExplanation = "A continuació et donarem tres opcions per escollir, introdueix el numero corresponent a l'opció:\n" +
            "1. Iniciar simulació : Configurar un dels nostres sistemes d'energia.\n" +
            "2. Veure els informes de les simulacions fetes.\n" +
            "3. Sortir de la aplicació";
        const string MsgEnergyMenu =  "Pot escollir entre les següents energies, posant el numero corresponent:\n 1.Solar\n 2.Eolica\n 3.Hidraulica.";
        const string MsgSimulationMenu = "Has escollit iniciar una simulació!\n" + "Cuantes simulacions vols fer? Introdueix un nombre enter entre 1 i 100.";
        const string MsgResgistres = "Aquest son els registres de les simulacions fetes.";
        const string MsgOutApp = "Moltes gràcies per participar en la nostra aplicació! :)";
        const string MsgNoNegative = " Aquest numero no pot ser inferior a 0!";
        const string MsgErrorMenu = "Aquest numero no es cap de les opcions.";
        const int MaxRangeSimultions = 100;
        const int MinRangeSimultions = 1;
        public static void Main(string[] args)
        {
            InitialMenu();
        }
        public static void InitialMenu()
        {
            Console.WriteLine(MsgPresentation);
            Console.WriteLine(MsgMenuExplanation);
           
            bool flag = true;
            while (flag)
            {
                int menuNumb = HelperClass.CheckTypeInt();
                flag = false;
                switch (menuNumb)
                {
                    case 1:
                        Console.WriteLine(MsgSimulationMenu);
                        menuNumb = HelperClass.CheckTypeIntWithRange(MinRangeSimultions, MaxRangeSimultions);
                        SimulationMenu(menuNumb);
                        break;
                    case 2:
                        Console.WriteLine(MsgResgistres);
                        break;
                    case 3:
                        Console.WriteLine(MsgOutApp);
                        break;
                    default:
                        Console.WriteLine(MsgErrorMenu);
                        flag = true;
                        break;
                }
            }
        }
        public static void SimulationMenu(int simulationTry)
        {
                for (int i = 0; i < simulationTry; i++)
                {
                    Console.WriteLine(MsgEnergyMenu);
                    int menuNumb = HelperClass.CheckTypeInt();
                    EnergyMenu(menuNumb);
                    Console.WriteLine();
                }  
        }
        public static void EnergyMenu(int menuNumb)
        {
            const string MsgSunHours = "Introdueix el numero d'hores de sol, que el sistema utilitzarà.";
            const string MsgWindSpeed = "Introdueix la velocitat del vent";
            const string MsgWaterFlow = "Introdueix la força del cabal de l'aigua";
            DateTime actualDate = DateTime.Now;
            bool flag = true;


            while (flag)
            {
                flag = false;
                switch (menuNumb)
                {
                    case 1:
                        Console.WriteLine(MsgSunHours);
                        double sunHours = HelperClass.CheckTypeDouble();
                        SolarSystem solarium = new SolarSystem(sunHours, actualDate);
                        solarium.ShowEnergyCalculated(solarium.CalculateEnergy(sunHours));
                        break;
                    case 2:
                        Console.WriteLine(MsgWindSpeed);
                        double windVelocity = HelperClass.CheckTypeDouble();
                        WindSystem wind = new WindSystem(windVelocity, actualDate);
                        wind.ShowEnergyCalculated(wind.CalculateEnergy(windVelocity));
                        break;
                    case 3:
                        Console.WriteLine(MsgWaterFlow);
                        double waterFlow = HelperClass.CheckTypeDouble();
                        HidroelectricSystem presa = new HidroelectricSystem(waterFlow, actualDate);
                        presa.ShowEnergyCalculated(presa.CalculateEnergy(waterFlow));
                        break;
                    default:
                        Console.WriteLine(MsgErrorMenu);
                        flag = true;
                        break;
                }
            }
        }      
    }
}
