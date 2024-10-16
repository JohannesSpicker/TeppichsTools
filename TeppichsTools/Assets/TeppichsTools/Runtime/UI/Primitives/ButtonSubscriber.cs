using UnityEngine;
using UnityEngine.UI;

namespace TeppichsTools.UI.Primitives
{
	public abstract class ButtonSubscriber : MonoBehaviour
	{
		[SerializeField] private Button button;

		private            void Awake()      => button.onClick.AddListener(PayLoad);
		protected virtual  void OnValidate() => button = GetComponent<Button>();
		protected abstract void PayLoad();
	}
}