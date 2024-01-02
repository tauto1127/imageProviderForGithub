using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using QuickType;


namespace imageProviderForGithub.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ImageController : ControllerBase
    {
        [HttpGet]
        //[Produces("image/png")]
        public async Task<ActionResult> GetImage()
        {
            var result = await loadImageFromURL(
                new Uri("https://takutk.com/obs/1704169758324.jpg")
            );
            Response.Headers["Cache-Control"] = "no-cache";

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

        [HttpGet]
        public async Task<String> getStreakImg()
        {
            return "";
        }
    }
}
