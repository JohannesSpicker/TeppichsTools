using TMPro;
using UnityEngine;

namespace TeppichsTools.UI.VariableSetters
{
	[RequireComponent(typeof(TMP_Text))]
	internal class TextColorSetter : ColorSetter<TMP_Text>
	{
		protected override void SetComponentVariable() => myComponent.color = pickedVariable.color;
	}
}