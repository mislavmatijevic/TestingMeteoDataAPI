using Jrc.Classes;
using JRC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Root root;
            try
            {
                root = PoveziSeNaWebServis(coordinates).GetAwaiter().GetResult();
            }
            catch
            {
                Console.WriteLine("Neuspješan dohvat podataka!");
                return;
            }

            Console.WriteLine(
                "elevation:\t\t" + root.Inputs.Location.Elevation + "\n" +
                "radiation_db:\t\t" + root.Inputs.MeteoData.RadiationDb+ "\n"
            );

            Console.WriteLine("Pritisnuti bilo što za nastavak...");
            Console.ReadKey();
        }

        private static async Task<Root> PoveziSeNaWebServis(string[] coordinates)
        {
            return await WS.GetDataAsync(coordinates[0], coordinates[1]);
        }
    }
}
