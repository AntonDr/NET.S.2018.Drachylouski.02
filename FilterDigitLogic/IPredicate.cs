using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigitLogic
{
    /// <summary>
    /// The interface that implements the method IsDigit
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPredicate<T>
    {
        bool IsDigit(int check);
    }
}
