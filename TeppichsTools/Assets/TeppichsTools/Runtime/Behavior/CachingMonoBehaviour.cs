using UnityEngine;

namespace TeppichsTools.Behavior
{
	// ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
	public class CachingMonoBehaviour : MonoBehaviour
	{
		public Transform  cachedTransform;
		public GameObject cachedGameObject;

		public virtual void OnValidate()
		{
			cachedTransform  = transform;
			cachedGameObject = gameObject;
		}
	}
}