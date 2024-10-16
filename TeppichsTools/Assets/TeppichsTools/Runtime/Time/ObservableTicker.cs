using System;

namespace TeppichsTools.Time
{
	public class ObservableTicker : Ticker
	{
		public ObservableTicker(float duration) : base(duration) { }
		public event Action<float> OnTick;
		public event Action        OnCompleted;

		public override bool Tick(float delta)
		{
			bool isDone = base.Tick(delta);
			OnTick?.Invoke(counter);

			if (isDone)
				OnCompleted?.Invoke();

			return isDone;
		}
	}
}