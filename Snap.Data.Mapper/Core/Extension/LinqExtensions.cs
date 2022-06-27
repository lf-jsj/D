using System;
using System.Collections.Generic;

namespace Snap.Data.Mapper.Core.Extension;
internal static class LinqExtensions
{
    public static IEnumerable<T> Enumerate<T>(this T value)
    {
        yield return value;
    }

    public static IEnumerable<TSource> SkipLastWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        Queue<TSource> queue = new();

        foreach (TSource item in source)
        {
            if (predicate(item))
            {
                queue.Enqueue(item);
            }
            else
            {
                while (queue.TryDequeue(out TSource? yieldItem))
                {
                    yield return yieldItem;
                }

                yield return item;
            }
        }
    }
}
