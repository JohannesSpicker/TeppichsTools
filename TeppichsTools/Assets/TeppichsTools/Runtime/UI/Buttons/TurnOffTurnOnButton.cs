using System.Collections.Generic;
using TeppichsTools.UI.Primitives;
using UnityEngine;

namespace TeppichsTools.UI.Buttons
{
	public class TurnOffTurnOnButton : ButtonSubscriber
	{
		[SerializeField] private List<GameObject> turnOff = new();
		[SerializeField] private List<GameObject> turnOn  = new();

		protected override void PayLoad()
		{
			foreach (GameObject thing in turnOff)
				thing.SetActive(false);

			foreach (GameObject thing in turnOn)
				thing.SetActive(true);
		}
	}
}