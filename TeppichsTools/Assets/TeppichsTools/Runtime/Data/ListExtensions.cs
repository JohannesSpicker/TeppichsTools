using System.Collections.Generic;
using TeppichsTools.Math.Randomness;

namespace TeppichsTools.Data
{
    public static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            for (int i = list.Count - 1; 0 < i; --i)
            {
                int swap = ThreadSafeRandom.ThisThreadsRandom.Next(i + 1);
                (list[i], list[swap]) = (list[swap], list[i]);
            }
        }
    }
}