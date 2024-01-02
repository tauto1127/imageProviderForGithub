using System;
using System.Text.Json;
using imageProviderForGithub.Model;

namespace imageProviderForGithub.Controllers;

public class GithubUtil
{
    private const String ApiUrl = "https://github-contributions-api.deno.dev/tauto1127.json";
    private GithubContributionApi _githubContributionApi = null!;

    private GithubUtil() { }

    private async Task getContributions()
    {
        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync(new Uri(ApiUrl));
        string str = await response.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        _githubContributionApi = JsonSerializer.Deserialize<GithubContributionApi>(str, options);
    }

    public int GetStreak()
    {
        int streak = 0;
        bool flag = false;
        
        for (int i = _githubContributionApi.Contributions.Length - 1; i >= 0; i--)
        {
            if (flag)
            {
                break;
            }
            for (int j = _githubContributionApi.Contributions[i].Length - 1; j >= 0; j--)
            {
                Console.WriteLine(_githubContributionApi.Contributions[i][j].Date);
                if (_githubContributionApi.Contributions[i][j].ContributionCount > 0)
                {
                    streak++;
                }
                else
                {
                    flag = true;
                    break;
                }
            }
        }

        return streak;
    }

    //ファクトリー
    public static async Task<GithubUtil> getGithubUtil(string username)
    {
        GithubUtil githubUtil = new GithubUtil();
        await githubUtil.getContributions();
        return githubUtil;
    }
}