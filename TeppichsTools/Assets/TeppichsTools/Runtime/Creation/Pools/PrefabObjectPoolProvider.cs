using System.Collections.Generic;
using UnityEngine;

namespace TeppichsTools.Creation.Pools
{
    public sealed class PrefabObjectPoolProvider<T> : Singleton<PrefabObjectPoolProvider<T>> where T : MonoBehaviour
    {
        private Dictionary<MonoBehaviour, PrefabObjectPool<T>> pools =
            new Dictionary<MonoBehaviour, PrefabObjectPool<T>>();

        public T Next(T prefab)
        {
            if (pools.ContainsKey(prefab))
                return pools[prefab].Next();

            Transform poolParent = new GameObject(prefab.name + " Pool").transform;
            pools[prefab] = new PrefabObjectPool<T>(prefab, poolParent);

            return pools[prefab].Next();
        }

        public void CullPools()
        {
            foreach (PrefabObjectPool<T> pool in pools.Values)
                pool.Cull();
        }

        /// <summary>
        /// Resets the pool dictionary. Call when unloading active scene.
        /// </summary>
        public void ResetPools() => pools = new Dictionary<MonoBehaviour, PrefabObjectPool<T>>();
    }
}