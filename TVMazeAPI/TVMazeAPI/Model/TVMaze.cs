using Newtonsoft.Json;

namespace TVMazeAPI.Model
{
    public class TVMazeShow
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public List<Person> Cast { get; set; }
    }

    public class Person
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        // Add other properties with [JsonProperty] attributes
    }

    public class CastInfo
    {
        [JsonProperty("person")]
        public Person Person { get; set; }
    }
}
