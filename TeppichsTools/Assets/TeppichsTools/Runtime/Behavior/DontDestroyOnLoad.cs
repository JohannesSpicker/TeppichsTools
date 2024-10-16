using UnityEngine;

namespace TeppichsTools.Behavior
{
	public sealed class DontDestroyOnLoad : MonoBehaviour
	{
		private void Awake()
		{
			DontDestroyOnLoad(gameObject);
			Destroy(this);
		}
	}
}