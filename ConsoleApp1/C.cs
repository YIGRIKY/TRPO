using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class C : B
    {
        private object b;
        public C(object a, object b): base(a)
        {
            this.b = b;
        }
    }
}
