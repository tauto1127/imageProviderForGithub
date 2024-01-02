using System.Text.Json;
using QuickType;

namespace imageProviderForGithub.Util;

public class imgbunUtil
{
    private const string IMGBUN_URL = "https://api.imgbun.com/png";

    public static async Task<Uri> GetImgWithText( String text )
    {
        HttpClient httpClient = new HttpClient();
        var res = await httpClient.GetAsync(generateImgbunUri("", text));
        return new Uri(JsonSerializer.Deserialize<ImgbunApiModel>(await res.Content.ReadAsByteArrayAsync())
            .direct_link);
    }

    private static Uri generateImgbunUri(String key, String text)
    {
        String uri = IMGBUN_URL + "?key=" + key + "&text=" + text;
        return new Uri(uri);
    }
}