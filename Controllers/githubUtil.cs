using System;
using System.Text.Json;
using imageProviderForGithub.Model;

namespace imageProviderForGithub.Controllers;

public class GithubUtil
{
    private const String ApiUrl = "https://github-contributions-api.deno.dev/";
    private const String ExtensionResponse = ".json";

    private GithubContributionApi _githubContributionApi = null!;
    private String userName;

    private GithubUtil(String username)
    {
        userName = username;
    }

    private async Task getContributions()
    {
        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync(new Uri(ApiUrl + userName + ExtensionResponse));
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
        GithubUtil githubUtil = new GithubUtil(username);
        await githubUtil.getContributions();
        return githubUtil;
    }
}