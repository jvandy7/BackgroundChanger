using System;
using System.IO;

namespace BackgroundProviderUtils
{
    public class StaticBackgroundProvider : IBackgroundProvider
    {
        public string getBackground()
        {
            //TODO catch exceptions
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\background");
            return files[new Random().Next(0, files.Length)];
        }
    }
}