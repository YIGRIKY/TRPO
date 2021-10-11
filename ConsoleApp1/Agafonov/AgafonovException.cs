using System;
using System.Collections.Generic;
using System.Text;

namespace AgafonovTheBest
{
    class AgafonovException : Exception
    {
        public AgafonovException(string message): base(message){ }
    }
}
