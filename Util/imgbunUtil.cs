using System.Text.Json;
using imageProviderForGithub.Model;

namespace imageProviderForGithub.Util;

public class imgbunUtil
{
    private const string IMGBUN_URL = "https://api.imgbun.com/png";

    public static async Task<Uri> GetImgWithText(String key, String text)
    {
        HttpClient httpClient = new HttpClient();
        var res = await httpClient.GetAsync(generateImgbunUri(key: key, text: text));
        return new Uri(JsonSerializer.Deserialize<ImgbunApiModel>(await res.Content.ReadAsByteArrayAsync())
            .direct_link);
    }

    private static Uri generateImgbunUri(String key, String text)
    {
        String uri = IMGBUN_URL + "?key=" + key + "&text=" + text + "&background=FFFFFF" + "&color=FF0000";
        return new Uri(uri);
    }
}
