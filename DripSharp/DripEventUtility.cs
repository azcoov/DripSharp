using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DripSharp
{
    public static class DripEventUtility
    {
        public static Event Parse(string json)
        {
            return Mapper<Event>.MapFromJson(json);
        }
    }
}
