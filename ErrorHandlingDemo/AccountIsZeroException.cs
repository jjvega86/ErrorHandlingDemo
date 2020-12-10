using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingDemo
{
    class AccountIsZeroException : Exception
    {
        public AccountIsZeroException(string message)
            :base(message)
        {

        }
    }
}
