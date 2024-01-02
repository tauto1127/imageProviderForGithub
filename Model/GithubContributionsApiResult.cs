using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace imageProviderForGithub.Model;

public class GithubContributionsApiResult
{
    public List<List<Contribution>> contributions { get; set; }
    public int totalContributions { get; set; }

    [JsonConstructor]
    public GithubContributionsApiResult(List<Contribution> contributions, int totalContributions)
    {
        contributions = contributions;
        totalContributions = totalContributions;
    }
}