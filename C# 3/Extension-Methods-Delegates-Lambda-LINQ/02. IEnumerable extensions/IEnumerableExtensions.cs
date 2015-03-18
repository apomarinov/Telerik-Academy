using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExtensions
{
    static class Extensions
    {
        public static T Min<T>(this IEnumerable<T> collection) 
            where T : IConvertible, IComparable
        {
            ValidateCollection(collection);

            T min = collection.First();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            ValidateCollection(collection);

            T max = collection.First();
            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            ValidateCollection(collection);

            dynamic sum = 0;
            foreach (var element in collection)
            {
                sum += element;
            }

            return sum;
        }

        public static double Average<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            double sum = 0.0;
            return (dynamic)collection.Aggregate(sum, (acc, val) => acc + (dynamic)val) / (dynamic)collection.Count();
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T product = (dynamic)1;
            return collection.Aggregate(product, (acc, val) => acc * (dynamic)val);
        }

        private static void ValidateCollection<T>(IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Empty Collection!");
            }
        }
    }
}
