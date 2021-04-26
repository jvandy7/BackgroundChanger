using System;
using System.IO;
using System.Reflection;

namespace BackgroundProviderUtils
{
    public class StaticBackgroundProvider : IBackgroundProvider
    {
        public string getBackground()
        {
            //TODO catch exceptions
            string[] files = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\background");
            return files[new Random().Next(0, files.Length)];
        }
    }
}