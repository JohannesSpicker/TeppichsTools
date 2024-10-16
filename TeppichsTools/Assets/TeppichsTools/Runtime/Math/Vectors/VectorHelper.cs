﻿using UnityEngine;

namespace TeppichsTools.Math.Vectors
{
	public static class VectorHelper
	{
		public static Vector2 GetDirectionXZ(Vector3 start, Vector3 end) => new(end.x - start.x, end.z - start.z);
	}
}