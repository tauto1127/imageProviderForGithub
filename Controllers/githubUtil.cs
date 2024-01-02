using System;
using System.Text.Json;
using imageProviderForGithub.Model;

namespace imageProviderForGithub.Controllers;

public class GithubUtil
{
    private const String ApiUrl = "https://github-contributions-api.deno.dev/tauto1127.json";

    public static GithubContributionsApiResult? getContributions(string username)
    {
        string jsonStr = @"{
    ""contributions"": [
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-07""
            }
        ],
    ],
    ""totalContributions"": 521
}";
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        return JsonSerializer.Deserialize<GithubContributionsApiResult>(jsonStr, options);
    }
}