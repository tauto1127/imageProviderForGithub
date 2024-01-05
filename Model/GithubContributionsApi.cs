using Newtonsoft.Json;

namespace imageProviderForGithub.Model
{
    public class GithubContributionApi
    {
        [JsonProperty("contributions")]
        public Contribution[][] Contributions { get; set; }

        [JsonProperty("totalContributions")]
        public long TotalContributions { get; set; }
    }

    public class Contribution
    {
        [JsonProperty("color")]
        public String Color { get; set; }

        [JsonProperty("contributionCount")]
        public int ContributionCount { get; set; }

        [JsonProperty("contributionLevel")]
        public String ContributionLevel { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
    }

    /*
        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    ColorConverter.Singleton,
                    ContributionLevelConverter.Singleton,
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
            };
        }

        internal class ColorConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => true;

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                return value;
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                throw new Exception("Cannot marshal type Color");
            }

            public static readonly ColorConverter Singleton = new ColorConverter();
        }

        internal class ContributionLevelConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => true;

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                var value = serializer.Deserialize<string>(reader);
                return value;
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                throw new Exception("Cannot marshal type ContributionLevel");
            }

            public static readonly ContributionLevelConverter Singleton = new ContributionLevelConverter();
        }*/
}
