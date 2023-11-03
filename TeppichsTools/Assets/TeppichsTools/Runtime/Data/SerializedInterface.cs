using UnityEngine;

namespace TeppichsTools.Data
{
    public sealed class SerializedInterface<T> : ISerializationCallbackReceiver where T : class
    {
        private T backingField;
        private bool hasNoNeedToCast;
        [SerializeField] private Object serializedObject;

        public T Value
        {
            get
            {
                if (hasNoNeedToCast)
                    return backingField;

                hasNoNeedToCast = true;
                return backingField = (serializedObject as GameObject)?.GetComponent<T>();
            }
            private set => backingField = value;
        }

        public void OnBeforeSerialize()
        {
            if (serializedObject == null) return;

            if (serializedObject is not (ScriptableObject and T) &&
                (serializedObject is not GameObject gameObject || gameObject.GetComponent<T>() == null) &&
                serializedObject is not (MonoBehaviour and T))
                serializedObject = null;
        }

        public void OnAfterDeserialize()
        {
            switch (serializedObject)
            {
                case (ScriptableObject or MonoBehaviour) and T bla:
                    Value = bla;
                    hasNoNeedToCast = true;
                    break;
                case GameObject:
                    hasNoNeedToCast = false;
                    break;
                default:
                    backingField = null;
                    break;
            }
        }
    }
}