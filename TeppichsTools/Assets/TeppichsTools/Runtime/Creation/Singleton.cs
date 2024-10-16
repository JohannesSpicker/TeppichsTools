﻿namespace TeppichsTools.Creation
{
	public abstract class Singleton<T> where T : new()
	{
		private static T instance;

		public static T Instance
		{
			get
			{
				if (instance is null)
					instance = new T();

				return instance;
			}
		}
	}
}