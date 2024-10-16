using UnityEngine;

namespace TeppichsTools.UI.VariableSetters
{
	public abstract class VariableSetter<T, T1> : MonoBehaviour where T : MonoBehaviour
	{
		[SerializeField] protected T  myComponent;
		[SerializeField] protected T1 pickedVariable;

		private void Awake() => RefreshVariable();

#if UNITY_EDITOR
		private void OnValidate() => RefreshVariable();
#endif

		private void RefreshVariable()
		{
			if (pickedVariable is null)
				return;

			GetMyComponent();

			if (myComponent is null)
				return;

			SetComponentVariable();
		}

		private            void GetMyComponent() => myComponent = GetComponent<T>();
		protected abstract void SetComponentVariable();
	}
}