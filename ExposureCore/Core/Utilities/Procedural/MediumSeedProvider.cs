using Core.Contracts;
namespace Core.Utilities.Procedural
{
    public class MediumSeedProvider : BaseSeedProvider
    {
        private static int seedLength = 150;

        public MediumSeedProvider():base(seedLength)
        {
        }
    }
}