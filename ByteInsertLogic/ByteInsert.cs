using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteInsertLogic
{
    /// <summary>
    /// Class for insert the bytes
    /// </summary>
    public static class ByteInsert
    {
        private const int maxBit = 31;
      
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
            Validate(a,b,i,j);

            int positionDifference = j - i;

            int boxForA = int.MaxValue >> maxBit - (positionDifference + 1);
            boxForA <<= i;
            a &= ~boxForA;

            int boxForB = int.MaxValue >> (maxBit - (positionDifference + 1));
            boxForB &= b;
            boxForB <<= i;

            boxForB &= boxForA;
            return a | boxForB;

        }

        /// <summary>
        /// Data validation
        /// </summary>
        private static void Validate(int a, int b, int i, int j)
        {
            if (a< 0 || b< 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (i>maxBit || j>maxBit || i<0 || j<0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (j<i)
            {
                throw new ArgumentException("j can't be less a i");
            }
        }
    }
}
