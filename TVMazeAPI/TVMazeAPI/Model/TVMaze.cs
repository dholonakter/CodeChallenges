using Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace TVMazeAPI.Model
{
    public class TVMazeShow
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("person")]
 
        public List<Person> Cast { get; set; }
    }


    public partial class Person
    {
        [JsonProperty("id")]
        public long Id { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("birthday")]
        public DateTimeOffset Birthday { get; set; }
        // Foreign key to TVMazeShow
        public int ShowId { get; set; }
    }

    public class CastInfo
    {
        [JsonProperty("person")]
        public Person Person { get; set; }
    }
}
