using UnityEngine;

namespace TeppichsTools.UI.Variables
{
	[CreateAssetMenu(menuName = "TeppichsTools/UI/Picked Color", fileName = "PickedColor New")]
	public class PickedColor : ScriptableObject
	{
		public Color color = Color.white;
	}
}