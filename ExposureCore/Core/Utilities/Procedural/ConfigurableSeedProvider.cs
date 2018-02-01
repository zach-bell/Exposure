using Core.Contracts;

namespace Core.Utilities.Procedural
{
    public class ConfigurableSeedProvider : BaseSeedProvider
    {
        public ConfigurableSeedProvider(int seedLength) : base(seedLength)
        {
        }
    }
}