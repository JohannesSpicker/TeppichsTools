using UnityEngine;
using UnityEngine.UI;

namespace TeppichsTools.Runtime.UI
{
    [RequireComponent(typeof(Image))]
    internal class ImageColorSetter : ColorSetter<Image>
    {
        protected override void SetComponentVariable() => myComponent.color = pickedVariable.color;
    }
}