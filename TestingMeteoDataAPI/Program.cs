using JRC.Classes;
using System;
using System.Threading.Tasks;

namespace TestingMeteoDataAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite lokaciju ( lat-long ):");
            string unos = Console.ReadLine();
            string[] coordinates = unos.Split('-');
            Console.WriteLine("Pričekajte...");

            Root root = null;
            try
            {
                root = PoveziSeNaWebServis(coordinates).GetAwaiter().GetResult();
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
                Console.WriteLine($"Odaberite sat u tipičnoj meteorološkoj godini (0-{root.Outputs.TmyHourly.Count}): ");
                int index;
                while ((index = int.Parse(Console.ReadLine())) != 0)
                {
                    Console.WriteLine(root.Outputs.TmyHourly[index].ToString());
                }
            }

            Console.WriteLine("Pritisnuti bilo što za nastavak...");
            Console.ReadKey();
        }

        private static async Task<Root> PoveziSeNaWebServis(string[] coordinates)
        {
            return await JRC.WS.GetDataAsync(coordinates[0], coordinates[1]);
        }
    }
}
