using System.Collections.Generic;
using UnityEngine;

namespace TeppichsTools.Math.Randomness
{
    public static class RandomNumbers
    {
        /// <summary>
        ///     Get amount random distinct ints in range [x,y[
        ///     Returns at most as many ints as are in range.
        /// </summary>
        /// <param name="amount">amount of ints returned</param>
        /// <param name="range">min inclusive, max exclusive</param>
        /// <returns>List of distinct ints</returns>
        public static List<int> GetDistinctRandomInts(int amount, Vector2Int range)
        {
            List<int> candidates = new List<int>();
            List<int> result     = new List<int>();

            for (int i = range.x; i < range.y; i++)
                candidates.Add(i);

            for (int i = 0; i < amount && 0 < candidates.Count; i++)
            {
                int index = Random.Range(0, candidates.Count);
                result.Add(candidates[index]);
                candidates.Remove(candidates[index]);
            }

            return result;
        }

        /// <summary>
        ///     Get amount random floats in range [x,y]
        /// </summary>
        /// <param name="amount">amount of floats returned</param>
        /// <param name="range">min inclusive, max inclusive</param>
        /// <returns>List of floats</returns>
        public static List<float> GetRandomFloats(int amount, Vector2 range)
        {
            List<float> result = new List<float>(amount);

            for (int i = 0; i < amount; i++)
                result[i] = Random.Range(range.x, range.y);

            return result;
        }
    }
}