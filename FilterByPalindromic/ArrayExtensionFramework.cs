using System;
using System.Collections.Generic;

namespace FilterByPalindromic
{
    public static partial class ArrayExtension
    {
        /// <summary>
        /// Returns new array of elements that satisfy some predicate.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>New array of elements that satisfy some predicate.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int[] FilterByPredicate(this int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }

            List<int> newArray = new List<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if (IsPalindromicNumber(source[i]))
                {
                    newArray.Add(source[i]);
                }
            }

            return newArray.ToArray();
        }

        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                return false;
            }

            char[] numbers = number.ToString().ToCharArray();

            var i = 0;

            while (i < numbers.Length / 2)
            {
                if (numbers[i] == numbers[(numbers.Length - 1) - i])
                {
                    i++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static partial void AddAccordingToPredicate(ICollection<int> list, int item);
    }
}