using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TeppichsTools.Creation.Pools
{
    public class PrefabObjectPool<T> : IObjectPool<T> where T : MonoBehaviour
    {
        private readonly Transform parent;
        public readonly  List<T>   pool = new List<T>();

        private readonly T prefab;

        public PrefabObjectPool(T prefab, Transform parent)
        {
            this.prefab = prefab;
            this.parent = parent;
        }

        public IEnumerable<T> Free  => pool.Where(e => !e.gameObject.activeSelf);
        public IEnumerable<T> InUse => pool.Where(e => e.gameObject.activeSelf);

        public T Next()
        {
            foreach (T candidate in Free)
            {
                candidate.gameObject.SetActive(true);

                return candidate;
            }

            T instanced = Object.Instantiate(prefab, parent);
            pool.Add(instanced);

            return instanced;
        }

        public void Release(T released) => released.gameObject.SetActive(false);

        public void Cull()
        {
            foreach (T clutter in Free)
            {
                pool.Remove(clutter);
                Object.Destroy(clutter.gameObject);
            }
        }

        public void ReleaseAll()
        {
            foreach (T element in InUse)
                Release(element);
        }
    }
}