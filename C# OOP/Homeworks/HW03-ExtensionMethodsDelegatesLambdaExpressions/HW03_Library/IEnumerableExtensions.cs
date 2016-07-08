using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_Library
{
    public static class IEnumerableExtensions
    {
        public static T MySum<T>(this IEnumerable<T> collection)
        {
            T result = default(T);

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }
            return result;
        }
        public static T MyProduct<T>(this IEnumerable<T> collection)
        {
            T result = default(T);

            foreach (var item in collection)
            {
                result *= (dynamic)item;
            }
            return result;
        }
        public static T MyMin<T>(this IEnumerable<T> collection)
        {
            T min = default(T);

            foreach (var item in collection)
            {
                if (min>(dynamic)item)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T MyMax<T>(this IEnumerable<T> collection)
        {
            T max = default(T);

            foreach (var item in collection)
            {
                if (max < (dynamic)item)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T MyAverage<T>(this IEnumerable<T> collection)
        {
            T average = default(T);
            foreach (var item in collection)
            {
                average += (dynamic)item;
            }
            return (dynamic)average / collection.Count();
        }


    }
}
