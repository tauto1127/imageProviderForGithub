using System;
using System.Text.Json;
using QuickType;

namespace imageProviderForGithub.Controllers;

public class GithubUtil
{
    private const String ApiUrl = "https://github-contributions-api.deno.dev/tauto1127.json";

    public static Temperatures? getContributions(string username)
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
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-13""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-14""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-15""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-21""
            }
        ],
        [
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-01-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-25""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-28""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-29""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-01-31""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-04""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-11""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-13""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-14""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-15""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-18""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-25""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-02-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-01""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-03-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-04""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-11""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-13""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-14""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-15""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-18""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-20""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 3,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-03-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-23""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 3,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-03-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-25""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-29""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-03-31""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-01""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-08""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-13""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-14""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-15""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-22""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-25""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-29""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-04-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-06""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-07""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-05-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-13""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-14""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-15""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-20""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-25""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-27""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-29""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-05-31""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-03""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-10""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-13""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-06-14""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-15""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-17""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-24""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-25""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-29""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-06-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-01""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-08""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-13""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-14""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-07-15""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-22""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-25""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-29""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-07-31""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-05""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-12""
            }
        ],
        [
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 4,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-13""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 12,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-08-14""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 6,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-15""
            },
            {
                ""color"": ""#216e39"",
                ""contributionCount"": 34,
                ""contributionLevel"": ""FOURTH_QUARTILE"",
                ""date"": ""2023-08-16""
            },
            {
                ""color"": ""#216e39"",
                ""contributionCount"": 39,
                ""contributionLevel"": ""FOURTH_QUARTILE"",
                ""date"": ""2023-08-17""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 14,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-08-18""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-19""
            }
        ],
        [
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 10,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-08-20""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 4,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-21""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 3,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-22""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 11,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-08-23""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-24""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 3,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-25""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-26""
            }
        ],
        [
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 3,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-28""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 8,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-08-29""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-08-30""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-08-31""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-01""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-09-02""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-03""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 15,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-09-04""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 4,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-09-05""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-09-06""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 4,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-09-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-08""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 4,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-09-09""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-10""
            },
            {
                ""color"": ""#30a14e"",
                ""contributionCount"": 16,
                ""contributionLevel"": ""THIRD_QUARTILE"",
                ""date"": ""2023-09-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-13""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 10,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-09-14""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 8,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-09-15""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 11,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-09-16""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-23""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-25""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-29""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-09-30""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-07""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-11""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-12""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-13""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-14""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-15""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-21""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-22""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 7,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-10-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-24""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-10-25""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-10-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-28""
            }
        ],
        [
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 11,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-10-29""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 5,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-10-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-10-31""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-02""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-03""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-04""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-05""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-11-06""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-07""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-08""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-09""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-10""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-11""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-12""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 5,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-11-13""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-14""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-15""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-16""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-18""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-20""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-23""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-24""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-25""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-27""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-28""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-29""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-11-30""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-01""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-02""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-03""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-04""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-05""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-06""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 3,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-07""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-08""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-09""
            }
        ],
        [
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 12,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2023-12-10""
            },
            {
                ""color"": ""#30a14e"",
                ""contributionCount"": 20,
                ""contributionLevel"": ""THIRD_QUARTILE"",
                ""date"": ""2023-12-11""
            },
            {
                ""color"": ""#216e39"",
                ""contributionCount"": 24,
                ""contributionLevel"": ""FOURTH_QUARTILE"",
                ""date"": ""2023-12-12""
            },
            {
                ""color"": ""#216e39"",
                ""contributionCount"": 28,
                ""contributionLevel"": ""FOURTH_QUARTILE"",
                ""date"": ""2023-12-13""
            },
            {
                ""color"": ""#216e39"",
                ""contributionCount"": 39,
                ""contributionLevel"": ""FOURTH_QUARTILE"",
                ""date"": ""2023-12-14""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 6,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-15""
            },
            {
                ""color"": ""#216e39"",
                ""contributionCount"": 31,
                ""contributionLevel"": ""FOURTH_QUARTILE"",
                ""date"": ""2023-12-16""
            }
        ],
        [
            {
                ""color"": ""#30a14e"",
                ""contributionCount"": 19,
                ""contributionLevel"": ""THIRD_QUARTILE"",
                ""date"": ""2023-12-17""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-18""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-19""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-20""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-21""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-22""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-23""
            }
        ],
        [
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-24""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-25""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 1,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-26""
            },
            {
                ""color"": ""#ebedf0"",
                ""contributionCount"": 0,
                ""contributionLevel"": ""NONE"",
                ""date"": ""2023-12-27""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 4,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-28""
            },
            {
                ""color"": ""#216e39"",
                ""contributionCount"": 28,
                ""contributionLevel"": ""FOURTH_QUARTILE"",
                ""date"": ""2023-12-29""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 6,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-30""
            }
        ],
        [
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 4,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2023-12-31""
            },
            {
                ""color"": ""#9be9a8"",
                ""contributionCount"": 2,
                ""contributionLevel"": ""FIRST_QUARTILE"",
                ""date"": ""2024-01-01""
            },
            {
                ""color"": ""#40c463"",
                ""contributionCount"": 11,
                ""contributionLevel"": ""SECOND_QUARTILE"",
                ""date"": ""2024-01-02""
            }
        ]
    ],
    ""totalContributions"": 521
}";
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        return JsonSerializer.Deserialize<Temperatures>(jsonStr, options);
    }
}