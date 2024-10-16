using TeppichsTools.UI.Variables;
using TMPro;
using UnityEngine;

namespace TeppichsTools.UI.VariableSetters
{
	[RequireComponent(typeof(TMP_Text))]
	public class FontSetter : VariableSetter<TMP_Text, PickedFont>
	{
		protected override void SetComponentVariable() => myComponent.font = pickedVariable.font;
	}
}