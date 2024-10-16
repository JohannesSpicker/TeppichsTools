using TeppichsTools.Behavior;
using UnityEngine;

namespace TeppichsTools.Samples.Aggregates
{
	[RequireComponent(typeof(Thing))]
	public sealed class ThingCollector : Collector<Thing> { }
}