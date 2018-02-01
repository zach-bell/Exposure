using Core.Contracts;
using UnityEngine;

namespace Core.Utilities.Procedural
{
    public class EasySeedProvider : BaseSeedProvider
    {
        private static int seedLength = 30;

        public EasySeedProvider():base(seedLength)
        {
        }
    }
}