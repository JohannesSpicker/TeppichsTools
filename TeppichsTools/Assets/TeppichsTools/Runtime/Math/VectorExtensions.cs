using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace TeppichsTools.Runtime.Math
{
    [SuppressMessage("ReSharper", "InconsistentNaming"), SuppressMessage("ReSharper", "IdentifierTypo")]
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

        #region Cut

        public static Vector2 CutX(this Vector3 vector) => new Vector2(vector.y, vector.z);
        public static Vector2 CutY(this Vector3 vector) => new Vector2(vector.x, vector.z);
        public static Vector2 CutZ(this Vector3 vector) => new Vector2(vector.x, vector.y);

        public static Vector3 CutX(this Vector4 vector) => new Vector3(vector.y, vector.z, vector.w);
        public static Vector3 CutY(this Vector4 vector) => new Vector3(vector.x, vector.z, vector.w);
        public static Vector3 CutZ(this Vector4 vector) => new Vector3(vector.x, vector.y, vector.w);
        public static Vector3 CutW(this Vector4 vector) => new Vector3(vector.x, vector.y, vector.z);

        #endregion

        #region Add

        public static Vector3 AddZ(this Vector2 vector, float value) => new Vector3(vector.x, vector.y, value);

        public static Vector4 AddW(this Vector3 vector, float value) =>
            new Vector4(vector.x, vector.y, vector.z, value);

        #endregion

        #region Swizzle

        public static Vector2 SwizzleYX(this Vector2 vector) => new Vector2(vector.y, vector.x);

        public static Vector3 SwizzleXZY(this Vector3 vector) => new Vector3(vector.x, vector.z, vector.y);
        public static Vector3 SwizzleYXZ(this Vector3 vector) => new Vector3(vector.y, vector.x, vector.z);
        public static Vector3 SwizzleYZX(this Vector3 vector) => new Vector3(vector.y, vector.z, vector.x);
        public static Vector3 SwizzleZXY(this Vector3 vector) => new Vector3(vector.z, vector.x, vector.y);
        public static Vector3 SwizzleZYX(this Vector3 vector) => new Vector3(vector.z, vector.y, vector.x);

        public static Vector4 SwizzleXYWZ(this Vector4 vector) => new Vector4(vector.x, vector.y, vector.w, vector.z);
        public static Vector4 SwizzleXZYW(this Vector4 vector) => new Vector4(vector.x, vector.z, vector.y, vector.w);
        public static Vector4 SwizzleXZWY(this Vector4 vector) => new Vector4(vector.x, vector.z, vector.w, vector.y);
        public static Vector4 SwizzleXWYZ(this Vector4 vector) => new Vector4(vector.x, vector.w, vector.y, vector.z);
        public static Vector4 SwizzleXWZY(this Vector4 vector) => new Vector4(vector.x, vector.w, vector.z, vector.y);

        public static Vector4 SwizzleYXZW(this Vector4 vector) => new Vector4(vector.y, vector.x, vector.z, vector.w);
        public static Vector4 SwizzleYXWZ(this Vector4 vector) => new Vector4(vector.y, vector.x, vector.w, vector.z);
        public static Vector4 SwizzleYZXW(this Vector4 vector) => new Vector4(vector.y, vector.z, vector.x, vector.w);
        public static Vector4 SwizzleYZWX(this Vector4 vector) => new Vector4(vector.y, vector.z, vector.w, vector.x);
        public static Vector4 SwizzleYWXZ(this Vector4 vector) => new Vector4(vector.y, vector.w, vector.x, vector.z);
        public static Vector4 SwizzleYWZX(this Vector4 vector) => new Vector4(vector.y, vector.w, vector.z, vector.x);

        public static Vector4 SwizzleZXYW(this Vector4 vector) => new Vector4(vector.z, vector.x, vector.y, vector.w);
        public static Vector4 SwizzleZXWY(this Vector4 vector) => new Vector4(vector.z, vector.x, vector.w, vector.y);
        public static Vector4 SwizzleZYXW(this Vector4 vector) => new Vector4(vector.z, vector.y, vector.x, vector.w);
        public static Vector4 SwizzleZYWX(this Vector4 vector) => new Vector4(vector.z, vector.y, vector.w, vector.x);
        public static Vector4 SwizzleZWXY(this Vector4 vector) => new Vector4(vector.z, vector.w, vector.x, vector.y);
        public static Vector4 SwizzleZWYX(this Vector4 vector) => new Vector4(vector.z, vector.y, vector.y, vector.x);

        public static Vector4 SwizzleWXYZ(this Vector4 vector) => new Vector4(vector.w, vector.x, vector.y, vector.z);
        public static Vector4 SwizzleWXZY(this Vector4 vector) => new Vector4(vector.w, vector.x, vector.z, vector.y);
        public static Vector4 SwizzleWYXZ(this Vector4 vector) => new Vector4(vector.w, vector.y, vector.x, vector.z);
        public static Vector4 SwizzleWYZX(this Vector4 vector) => new Vector4(vector.w, vector.y, vector.z, vector.x);
        public static Vector4 SwizzleWZXY(this Vector4 vector) => new Vector4(vector.w, vector.z, vector.x, vector.y);
        public static Vector4 SwizzleWZYX(this Vector4 vector) => new Vector4(vector.w, vector.z, vector.y, vector.x);

        #endregion
    }
}