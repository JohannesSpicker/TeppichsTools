using UnityEngine;

namespace TeppichsTools.Runtime.Math.Vectors
{
    public static class VectorHelper
    {
        public static Vector2 GetDirectionXZ(Vector3 start, Vector3 end) =>
            new Vector2(end.x - start.x, end.z - start.z);
    }
}