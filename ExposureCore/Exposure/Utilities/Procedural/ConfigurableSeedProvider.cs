using Exposure.Contracts;

namespace Exposure.Utilities.Procedural
{
    public class ConfigurableSeedProvider : BaseSeedProvider
    {
        public ConfigurableSeedProvider(int seedLength) : base(seedLength)
        {
        }
    }
}