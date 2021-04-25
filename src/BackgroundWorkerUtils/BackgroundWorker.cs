using Microsoft.Windows.Sdk;
using BackgroundProviderUtils;
namespace BackgroundWorkerUtils
{
    class BackgroundWorker
    {
        public static bool changeBackground(IBackgroundProvider provider)
        {
            var file = provider.getBackground();
            var result = false;
            unsafe
            {
                fixed (char* val = file)
                {
                    result = PInvoke.SystemParametersInfo(
                        SYSTEM_PARAMETERS_INFO_ACTION.SPI_SETDESKWALLPAPER,
                        0,
                        val,
                        SystemParametersInfo_fWinIni.SPIF_UPDATEINIFILE | SystemParametersInfo_fWinIni.SPIF_SENDCHANGE);
                }
            }
            return result;
        }
    }







}
