using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Exceptions
{
    public class UniqueException : Exception
    {
        public UniqueException()
        {
        }

        public UniqueException(string message) : base(message)
        {

        }
    }
}
