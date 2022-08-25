using JRC.Classes;
using JRC.Exceptions;
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
        static string openWeatherMapApiKey = null;

        public static async Task<JrcResponse> GetDataAsync(string cityName, string useHorizon = "1", string outputFormat = "json")
        {
            openWeatherMapApiKey = Environment.GetEnvironmentVariable("OpenWeatherMapApiKey");
            if (openWeatherMapApiKey is null)
            {
                throw new ApiKeyNotSetException("API ključ za OpenWeatherMap nije definiran u Enviroment varijablama pod ključem 'OpenWeatherMapApiKey'!");
            }

            string urlLatLong = PrepareOpenWeatherMapURL(cityName);
            OpenWeatherMapResponse owmResponse = null;
            try
            {
                string owmJsonResponse = await getResponseAsJson(urlLatLong);
                owmResponse = JsonConvert.DeserializeObject<List<OpenWeatherMapResponse>>(owmJsonResponse)[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new LocationNotValidException($"Lokacija '{cityName}' ne čini se ispravnom.");
            }

            JrcParameterChecker parameterChecker = new JrcParameterChecker();
            JrcServiceParameters parameters = parameterChecker.GetParameters(owmResponse.Lat, owmResponse.Lon, useHorizon, outputFormat);

            string urlJrc = PrepareJrcURL(parameters);
            string jrcJsonResponse = await getResponseAsJson(urlJrc);
            return JsonConvert.DeserializeObject<JrcResponse>(jrcJsonResponse);
        }

        private static string PrepareOpenWeatherMapURL(string cityName)
        {
            return $"http://api.openweathermap.org/geo/1.0/direct?q={cityName}&appid={openWeatherMapApiKey}";
        }

        private static string PrepareJrcURL(JrcServiceParameters parameters)
        {
            return $"https://re.jrc.ec.europa.eu/api/v5_2/tmy?lat={parameters.Latitude}&lon={parameters.Longitude}&usehorizon={parameters.UseHorizon}&outputformat={parameters.OutputFormat}&browser=0";
        }

        private static async Task<string> getResponseAsJson(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            return await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync();
        }
    }
}
