using UnityEngine;

namespace TeppichsTools.Runtime.Math
{
    public static class VectorExtensions
    {
        public static Vector2 DropX(this Vector2 vector) => new Vector2(0f,       vector.y);
        public static Vector2 DropY(this Vector2 vector) => new Vector2(vector.x, 0f);

        public static Vector3 DropX(this Vector3 vector) => new Vector3(0f,       vector.y, vector.z);
        public static Vector3 DropY(this Vector3 vector) => new Vector3(vector.x, 0f,       vector.z);
        public static Vector3 DropZ(this Vector3 vector) => new Vector3(vector.x, vector.y, 0f);
    }
}