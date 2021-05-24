using System;

namespace korsback.dotnet.extensions
{
public static class EntityExtensions
    {
        public static void Use<T>(this T e, Action<T> action) where T : class
        {
            action(e);
        }

        public static void UseIfNotNull<T>(this T e, Action<T> action) where T : class
        {
            e?.Use(action);
        }
    }
}