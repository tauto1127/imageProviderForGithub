using System;
using System.Text.Json.Serialization;

namespace imageProviderForGithub.Model;

public class Contribution
{
    public string color { get; set; }
    public int contributionCount { get; set; }
    public string contributionLevel { get; set; }
    public DateTime date { get; set; }

    /*
    [JsonConstructor]
    public Contribution(String color, int contributionCount, String contributionLevel, String date)
    {
        color = color;
        contributionCount = contributionCount;
        contributionLevel = contributionLevel;
        date = date;
    }*/
}