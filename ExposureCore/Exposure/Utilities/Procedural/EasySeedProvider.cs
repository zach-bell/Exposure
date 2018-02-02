using Exposure.Contracts;
using UnityEngine;

namespace Exposure.Utilities.Procedural
{
    public class EasySeedProvider : BaseSeedProvider
    {
        private static int seedLength = 30;

        public EasySeedProvider():base(seedLength)
        {
        }
    }
}