using System;
using System.Linq;

namespace TeppichsTools.Runtime.Reflection
{
    public static class TypeReflectionUtility
    {
        /*
        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs)
            where T : class, IComparable<T>
        {
            List<T> objects = new List<T>();

            foreach (Type type in Assembly.GetAssembly(typeof(T)).GetTypes()
                                          .Where(myType => myType.IsClass && !myType.IsAbstract
                                                                          && myType.IsSubclassOf(typeof(T))))
                objects.Add((T) Activator.CreateInstance(type, constructorArgs));

            objects.Sort();

            return objects;
        }
        */

        public static Type[] GetSubtypesFromSameAssembly(Type superType) => superType.Assembly.GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(superType)).ToArray();

        public static Type[] GetSubtypesFromAllAssemblies(Type superType) =>
            (from assembly in AppDomain.CurrentDomain.GetAssemblies()
             from typeInAssembly in assembly.GetTypes()
             where typeInAssembly.IsSubclassOf(superType) && !typeInAssembly.IsAbstract
             select typeInAssembly).ToArray();
    }
}