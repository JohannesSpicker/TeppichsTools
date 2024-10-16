using TeppichsTools.Logging;
using UnityEngine;

namespace TeppichsTools.Creation
{
	public abstract class Monoton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T instance;

		public static T Instance
		{
			get
			{
				if (instance)
					return instance;

				T[] candidates = FindObjectsOfType<T>();

				if (candidates.Length == 0)
					instance = new GameObject("Monoton_" + nameof(T)).AddComponent<T>();
				else
				{
					instance = candidates[0];

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
#if !UNITY_EDITOR
                DontDestroyOnLoad(instance.gameObject);
#endif
				return instance;
			}
		}
	}
}