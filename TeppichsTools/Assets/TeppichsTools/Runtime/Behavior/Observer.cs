using System;

namespace TeppichsTools.Behavior
{
	public abstract class Observer<T>
	{
		private readonly Action<T>     action;
		private readonly Observable<T> observable;

		protected Observer(Observable<T> observable, Action<T> action)
		{
			this.action     = action;
			this.observable = observable;

			observable.Subscribe(action);
		}

		public void Deconstruct() => observable.Unsubscribe(action);
	}
}