using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokloni.ba.WebAPI.Exceptions
{
    public class ServerException : Exception
    {
        public ServerException(string message):base(message)
        {

        }
    }
}
