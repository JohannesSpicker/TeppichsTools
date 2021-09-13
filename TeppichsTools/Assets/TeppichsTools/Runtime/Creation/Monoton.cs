﻿using TeppichsTools.Logging;
using UnityEngine;

namespace TeppichsTools.Creation
{
    public abstract class Monoton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T s_instance;

        public static T Instance
        {
            get
            {
                if (s_instance)
                    return s_instance;

                T[] candidates = FindObjectsOfType<T>();

                if (candidates.Length == 0)
                    s_instance = new GameObject("Monoton_" + nameof(T)).AddComponent<T>();
                else
                {
                    s_instance = candidates[0];

                    for (int i = 1; i < candidates.Length; i++)
                    {
                        EditorDebug.LogWarning("Found multiple instances of the Monoton of type " + typeof(T));
#if UNITY_EDITOR
                        DestroyImmediate(candidates[i]);
#else
                        Destroy(candidates[i]);
#endif
                    }
                }

                DontDestroyOnLoad(s_instance.gameObject);

                return s_instance;
            }
        }
    }
}