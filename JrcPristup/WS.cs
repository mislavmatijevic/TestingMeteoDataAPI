using JRC.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public static async Task<JrcResponse> GetDataAsync(string cityName, string useHorizon = "1", string outputFormat = "json")
        {
            string urlLatLong = PrepareOpenWeatherMapURL(cityName);
                
            string owmJsonResponse = await getResponseAsJson(urlLatLong);
            var owmResponse = JsonConvert.DeserializeObject<List<OpenWeatherMapResponse>>(owmJsonResponse)[0];

            JrcParameterChecker parameterChecker = new JrcParameterChecker();
            JrcServiceParameters parameters = parameterChecker.GetParameters(owmResponse.Lat, owmResponse.Lon, useHorizon, outputFormat);

            string urlJrc = PrepareJrcURL(parameters);
            string jrcJsonResponse = await getResponseAsJson(urlJrc);
            return JsonConvert.DeserializeObject<JrcResponse>(jrcJsonResponse);
        }

        private static string PrepareOpenWeatherMapURL(string cityName)
        {
            return $"http://api.openweathermap.org/geo/1.0/direct?q={cityName}&appid={Environment.GetEnvironmentVariable("OpenWeatherMapApiKey")}";
        }

        private static string PrepareJrcURL(JrcServiceParameters parameters)
        {
            return $"https://re.jrc.ec.europa.eu/api/v5_2/tmy?lat={parameters.Latitude}&lon={parameters.Longitude}&usehorizon={parameters.UseHorizon}&outputformat={parameters.OutputFormat}&browser=0";
        }

        private static async Task<string> getResponseAsJson(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
