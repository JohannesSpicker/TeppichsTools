using System.Collections.Generic;
using UnityEngine;

namespace TeppichsTools.Behavior
{
	[ExecuteAlways]
	public abstract class Collector<T> : MonoBehaviour where T : MonoBehaviour
	{
		public static readonly List<T> collection = new();

		private T thing;

		private void OnEnable()  => collection.Add(thing ??= GetComponent<T>());
		private void OnDisable() => collection.Remove(thing);
	}
}