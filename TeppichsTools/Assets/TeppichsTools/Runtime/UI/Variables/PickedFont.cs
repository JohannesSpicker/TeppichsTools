using TMPro;
using UnityEngine;

namespace TeppichsTools.UI.Variables
{
	[CreateAssetMenu(menuName = "TeppichsTools/UI/Picked Font", fileName = "PickedFont New")]
	public class PickedFont : ScriptableObject
	{
		public TMP_FontAsset font;
	}
}