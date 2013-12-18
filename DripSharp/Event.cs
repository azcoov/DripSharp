using Newtonsoft.Json;

namespace DripSharp
{
    public class Event
    {
        [JsonProperty("event")]
        public string _event { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("object")]
        public dynamic Object { get; set; }
    }
}
