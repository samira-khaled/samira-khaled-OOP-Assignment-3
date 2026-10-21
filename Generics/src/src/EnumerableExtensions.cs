using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace src
{
    public static class EnumerableExtensions
    {

        public static IEnumerable<T> Page<T>(this IEnumerable<T> source,int pageNumber,int pageSize)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (pageNumber <= 0 || pageSize <= 0)
                throw new ArgumentException("Page number and page size must be greater than zero.");

            int startIndex = (pageNumber - 1) * pageSize;
            int endIndex = startIndex + pageSize;
            int index = 0;

            foreach (var item in source)
            {
                if (index >= startIndex && index < endIndex)
                    yield return item;

                index++;

                if (index >= endIndex)
                    yield break;
            }
        }
        public static T FindById<T>(this IEnumerable<T>source,int id)where T:IHasId
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            foreach(var item in source)
            {
                if(item.Id==id)
                {
                    return item;
                }
            }
            return default;

        }
        public static IReadOnlyDictionary<int, T>ToIdDictionary<T>( this IEnumerable<T>source)where T:IHasId
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            var dictionary = new Dictionary<int, T>();
            foreach (var item in source)
            {
                if (dictionary.ContainsKey(item.Id))
                    throw new ArgumentException(
                        $"Duplicate ID found: {item.Id}");

                dictionary.Add(item.Id, item);
            }

            return dictionary;
        }

    }
}
