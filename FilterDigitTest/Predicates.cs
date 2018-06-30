using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterDigitLogic;

namespace FilterDigitTest
{
    public class DigitPredicate : IPredicate<int>
    {
        public DigitPredicate(int n)
        {
            if (n < 0 || n > 9)
            {
                throw new ArgumentOutOfRangeException();
            }

            digit = n;
        }

        private readonly int digit;

        public bool IsMatch(int check)
        {
            check = Math.Abs(check);

            if (digit == 0 && check == 0)
            {
                return true;
            }
            else
            {
                while (check != 0)
                {

                    if (check % 10 == digit)
                    {
                        return true;
                    }

                    check /= 10;
                }
            }

            return false;
        }
    }
}
