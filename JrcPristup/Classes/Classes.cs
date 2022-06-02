using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jrc.Classes
{
    public class Azimuth
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("optimal")]
        public bool Optimal { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class EconomicData
    {
        [JsonProperty("system_cost")]
        public object SystemCost { get; set; }

        [JsonProperty("interest")]
        public object Interest { get; set; }

        [JsonProperty("lifetime")]
        public object Lifetime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("variables")]
        public Variables Variables { get; set; }
    }

    public class ED
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Elevation
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class EM
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class EY
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Fields
    {
        [JsonProperty("slope")]
        public Slope Slope { get; set; }

        [JsonProperty("azimuth")]
        public Azimuth Azimuth { get; set; }
    }

    public class Fixed
    {
        [JsonProperty("slope")]
        public Slope Slope { get; set; }

        [JsonProperty("azimuth")]
        public Azimuth Azimuth { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("E_d")]
        public double ED { get; set; }

        [JsonProperty("E_m")]
        public double EM { get; set; }

        [JsonProperty("H(i)_d")]
        public double HID { get; set; }

        [JsonProperty("H(i)_m")]
        public double HIM { get; set; }

        [JsonProperty("SD_m")]
        public double SDM { get; set; }

        [JsonProperty("E_y")]
        public double EY { get; set; }

        [JsonProperty("H(i)_y")]
        public double HIY { get; set; }

        [JsonProperty("SD_y")]
        public double SDY { get; set; }

        [JsonProperty("l_aoi")]
        public double LAoi { get; set; }

        [JsonProperty("l_spec")]
        public string LSpec { get; set; }

        [JsonProperty("l_tg")]
        public double LTg { get; set; }

        [JsonProperty("l_total")]
        public double LTotal { get; set; }
    }

    public class HID
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class HIM
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class HIY
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class HorizonDb
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Inputs
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("meteo_data")]
        public MeteoData MeteoData { get; set; }

        [JsonProperty("mounting_system")]
        public MountingSystem MountingSystem { get; set; }

        [JsonProperty("pv_module")]
        public PvModule PvModule { get; set; }

        [JsonProperty("economic_data")]
        public EconomicData EconomicData { get; set; }
    }

    public class Interest
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class LAoi
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Latitude
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Lifetime
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Location
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("variables")]
        public Variables Variables { get; set; }
    }

    public class Longitude
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class LSpec
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class LTg
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class LTotal
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Meta
    {
        [JsonProperty("inputs")]
        public Inputs Inputs { get; set; }

        [JsonProperty("outputs")]
        public Outputs Outputs { get; set; }
    }

    public class MeteoData
    {
        [JsonProperty("radiation_db")]
        public string RadiationDb { get; set; }

        [JsonProperty("meteo_db")]
        public string MeteoDb { get; set; }

        [JsonProperty("year_min")]
        public int YearMin { get; set; }

        [JsonProperty("year_max")]
        public int YearMax { get; set; }

        [JsonProperty("use_horizon")]
        public bool UseHorizon { get; set; }

        [JsonProperty("horizon_db")]
        public string HorizonDb { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("variables")]
        public Variables Variables { get; set; }
    }

    public class MeteoDb
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Monthly
    {
        [JsonProperty("fixed")]
        public List<Fixed> Fixed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("variables")]
        public Variables Variables { get; set; }
    }

    public class MountingSystem
    {
        [JsonProperty("fixed")]
        public Fixed Fixed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("choices")]
        public string Choices { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }
    }

    public class Outputs
    {
        [JsonProperty("monthly")]
        public Monthly Monthly { get; set; }

        [JsonProperty("totals")]
        public Totals Totals { get; set; }
    }

    public class PeakPower
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class PvModule
    {
        [JsonProperty("technology")]
        public string Technology { get; set; }

        [JsonProperty("peak_power")]
        public double PeakPower { get; set; }

        [JsonProperty("system_loss")]
        public double SystemLoss { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("variables")]
        public Variables Variables { get; set; }
    }

    public class RadiationDb
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SDM
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class SDY
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Slope
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("optimal")]
        public bool Optimal { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class SystemCost
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class SystemLoss
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Technology
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Totals
    {
        [JsonProperty("fixed")]
        public Fixed Fixed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("variables")]
        public Variables Variables { get; set; }
    }

    public class UseHorizon
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Variables
    {
        [JsonProperty("latitude")]
        public Latitude Latitude { get; set; }

        [JsonProperty("longitude")]
        public Longitude Longitude { get; set; }

        [JsonProperty("elevation")]
        public Elevation Elevation { get; set; }

        [JsonProperty("radiation_db")]
        public RadiationDb RadiationDb { get; set; }

        [JsonProperty("meteo_db")]
        public MeteoDb MeteoDb { get; set; }

        [JsonProperty("year_min")]
        public YearMin YearMin { get; set; }

        [JsonProperty("year_max")]
        public YearMax YearMax { get; set; }

        [JsonProperty("use_horizon")]
        public UseHorizon UseHorizon { get; set; }

        [JsonProperty("horizon_db")]
        public HorizonDb HorizonDb { get; set; }

        [JsonProperty("technology")]
        public Technology Technology { get; set; }

        [JsonProperty("peak_power")]
        public PeakPower PeakPower { get; set; }

        [JsonProperty("system_loss")]
        public SystemLoss SystemLoss { get; set; }

        [JsonProperty("system_cost")]
        public SystemCost SystemCost { get; set; }

        [JsonProperty("interest")]
        public Interest Interest { get; set; }

        [JsonProperty("lifetime")]
        public Lifetime Lifetime { get; set; }

        [JsonProperty("E_d")]
        public ED ED { get; set; }

        [JsonProperty("E_m")]
        public EM EM { get; set; }

        [JsonProperty("H(i)_d")]
        public HID HID { get; set; }

        [JsonProperty("H(i)_m")]
        public HIM HIM { get; set; }

        [JsonProperty("SD_m")]
        public SDM SDM { get; set; }

        [JsonProperty("E_y")]
        public EY EY { get; set; }

        [JsonProperty("H(i)_y")]
        public HIY HIY { get; set; }

        [JsonProperty("SD_y")]
        public SDY SDY { get; set; }

        [JsonProperty("l_aoi")]
        public LAoi LAoi { get; set; }

        [JsonProperty("l_spec")]
        public LSpec LSpec { get; set; }

        [JsonProperty("l_tg")]
        public LTg LTg { get; set; }

        [JsonProperty("l_total")]
        public LTotal LTotal { get; set; }
    }

    public class YearMax
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class YearMin
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }


}
