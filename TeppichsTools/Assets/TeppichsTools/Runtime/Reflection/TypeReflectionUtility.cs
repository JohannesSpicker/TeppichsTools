﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TeppichsTools.Runtime.Reflection
{
    public static class TypeReflectionUtility
    {
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
    }
}