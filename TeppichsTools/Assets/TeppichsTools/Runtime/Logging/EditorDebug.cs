using System;
using UnityEngine;

namespace TeppichsTools.Runtime.Logging
{
    public static class EditorDebug
    {
        public static void Log(object        message) => DoLog(message, Debug.Log);
        public static void LogError(object   message) => DoLog(message, Debug.LogError);
        public static void LogWarning(object message) => DoLog(message, Debug.LogWarning);

        private static void DoLog(object message, Action<object> log)
        {
#if UNITY_EDITOR
            log(message);
#endif
        }
    }
}