using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class OddnumberException : Exception
    {
        public override string Message 
        {
            get
            {
                return "Divide no should be Even no";
            }
        }
    }
}
