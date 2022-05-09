using TeppichsTools.Data;
using UnityEngine;

namespace TeppichsTools.Runtime.UI
{
    internal abstract class ColorSetter<T> : VariableSetter<T, PickedColor> where T : MonoBehaviour { }
}