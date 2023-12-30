using System.Drawing;
using System.Net;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;


namespace imageProviderForGithub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        [HttpGet]
        //[Produces("image/png")]
        public async Task<ActionResult> GetImage()
        {
            var result = await loadImageFromURL(
                new Uri("https://takutk.com/obs/img/class/%e3%82%bd%e3%83%95%e3%83%88%e3%82%a6%e3%82%a7%e3%82%a2%e8%a8%ad%e8%a8%88%e8%ab%9611%e5%9b%9e%e7%9b%ae%e5%87%ba%e5%b8%ad%e7%a2%ba%e8%aa%8d.png")
            );
            
            Console.WriteLine(await result.Content.ReadAsByteArrayAsync());
            return base.File(await result.Content.ReadAsByteArrayAsync(), "image/png");
            //return await result.Content.ReadAsByteArrayAsync();
        }

        private static async Task<HttpResponseMessage> loadImageFromURL( Uri url )
        {
            var client = new HttpClient()
            {
                BaseAddress = url
            };
            return await client.GetAsync("");
        }
    }
}