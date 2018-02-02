using Exposure.Structures;

namespace Exposure.Utilities.Settings
{
    public class SettingsService
    {
        private static SettingsService singleInstance = null;
        
        //the below will be replaced with something that fetches data from disk
        public Difficulty Difficulty = Difficulty.Hard;

        private SettingsService()
        {
        }

        public static SettingsService GetInstance()
        {
            singleInstance = singleInstance ?? new SettingsService();
            return singleInstance;
        }
    }
}