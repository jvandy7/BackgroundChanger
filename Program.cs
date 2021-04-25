using BackgroundProviderUtils;
using BackgroundWorkerUtils;
namespace BackgroundChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            // BackgroundWorker.changeBackground(BackgroundProviderFactory.getBackgroundProvider(Provider.STATIC));
            BackgroundWorker.changeBackground(BackgroundProviderFactory.getBackgroundProvider(Provider.APOD));
        }
    }
}
