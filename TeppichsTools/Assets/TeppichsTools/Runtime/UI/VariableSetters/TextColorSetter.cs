using TMPro;
using UnityEngine;

namespace TeppichsTools.Runtime.UI
{
    [RequireComponent(typeof(TMP_Text))]
    internal class TextColorSetter : ColorSetter<TMP_Text>
    {
        protected override void SetComponentVariable() => myComponent.color = pickedVariable.color;
    }
}