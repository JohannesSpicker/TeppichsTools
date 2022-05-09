using TeppichsTools.Data;
using TMPro;
using UnityEngine;

namespace TeppichsTools.Runtime.UI
{
    [RequireComponent(typeof(TMP_Text))]
    public class FontSetter : VariableSetter<TMP_Text, PickedFont>
    {
        protected override void SetComponentVariable() => myComponent.font = pickedVariable.font;
    }
}