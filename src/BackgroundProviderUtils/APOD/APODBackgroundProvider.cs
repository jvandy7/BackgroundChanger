using System.IO;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BackgroundProviderUtils
{
    public class APODBackgroundProvider : HttpBackgroundProvider
    {
        static readonly string background = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\background\background.jpg";
        static readonly string api = "https://api.nasa.gov/planetary/apod";
        static readonly string imageType = "image";

        private class APOD
        {
            public string media_type { get; set; }
            public string hdurl { get; set; }
        }


        public override string getBackground()
        {
            // TODO catch exceptions
            var apod = getJSON().Result;

            if (apod.media_type == imageType)
            {
                getFile(apod).Wait();
            }

            return Path.GetFullPath(background);
        }

        private async Task<APOD> getJSON()
        {
            // TODO catch exceptions
            var uri = new StringBuilder().Append(api).Append("?api_key=").Append(APODApiKey.key).ToString();
            var jsonTask = await client.GetFromJsonAsync<APOD>(uri).ConfigureAwait(false);
            return jsonTask;
        }

        private async Task getFile(APOD apod)
        {
            //TODO catch exceptions
            using (var file = await client.GetStreamAsync(apod.hdurl).ConfigureAwait(false))
            using (var fileStream = File.Create(background))
            { await file.CopyToAsync(fileStream); await fileStream.FlushAsync();}
        }
    }
}