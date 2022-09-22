using UnityEditor;

namespace TeppichsTools.Behavior
{
    public static class QuitHelper
    {
#if UNITY_WEBPLAYER
     public static string webplayerQuitURL = "about:blank";
#endif
        public static void Quit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
            Application.OpenURL(webplayerQuitURL);
#else
            Application.Quit();
#endif
        }
    }
}