using System;
using TeppichsTools.Data;
using UnityEngine;

[Serializable]
public class Thing : MonoBehaviour
{

    [SerializeField] public someDictionary bla = new someDictionary();

}

public class someDictionary : UnitySerializedDictionary<int, int>{}