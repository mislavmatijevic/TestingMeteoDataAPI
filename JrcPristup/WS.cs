using JRC.Classes;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace JRC
{
    internal enum JrcOutputFormats
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

        public static async Task<JrcResponse> GetDataAsync(string latitude, string longitude, string useHorizon = "1", string outputFormat = "json")
        {
            JrcParameterChecker parameterChecker = new JrcParameterChecker();
            JrcServiceParameters parameters = parameterChecker.GetParameters(latitude, longitude, useHorizon, outputFormat);

            string url = PrepareURL(parameters);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<JrcResponse>(jsonResponse);
        }

        private static string PrepareURL(JrcServiceParameters parameters)
        {
            return $"https://re.jrc.ec.europa.eu/api/v5_2/tmy?lat={parameters.Latitude}&lon={parameters.Longitude}&usehorizon={parameters.UseHorizon}&outputformat={parameters.OutputFormat}&browser=0";
        }
    }
}
