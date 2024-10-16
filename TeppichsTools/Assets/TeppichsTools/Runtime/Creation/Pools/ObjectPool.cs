using System.Collections.Generic;

namespace TeppichsTools.Creation.Pools
{
	public sealed class ObjectPool<T> : IObjectPool<T> where T : new()
	{
		public readonly List<T> free  = new();
		public readonly List<T> inUse = new();
		public readonly List<T> pool  = new();

		public T Next()
		{
			foreach (T candidate in free)
			{
				free.Remove(candidate);
				inUse.Add(candidate);

				return candidate;
			}

			T instanced = new();
			pool.Add(instanced);
			inUse.Add(instanced);

			return instanced;
		}

		public void Release(T released)
		{
			free.Add(released);
			inUse.Remove(released);
		}

		public void Cull() => free.Clear();
	}
}