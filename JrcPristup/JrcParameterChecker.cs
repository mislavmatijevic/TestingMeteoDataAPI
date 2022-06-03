using JRC.Classes;
using System;

namespace JRC
{
    internal class JrcParameterChecker
    {
        public JrcServiceParameters GetParameters(string latitude, string longitude, string startYear, string endYear, string useHorizon, string outputFormat)
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
            if (!CheckYears(startYear, endYear))
            {
                problems += $"Godine 'startYear'=\"{startYear}\" i 'endYear'=\"{endYear}\" nisu u ispravnom obliku! Moraju biti između \"2005\" i \"2020\" te 'endYear' ne može prethoditi 'startYear'! ";
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
                StartYear = startYear,
                EndYear = endYear,
                OutputFormat = outputFormatEnumValue,
                UseHorizon = useHorizon == "0" ? '0' : '1'
            };

            return parameters;
        }

        private bool CheckYears(string startYearString, string endYearString)
        {
            bool valid = false;

            if (int.TryParse(startYearString, out int startYearNumber) && int.TryParse(endYearString, out int endYearNumber))
            {
                if (startYearNumber >= 2005 && startYearNumber <= 2020
                    && endYearNumber >= 2005 && endYearNumber <= 2020
                    && startYearNumber <= endYearNumber)
                {
                    valid = true;
                }
            }

            return valid;
        }
    }
}
