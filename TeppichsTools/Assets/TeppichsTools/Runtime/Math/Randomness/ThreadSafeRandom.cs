using System;
using System.Threading;

namespace TeppichsTools.Math.Randomness
{
    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random local;

        public static Random ThisThreadsRandom => local ??=
            new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId));
    }
}