using UnityEngine;

namespace TeppichsTools.Behavior.StepLocks
{
	public sealed class UnsafeStepLock
	{
		public bool IsLocked => 0 < LockNumber;
		public bool IsOpen   => !IsLocked;

		public int LockNumber { get; private set; }

		public void Lock()        => LockNumber++;
		public void Unlock()      => LockNumber = Mathf.Max(LockNumber - 1, 0);
		public void ForceUnlock() => LockNumber = 0;
	}
}