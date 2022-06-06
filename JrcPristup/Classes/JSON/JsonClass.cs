using Newtonsoft.Json;

namespace JrcPristup.Classes.JSON
{
    public class JsonClass
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
