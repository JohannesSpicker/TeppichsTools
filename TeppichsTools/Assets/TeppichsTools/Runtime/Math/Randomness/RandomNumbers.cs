using System.Collections.Generic;
using System.Linq;
using TeppichsTools.Data;
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
			List<int> candidates = new();

			for (int i = range.x; i < range.y; i++)
				candidates.Add(i);

			return candidates.Shuffle().Take(amount).ToList(); //TODO: test this
		}

		/// <summary>
		///     Get amount random ints in range [x,y[
		///     Can return duplicates.
		/// </summary>
		/// <param name="amount">amount of ints returned</param>
		/// <param name="range">min inclusive, max exclusive</param>
		/// <returns>List of non-distinct ints</returns>
		public static List<int> GetRandomInts(int amount, Vector2Int range)
		{
			List<int> numbers = new(amount);

			for (int i = 0; i < amount; i++)
				numbers.Add(ThreadSafeRandom.ThisThreadsRandom.Next(range.x, range.y));

			return numbers;
		}

		/// <summary>
		///     Get amount random floats in range [x,y]
		/// </summary>
		/// <param name="amount">amount of floats returned</param>
		/// <param name="range">min inclusive, max inclusive</param>
		/// <returns>List of floats</returns>
		public static List<float> GetRandomFloats(int amount, Vector2 range)
		{
			List<float> result = new(amount);

			for (int i = 0; i < amount; i++)
				result[i] = Random.Range(range.x, range.y);

			return result;
		}
	}
}