using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigitLogic
{
    public static class FilterDigitClass
    {
        /// <summary>
        /// The FilterDigit method takes an array of integers and filters it so that only numbers containing the specified digit remain on the output
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">Source array</param>
        /// <param name="predicate">Filter criterion</param>
        /// <returns>Filtered array</returns>
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,IPredicate<T> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return Filter(source,predicate.IsMatch);
        }

        /// <summary>
        /// Filters the specified predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// source
        /// or
        /// predicate
        /// </exception>
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return FilterInner<T>(source, predicate);
        }

        /// <summary>
        /// Filters the inner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        private static IEnumerable<T> FilterInner<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var element in source)
            {
                if (predicate(element))
                    yield return element;
            }
        }


        /// <summary>
        /// Data validation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">Source array</param>
        /// <param name="predicate">Filter criterion</param>
        private static void Validate<T>(T[] array, IPredicate<T> predicate)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length==0)
                throw new ArgumentException($"{nameof(array)} have null argument");

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
        }
    }


}
