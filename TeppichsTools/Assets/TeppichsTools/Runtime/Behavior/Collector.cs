using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Collector<T> : MonoBehaviour where T : MonoBehaviour
{
    public static List<T> collection = new List<T>();

    //use onValidate or something different to fill field
    [SerializeField] private T thing;

    private void OnEnable()  => collection.Add(thing);
    private void OnDisable() => collection.Remove(thing);
}