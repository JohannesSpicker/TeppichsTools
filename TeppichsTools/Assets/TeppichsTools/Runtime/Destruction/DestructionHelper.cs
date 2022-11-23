﻿using UnityEngine;

namespace TeppichsTools.Runtime.Destruction
{
    public static class DestructionHelper
    {
        public static void DestroyGameObject(GameObject gameObject)
        {
#if UNITY_EDITOR
            Object.DestroyImmediate(gameObject);
#else
            Object.Destroy(gameObject);
#endif
        }
    }
}