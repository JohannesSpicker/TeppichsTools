﻿namespace TeppichsTools.Time
{
	public class RepeatTicker : Ticker
	{
		public RepeatTicker(float duration) : base(duration) { }

		public override bool Tick(float delta)
		{
			bool isDone = base.Tick(delta);

			if (isDone)
				Reset();

			return isDone;
		}
	}

	public class ObservableRepeatTicker : ObservableTicker
	{
		public ObservableRepeatTicker(float duration) : base(duration) { }

		public override bool Tick(float delta)
		{
			bool isDone = base.Tick(delta);

			if (isDone)
				Reset();

			return isDone;
		}
	}
}