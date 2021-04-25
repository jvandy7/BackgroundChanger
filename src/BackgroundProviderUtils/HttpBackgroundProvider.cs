using System.Net.Http;
namespace BackgroundProviderUtils
{
    public abstract class HttpBackgroundProvider : IBackgroundProvider
    {
        protected static readonly HttpClient client = new HttpClient();
        public abstract string getBackground();

    }
}