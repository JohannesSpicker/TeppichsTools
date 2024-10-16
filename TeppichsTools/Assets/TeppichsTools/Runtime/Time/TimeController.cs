namespace TeppichsTools.Time
{
	public static class TimeController
	{
		public static float LastActiveTimeScale { get; private set; } = 1f;

		public static void StartTime() => SetTimeScale(1f);

		public static void TogglePause()
		{
			if (UnityEngine.Time.timeScale == 0f)
				UnpauseTime();
			else
				PauseTime();
		}

		public static void PauseTime()
		{
			LastActiveTimeScale = UnityEngine.Time.timeScale;
			SetTime(0);
		}

		public static void UnpauseTime() => UnityEngine.Time.timeScale = LastActiveTimeScale;

		public static void SetTimeScale(float scale)
		{
			LastActiveTimeScale        = scale;
			UnityEngine.Time.timeScale = scale;
		}

		private static void SetTime(float scale) => UnityEngine.Time.timeScale = scale;
	}
}