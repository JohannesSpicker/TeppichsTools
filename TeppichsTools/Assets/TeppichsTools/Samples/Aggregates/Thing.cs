using System;
using TeppichsTools.Data;
using UnityEngine;

namespace TeppichsTools.Samples.Aggregates
{
	[Serializable]
	public sealed class Thing : MonoBehaviour
	{
		[SerializeField] public SomeDictionary bla = new();
	}

	public sealed class SomeDictionary : UnitySerializedDictionary<int, int> { }
}