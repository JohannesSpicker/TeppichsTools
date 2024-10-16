using TeppichsTools.UI.Variables;
using UnityEngine;

namespace TeppichsTools.UI.VariableSetters
{
	internal abstract class ColorSetter<T> : VariableSetter<T, PickedColor> where T : MonoBehaviour { }
}