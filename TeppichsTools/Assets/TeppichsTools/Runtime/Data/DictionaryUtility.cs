using System;
using System.Collections.Generic;

namespace TeppichsTools.Data
{
	public static class DictionaryUtility
	{
		public static Dictionary<T, T1> ShallowCloneDictionary<T, T1, T2, T3>(Dictionary<T, T1> data)
			where T1 : Dictionary<T2, T3>
		{
			Dictionary<T, T1> temp = new();

			//TODO: make function do something

			return temp;
		}

		public static Dictionary<T1, T2> Clone<T1, T2>(Dictionary<T1, T2> dict)
			where T1 : ICloneable where T2 : ICloneable
		{
			if (dict == null)
				return null;

			Dictionary<T1, T2> ret = new();

			foreach (KeyValuePair<T1, T2> e in dict)
				ret[(T1)e.Key.Clone()] = (T2)e.Value.Clone();

			return ret;
		}
	}
}