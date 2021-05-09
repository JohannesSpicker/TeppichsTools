using System;
using System.Collections.Generic;

namespace TeppichsTools.Data
{
    [Serializable]
    public class Blackboard
    {
        private Dictionary<Type, Dictionary<string, object>> library =
            new Dictionary<Type, Dictionary<string, object>>();

        public void Clear() => library.Clear();

        public void Write<T>(string id, T value)
        {
            if (!library.ContainsKey(typeof(T)))
                library.Add(typeof(T), new Dictionary<string, object>());

            library[typeof(T)].Add(id, value);
        }

        public T Read<T>(string id)
        {
            try
            {
                return (T) library[typeof(T)][id];
            }
            catch
            {
                return default;
            }
        }
    }
}