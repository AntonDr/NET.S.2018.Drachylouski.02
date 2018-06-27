using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterDigitLogic;

namespace FilterDigitTest
{
    public class DigitZeroPredicate : IPredicate<int>
    {
        private readonly int digit = 0;

        public bool IsDigit(int check)
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

    public class DigitOnePredicate : IPredicate<int>
    {
        private readonly int digit = 1;

        public bool IsDigit(int check)
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

    public class DigitTwoPredicate : IPredicate<int>
    {
        private readonly int digit = 2;

        public bool IsDigit(int check)
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

    public class DigitThreePredicate : IPredicate<int>
    {
        private readonly int digit = 3;

        public bool IsDigit(int check)
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

    public class DigitFourPredicate : IPredicate<int>
    {
        private readonly int digit = 4;

        public bool IsDigit(int check)
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

    public class DigitFivePredicate : IPredicate<int>
    {
        private readonly int digit = 5;

        public bool IsDigit(int check)
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

    public class DigitSixPredicate : IPredicate<int>
    {
        private readonly int digit = 6;

        public bool IsDigit(int check)
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

    public class DigitSevenPredicate : IPredicate<int>
    {
        private readonly int digit = 7;

        public bool IsDigit(int check)
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

    public class DigitEightPredicate : IPredicate<int>
    {
        private readonly int digit = 8;

        public bool IsDigit(int check)
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

    public class DigitNinePredicate : IPredicate<int>
    {
        private readonly int digit = 9;

        public bool IsDigit(int check)
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
