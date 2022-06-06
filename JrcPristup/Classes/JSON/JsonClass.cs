using Newtonsoft.Json;

namespace JRC.Classes
{
    public class JsonClass
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
