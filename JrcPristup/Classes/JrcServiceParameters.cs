namespace JRC.Classes
{
    internal class JrcServiceParameters
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public char UseHorizon { get; set; }
        public JrcOutputFormats OutputFormat { get; set; }
    }
}
