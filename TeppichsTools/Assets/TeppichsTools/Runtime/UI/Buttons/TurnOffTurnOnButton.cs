using System.Collections.Generic;
using TeppichsTools.UI.Primitives;
using UnityEngine;

namespace TeppichsTools.Runtime.UI.Buttons
{
    public class TurnOffTurnOnButton : ButtonSubscriber
    {
        [SerializeField] private List<GameObject> turnOff = new List<GameObject>();
        [SerializeField] private List<GameObject> turnOn  = new List<GameObject>();

        protected override void PayLoad()
        {
            foreach (GameObject thing in turnOff)
                thing.SetActive(false);

            foreach (GameObject thing in turnOn)
                thing.SetActive(true);
        }
    }
}