using System.Collections.Generic;
using System.Linq;
using TeppichsTools.Destruction;
using UnityEngine;

namespace TeppichsTools.Creation.Pools
{
	public sealed class PrefabObjectPool<T> : IObjectPool<T> where T : MonoBehaviour
	{
		private readonly Transform parent;
		public readonly  List<T>   pool = new();

		private readonly T prefab;

		public PrefabObjectPool(T prefab, Transform parent)
		{
			this.prefab = prefab;
			this.parent = parent;
		}

		public IEnumerable<T> Free  => pool.Where(x => !x.gameObject.activeSelf);
		public IEnumerable<T> InUse => pool.Where(x => x.gameObject.activeSelf);

		public T Next()
		{
			foreach (T candidate in Free)
			{
				candidate.gameObject.SetActive(true);

				return candidate;
			}

			return ExtendPool();
		}

		public void Release(T released) => released.gameObject.SetActive(false);

		public void Cull()
		{
			foreach (T clutter in Free.ToList())
			{
				pool.Remove(clutter);
				DestructionHelper.DestroyGameObject(clutter.gameObject);
			}
		}

		public void ReleaseAll()
		{
			foreach (T element in InUse)
				Release(element);
		}

		private T ExtendPool()
		{
			T[] newThings = new T[pool.Count + 1];

			for (int i = 0; i < newThings.Length; i++)
			{
				newThings[i] = Object.Instantiate(prefab, parent);
				newThings[i].gameObject.SetActive(false);
			}

			pool.AddRange(newThings);

			newThings[0].gameObject.SetActive(true);

			return newThings[0];
		}
	}
}