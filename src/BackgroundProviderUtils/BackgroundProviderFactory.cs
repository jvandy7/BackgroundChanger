using System;
using System.Collections.Generic;
namespace BackgroundProviderUtils
{
    public enum Provider
    {
        STATIC,
        APOD
    }
    class BackgroundProviderFactory
    {

        public static IDictionary<Provider, Func<IBackgroundProvider>> providers =
            new Dictionary<Provider, Func<IBackgroundProvider>>()
            {
                { Provider.STATIC, () => new StaticBackgroundProvider() },
                { Provider.APOD, () => new APODBackgroundProvider() }
            };
        public static IBackgroundProvider getBackgroundProvider(Provider providerType)
        {
            return providers[providerType]();
        }
    }
}