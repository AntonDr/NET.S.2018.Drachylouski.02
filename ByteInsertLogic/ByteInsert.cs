using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteInsertLogic
{
    /// <summary>
    /// Class for insert the bytes
    /// </summary>
    public static class ByteInsert
    {
        /// <summary>
        /// Converts a number to a string with a binary representation of a given number
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Sting with a binary representation</returns>
        private static StringBuilder DecimalToStringBuilder(int a)
        {
            if (a < 0)
            {
                a = ~a;
            }

            StringBuilder stb = new StringBuilder();

            for (; a != 0; a >>= 1)
            {
                stb.Append((a & 1));
            }

            return stb;
        }

        /// <summary>
        /// Translates a string with a binary representation of a number to this number
        /// </summary>
        /// <param name="str">String with a binary representation</param>
        /// <returns>Number</returns>
        private static int StringToDecimal(String str)
        {
            Validate(str);

            int product = 1, number = 0;

            char[] array = str.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                number += product * (int)Char.GetNumericValue(array[i]);
                product *= 2;
            }

            return number;
        }

        /// <summary>
        /// Implemented the InsertNumber algorithm of inserting bits from the jth to the i-th bit of one number into another so that the bits of the second number occupy positions from bit j by bit i
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="i">From</param>
        /// <param name="j">To</param>
        /// <returns>New number</returns>
        public static int InsertNumber(int a, int b, int i, int j)
        {

            StringBuilder bitA = DecimalToStringBuilder(a);
            StringBuilder bitB = DecimalToStringBuilder(b);

            if (j > bitA.Length)
            {
                while (bitA.Length - j - 1 != 0)
                {
                    bitA.Append(0);
                    bitB.Append(0);

                }
            }

            for (int k = 0; i <= j; i++, k++)
            {
                bitA[i] = bitB[k];
            }

            if (a < 0 || b < 0)
            {
                return ~StringToDecimal(bitA.ToString());
            }
            else
            {
                return StringToDecimal(bitA.ToString());

            }

        }

        /// <summary>
        /// Data validation
        /// </summary>
        /// <param name="obj">Checked object</param>
        private static void Validate(String obj)
        {
            if (String.IsNullOrEmpty(obj))
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }
    }
}
