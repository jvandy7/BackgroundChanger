using System.IO;
using System.Reflection;
namespace BackgroundProviderUtils
{
    public static class APODApiKey
    {
        public static readonly string key = getKey();
        private static string getKey()
        {
            //TODO catch exceptions
            StreamReader sr = new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\APODApiKey.txt");
            return sr.ReadLine();
        }
    }
}