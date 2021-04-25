using System.IO;
namespace BackgroundProviderUtils
{
    public static class APODApiKey
    {
        public static readonly string key = getKey();
        private static string getKey()
        {
            //TODO catch exceptions
            StreamReader sr = new StreamReader(@"APODApiKey.txt");
            return sr.ReadLine();
        }
    }
}