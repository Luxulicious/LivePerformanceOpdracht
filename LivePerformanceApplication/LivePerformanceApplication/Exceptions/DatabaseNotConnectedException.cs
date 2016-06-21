using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceApplication.Exceptions
{
    public class DatabaseNotConnectedException : Exception
    {
        public DatabaseNotConnectedException()
        {
        }

        public DatabaseNotConnectedException(string message) : base(message)
        {

        }
    }
}
