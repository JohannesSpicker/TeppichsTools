using UnityEngine;

namespace TeppichsTools.Behavior
{
    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public class TransformCachingMonoBehaviour : MonoBehaviour
    {
        [SerializeField] public Transform myTransform;

        public virtual void OnValidate() => myTransform = transform;
    }
}