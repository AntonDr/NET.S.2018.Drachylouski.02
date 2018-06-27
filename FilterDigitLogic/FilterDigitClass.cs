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
        public static int[] FilterDigit<T>(this int[] array, IPredicate<T> predicate)
        {
            Validate(array,predicate);

            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate.IsDigit(array[i]))
                {
                    list.Add(array[i]);
                }
            }

            return list.ToArray();
        }

        /// <summary>
        /// Data validation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">Source array</param>
        /// <param name="predicate">Filter criterion</param>
        private static void Validate<T>(int[] array, IPredicate<T> predicate)
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
