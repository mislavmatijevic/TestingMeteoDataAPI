using JRC.Classes;
using System;

namespace JRC
{
    internal class JrcParameterChecker
    {
        public JrcServiceParameters GetParameters(string latitude, string longitude, string useHorizon, string outputFormat)
        {
            string problems = "";
            if (!double.TryParse(latitude, out double latitudeParsed)
                || latitudeParsed < -90.0 && latitudeParsed > 90.0)
            {
                problems += $"Geografska širina {latitude} nije u ispravnom obliku! Mora biti decimalni broj manji od 90 i veći od -90! ";
            }
            if (!double.TryParse(longitude, out double longitudeParsed)
                || longitudeParsed < -180.0 && longitudeParsed > 180.0)
            {
                problems += $"Geografska dužina {longitude} nije u ispravnom obliku! Mora biti decimalni broj manji od 120 i veći od -120! ";
            }

            if (!Enum.TryParse(outputFormat, out JrcOutputFormats outputFormatEnumValue))
            {
                problems += $"Format za dohvat podataka \"{outputFormat}\" nije u ispravnom obliku! Prihvaćaju se:";
                foreach (var format in Enum.GetValues(typeof(JrcOutputFormats)))
                {
                    problems += " \"" + format.ToString() + "\"";
                }
            }

            if (problems != "")
            {
                throw new ArgumentException(problems);
            }

            JrcServiceParameters parameters = new JrcServiceParameters()
            {
                Latitude = latitudeParsed,
                Longitude = longitudeParsed,
                OutputFormat = outputFormatEnumValue,
                UseHorizon = useHorizon == "0" ? '0' : '1'
            };

            return parameters;
        }
    }
}
