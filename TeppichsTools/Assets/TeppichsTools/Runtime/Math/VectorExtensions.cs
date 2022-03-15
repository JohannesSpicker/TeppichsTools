using UnityEngine;

namespace TeppichsTools.Runtime.Math
{
    public static class VectorExtensions
    {
        #region Set

        public static Vector2 SetX(this Vector2 vector, float value) => new Vector2(value,    vector.y);
        public static Vector2 SetY(this Vector2 vector, float value) => new Vector2(vector.x, value);

        public static Vector3 SetX(this Vector3 vector, float value) => new Vector3(value,    vector.y, vector.z);
        public static Vector3 SetY(this Vector3 vector, float value) => new Vector3(vector.x, value,    vector.z);
        public static Vector3 SetZ(this Vector3 vector, float value) => new Vector3(vector.x, vector.y, value);

        public static Vector4 SetX(this Vector4 vector, float value) =>
            new Vector4(value, vector.y, vector.z, vector.w);

        public static Vector4 SetY(this Vector4 vector, float value) =>
            new Vector4(vector.x, value, vector.z, vector.w);

        public static Vector4 SetZ(this Vector4 vector, float value) =>
            new Vector4(vector.x, vector.y, value, vector.w);

        public static Vector4 SetW(this Vector4 vector, float value) =>
            new Vector4(vector.x, vector.y, vector.z, value);

        #endregion

        #region Drop

        public static Vector2 DropX(this Vector2 vector) => new Vector2(0f,       vector.y);
        public static Vector2 DropY(this Vector2 vector) => new Vector2(vector.x, 0f);

        public static Vector3 DropX(this Vector3 vector) => new Vector3(0f,       vector.y, vector.z);
        public static Vector3 DropY(this Vector3 vector) => new Vector3(vector.x, 0f,       vector.z);
        public static Vector3 DropZ(this Vector3 vector) => new Vector3(vector.x, vector.y, 0f);

        public static Vector4 DropX(this Vector4 vector) => new Vector4(0f,       vector.y, vector.z, vector.w);
        public static Vector4 DropY(this Vector4 vector) => new Vector4(vector.x, 0f,       vector.z, vector.w);
        public static Vector4 DropZ(this Vector4 vector) => new Vector4(vector.x, vector.y, 0f,       vector.w);
        public static Vector4 DropW(this Vector4 vector) => new Vector4(vector.x, vector.y, vector.z, 0);

        #endregion
    }
}