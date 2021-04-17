﻿using TeppichsTools.Runtime.Logging;
using UnityEngine;

namespace TeppichsTools.Runtime.Creation
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T s_instance;

        public static T Instance
        {
            get
            {
                if (s_instance is null)
                {
                    T[] candidates = FindObjectsOfType<T>();

                    if (candidates.Length == 0)
                        s_instance = new GameObject("MonoSingleton_" + nameof(T)).AddComponent<T>();
                    else
                    {
                        s_instance = candidates[0];

                        for (int i = 1; i < candidates.Length; i++)
                        {
                            EditorDebug.LogWarning("Found multiple instances of the MonoSingleton of type "
                                                   + typeof(T));

                            Destroy(candidates[i]);
                        }
                    }
                }

                return s_instance;
            }
        }
    }
}