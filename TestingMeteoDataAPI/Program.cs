using JRC.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TestingMeteoDataAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoadEnvFile(".env");

            Console.WriteLine("Unesite grad:");
            string unos = Console.ReadLine();
            Console.WriteLine("Pričekajte...");

            JrcResponse root = null;
            try
            {
                root = PoveziSeNaWebServis(unos).GetAwaiter().GetResult();
                Console.WriteLine(
                    "elevation:\t\t" + root.Inputs.Location.Elevation + "\n" +
                    "radiation_db:\t\t" + root.Inputs.MeteoData.RadiationDb + "\n"
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Neuspješan dohvat podataka! " + ex.Message);
            }

            if (root != null)
            {
                bool izlaz = false;
                while (!izlaz)
                {
                    PrikaziMeni();
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1':
                            List<TmyHourly> meteoPodaciPoSatimaGodine = root.Outputs.TmyHourly;


                            Console.WriteLine($"Unesite broj odabranog sata u godini (0-{meteoPodaciPoSatimaGodine.Count - 1}) za podatke tipične meteorološke godine, -1 za prekid: ");

                            int index;
                            while (int.TryParse(Console.ReadLine(), out index) && index != -1)
                            {
                                if (index < meteoPodaciPoSatimaGodine.Count)
                                {
                                    Console.WriteLine(meteoPodaciPoSatimaGodine[index].ToString());
                                }
                            }
                            break;
                        case 'x':
                            izlaz = true;
                            break;
                    }
                }
            }

            Console.WriteLine("Pritisnuti bilo što za nastavak...");
            Console.ReadKey();
        }

        private static async Task<JrcResponse> PoveziSeNaWebServis(string grad)
        {
            return await JRC.WS.GetDataAsync(grad);
        }

        private static void PrikaziMeni()
        {
            Console.WriteLine("1 - odabir podataka po danu u godini");
            Console.WriteLine("x - izlaz");
        }

        private static void LoadEnvFile(string envFilePath)
        {
            var envLines = File.ReadLines(envFilePath);
            foreach (var line in envLines)
            {
                var keyValuePair = line.Split('=');
                if (keyValuePair.Length == 2)
                {
                    Environment.SetEnvironmentVariable(keyValuePair[0], keyValuePair[1]);
                }
            }

        }
    }
}
