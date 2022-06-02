using Jrc.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JRC
{
    public enum JrcOutputFormats
    {
        basic,
        csv,
        json,
        epw
    }

    /**
     * Ova klasa dohvaća meteorološke podatke po parametrima sa JRC (Joint-Research-Centre) servisa.
     * Izrađeno po specifikaciji:
     * https://joint-research-centre.ec.europa.eu/pvgis-photovoltaic-geographical-information-system/getting-started-pvgis/api-non-interactive-service_en
    */
    public class WS
    {
        static HttpClient client = new HttpClient();

        public static async Task<Root> GetDataAsync(string latitude, string longitude, string startYear = "2005", string endYear = "2020", string useHorizon = "1", JrcOutputFormats outputFormat = JrcOutputFormats.json)
        {
            // TODO: CheckParameters();

            string url = PrepareURL(latitude, longitude, startYear, endYear, useHorizon, outputFormat);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Root>(jsonResponse);
        }

        private static string PrepareURL(string latitude, string longitude, string startYear, string endYear, string useHorizon, JrcOutputFormats outputFormat)
        {
            if (startYear.CompareTo("2005") == -1 || endYear.CompareTo("2020") == 1)
            {
                throw new ArgumentException("Problem s JRC web servisom! Godine moraju biti između 2005 i 2020.");
            }
            return $"https://re.jrc.ec.europa.eu/api/v5_2/tmy?lat={latitude}&lon={longitude}&startyear={startYear}&endyear={endYear}&usehorizon={useHorizon}&outputformat={outputFormat}&browser=0";
        }
    }
}
